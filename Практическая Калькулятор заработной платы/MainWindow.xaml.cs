using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Практическая_Калькулятор_заработной_платы
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Window GlobalWindow;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 wnd1 = new Window1();
            wnd1.Show();

            //wnd1.Zarp.Text = this.Oklad.Text;
            int c = Koff.SelectedIndex;
            double Zarp, ZarpKoff, NDFL, ZarpN;
            Zarp = Convert.ToDouble(OtDni.Text) * Convert.ToDouble(Oklad.Text) / Convert.ToDouble(RabDni.Text) + Convert.ToDouble(Prem.Text);
            if (c == 0)
            {
                ZarpKoff = Zarp * 1.2;
                NDFL = ZarpKoff * 0.13;
                ZarpN = Zarp - NDFL;
                wnd1.ZarpNa.Text = Convert.ToString(ZarpN);
                wnd1.NDFL.Text = Convert.ToString(NDFL);
                wnd1.Zarp.Text = Convert.ToString(Zarp);
            }
            if (c == 1)
            {
                ZarpKoff = Zarp * 1.3;
                NDFL = ZarpKoff * 0.13;
                ZarpN = Zarp - NDFL;
                wnd1.ZarpNa.Text = Convert.ToString(ZarpN);
                wnd1.NDFL.Text = Convert.ToString(NDFL);
                wnd1.Zarp.Text = Convert.ToString(Zarp);
            }
            if (c == 2)
            {
                ZarpKoff = Zarp * 1.4;
                NDFL = ZarpKoff * 0.13;
                ZarpN = Zarp - NDFL;
                wnd1.ZarpNa.Text = Convert.ToString(ZarpN);
                wnd1.NDFL.Text = Convert.ToString(NDFL);
                wnd1.Zarp.Text = Convert.ToString(Zarp);
            }
            if (c == 3)
            {
                ZarpKoff = Zarp * 1.5;
                NDFL = ZarpKoff * 0.13;
                ZarpN = Zarp - NDFL;
                wnd1.ZarpNa.Text = Convert.ToString(ZarpN);
                wnd1.NDFL.Text = Convert.ToString(NDFL);
                wnd1.Zarp.Text = Convert.ToString(Zarp);
            }
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
