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

namespace PR4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            lstResult.Items.Clear();
            double x = double.Parse(txtX.Text);
            double p = double.Parse(txtY.Text);
            double res;
            lstResult.Items.Add("ПР4. Выполнила Федяева Ольга");
            lstResult.Items.Add($"x={x}");
            lstResult.Items.Add($"p={p}");
            int n = 0;
            if (rbtCos.IsChecked == true) n = 1;
            else if (rbtExp.IsChecked == true) n = 2;
            switch (n)
            {
                case 0:
                    if (x > Math.Abs(p)) res = 2 * Math.Pow(Math.Sin(x), 3) + 3 * (p * p);
                    else if (x < Math.Abs(p) && x > 3) res = Math.Abs(Math.Sin(x) - p);
                    else if (x == Math.Abs(p)) res = Math.Pow((Math.Sin(x) - p), 2);
                    else res = 0;
                    lstResult.Items.Add($"Результат u={Math.Round(res, 3)}");
                    break;
                case 1:
                    if (x > Math.Abs(p)) res = 2 * Math.Pow(Math.Cos(x), 3) + 3 * (p * p);
                    else if (x < Math.Abs(p) && x > 3) res = Math.Abs(Math.Cos(x) - p);
                    else if (x == Math.Abs(p)) res = Math.Pow((Math.Cos(x) - p), 2);
                    else res = 0;
                    lstResult.Items.Add($"Результат res={Math.Round(res, 3)}");
                    break;
                case 2:
                    if (x > Math.Abs(p)) res = 2 * Math.Pow(Math.Exp(x), 3) + 3 * (p * p);
                    else if (x < Math.Abs(p) && x > 3) res = Math.Abs(Math.Exp(x) - p);
                    else if (x == Math.Abs(p)) res = Math.Pow((Math.Exp(x) - p), 2);
                    else res = 0;
                    lstResult.Items.Add($"Результат res={Math.Round(res, 3)}");
                    break;
                default:
                    lstResult.Items.Add("Решение не найдено");
                    break;
            }




        }
        
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtX.Clear();
            txtY.Clear();
            lstResult.Items.Clear();
        }

    }
}