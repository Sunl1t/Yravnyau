using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls;
using Microsoft.Maui;
using System.ComponentModel;

namespace Yravnyai.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyFormulaControl : ContentView
    {
        // BindableProperty, чтобы задавать формулу извне (из XAML или кода)
        public static readonly BindableProperty FormulaProperty =
            BindableProperty.Create(
                nameof(Formula),
                typeof(string),
                typeof(MyFormulaControl),
                defaultValue: "",
                propertyChanged: OnFormulaChanged);

        // Обычное свойство, обёрнутое в BindableProperty
        public string Formula
        {
            get => (string)GetValue(FormulaProperty);
            set => SetValue(FormulaProperty, value);
        }

        public MyFormulaControl()
        {
            InitializeComponent();
        }

        // Когда Formula меняется, пересобираем макет
        private static void OnFormulaChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (MyFormulaControl)bindable;
            control.RebuildLayout();
        }

        private void RebuildLayout()
        {
            // Очищаем дочерние элементы, т.к. будем генерировать заново
            Container.Children.Clear();

            var formula = Formula ?? string.Empty;

            int currentIndex = 0;
            while (currentIndex < formula.Length)
            {
                // Ищем открывающую фигурную скобку
                int openBraceIndex = formula.IndexOf('{', currentIndex);
                if (openBraceIndex < 0)
                {
                    // Если '{' нет - добавляем оставшийся текст как Label
                    var textTail = formula.Substring(currentIndex);
                    if (!string.IsNullOrWhiteSpace(textTail))
                    {
                        Container.Children.Add(new Label { Text = textTail });
                    }
                    break;
                }
                else
                {
                    // Добавляем текст до '{'
                    var textBefore = formula.Substring(currentIndex, openBraceIndex - currentIndex);
                    if (!string.IsNullOrWhiteSpace(textBefore))
                    {
                        Container.Children.Add(new Label { Text = textBefore });
                    }

                    // Ищем закрывающую '}'
                    int closeBraceIndex = formula.IndexOf('}', openBraceIndex);
                    if (closeBraceIndex < 0)
                    {
                        // Если нет '}', можно отреагировать как на ошибку
                        // или просто добавить оставшуюся часть как текст
                        var textError = formula.Substring(openBraceIndex);
                        Container.Children.Add(new Label
                        {
                            Text = textError,
                            TextColor = Color.Red
                        });
                        break;
                    }

                    // Вырезаем имя плейсхолдера (например, coef1, coef2 и т.д.)
                    var entryName = formula.Substring(openBraceIndex + 1,
                                                      closeBraceIndex - openBraceIndex - 1);

                    // Создаём Entry (можно настроить стиль, ширину и т.д.)
                    var entry = new Entry
                    {
                        Placeholder = entryName,
                        WidthRequest = 40
                    };
                    Container.Children.Add(entry);

                    // Передвигаем указатель за '}'
                    currentIndex = closeBraceIndex + 1;
                }
            }
        }
    }
}