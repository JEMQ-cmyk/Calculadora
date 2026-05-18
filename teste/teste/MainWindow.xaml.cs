using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace teste
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private bool clearText = false;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Event_Click(object sender, RoutedEventArgs e)
        {
            operações operation = new operações();

            Button btn = (Button)sender;

            switch (btn.Name)
            {

                case "btn0":

                    if (clearText)
                    {
                        textarea.Clear();
                        clearText = false;
                    }

                    textarea.Text += "0";
                    break;
                case "btn1":
                    if (clearText)
                    {
                        textarea.Clear();
                        clearText = false;
                    }
                    textarea.Text += "1";
                    break;
                case "btn2":
                    if (clearText)
                    {
                        textarea.Clear();
                        clearText = false;
                    }
                    textarea.Text += "2";
                    break;
                case "btn3":
                    if (clearText)
                    {
                        textarea.Clear();
                        clearText = false;
                    }
                    textarea.Text += "3";
                    break;
                case "btn4":
                    if (clearText)
                    {
                        textarea.Clear();
                        clearText = false;
                    }
                    textarea.Text += "4";
                    break;
                case "btn5":
                    if (clearText)
                    {
                        textarea.Clear();
                        clearText = false;
                    }
                    textarea.Text += "5";
                    break;
                case "btn6":
                    if (clearText)
                    {
                        textarea.Clear();
                        clearText = false;
                    }
                    textarea.Text += "6";
                    break;
                case "btn7":
                    if (clearText)
                    {
                        textarea.Clear();
                        clearText = false;
                    }
                    textarea.Text += "7";
                    break;
                case "btn8":
                    if (clearText)
                    {
                        textarea.Clear();
                        clearText = false;
                    }
                    textarea.Text += "8";
                    break;
                case "btn9":
                    if (clearText)
                    {
                        textarea.Clear();
                        clearText = false;
                    }
                    textarea.Text += "9";
                    if (clearText)
                    {
                        textarea.Clear();
                        clearText = false;
                    }
                    break;
                case "btnSoma":
                    if (clearText)
                    {
                        textarea.Clear();
                        clearText = false;
                    }
                    textarea.Text += "+";
                    break;
                case "btnSub":
                    if (clearText)
                    {
                        textarea.Clear();
                        clearText = false;
                    }
                    textarea.Text += "-";
                    break;
                case "btnMult":
                    if (clearText)
                    {
                        textarea.Clear();
                        clearText = false;
                    }
                    textarea.Text += "x";
                    break;
                case "btnIgual":
                    string? operação = textarea.Text;
                    textarea.Clear();
                    textarea.Text = "=" + operation.operations(operação);
                    clearText = true;
                    break;


            }
            ;


        }
    }
}