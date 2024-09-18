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

namespace _2024__09__WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void MyButton_Click(object sender,RoutedEventArgs e)
        {
            //MessageBox.Show("Hello World");

            int number;
            bool success = int.TryParse(MyTextBox.Text, out number) ;
            if (!success)
            {
                MessageBox.Show("請輸入整數", "輸入錯誤");
            }
            else if (number < 2)
            {
                MessageBox.Show($"輸入的數值為{number}, 小於2，請重新輸入", "輸入錯誤");

            }
            else //(number >= 2)
            {
                MessageBox.Show($"輸入的數值為{number}, 可以進一步執行", "輸入正確");
                /*for (int i = 2; i < number; i++) 
                if (IsPrime(i)){
                
                }*/
            }
        }
    }
}