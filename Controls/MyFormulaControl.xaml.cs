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
        // BindableProperty, ����� �������� ������� ����� (�� XAML ��� ����)
        public static readonly BindableProperty FormulaProperty =
            BindableProperty.Create(
                nameof(Formula),
                typeof(string),
                typeof(MyFormulaControl),
                defaultValue: "",
                propertyChanged: OnFormulaChanged);

        // ������� ��������, �������� � BindableProperty
        public string Formula
        {
            get => (string)GetValue(FormulaProperty);
            set => SetValue(FormulaProperty, value);
        }

        public MyFormulaControl()
        {
            InitializeComponent();
        }

        // ����� Formula ��������, ������������ �����
        private static void OnFormulaChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (MyFormulaControl)bindable;
            control.RebuildLayout();
        }

        private void RebuildLayout()
        {
            // ������� �������� ��������, �.�. ����� ������������ ������
            Container.Children.Clear();

            var formula = Formula ?? string.Empty;

            int currentIndex = 0;
            while (currentIndex < formula.Length)
            {
                // ���� ����������� �������� ������
                int openBraceIndex = formula.IndexOf('{', currentIndex);
                if (openBraceIndex < 0)
                {
                    // ���� '{' ��� - ��������� ���������� ����� ��� Label
                    var textTail = formula.Substring(currentIndex);
                    if (!string.IsNullOrWhiteSpace(textTail))
                    {
                        Container.Children.Add(new Label { Text = textTail });
                    }
                    break;
                }
                else
                {
                    // ��������� ����� �� '{'
                    var textBefore = formula.Substring(currentIndex, openBraceIndex - currentIndex);
                    if (!string.IsNullOrWhiteSpace(textBefore))
                    {
                        Container.Children.Add(new Label { Text = textBefore });
                    }

                    // ���� ����������� '}'
                    int closeBraceIndex = formula.IndexOf('}', openBraceIndex);
                    if (closeBraceIndex < 0)
                    {
                        // ���� ��� '}', ����� ������������� ��� �� ������
                        // ��� ������ �������� ���������� ����� ��� �����
                        var textError = formula.Substring(openBraceIndex);
                        Container.Children.Add(new Label
                        {
                            Text = textError,
                            TextColor = Color.Red
                        });
                        break;
                    }

                    // �������� ��� ������������ (��������, coef1, coef2 � �.�.)
                    var entryName = formula.Substring(openBraceIndex + 1,
                                                      closeBraceIndex - openBraceIndex - 1);

                    // ������ Entry (����� ��������� �����, ������ � �.�.)
                    var entry = new Entry
                    {
                        Placeholder = entryName,
                        WidthRequest = 40
                    };
                    Container.Children.Add(entry);

                    // ����������� ��������� �� '}'
                    currentIndex = closeBraceIndex + 1;
                }
            }
        }
    }
}