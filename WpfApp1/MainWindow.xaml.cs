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
using QRCoder;
using QRCoder.Xaml;

namespace WpfApp1
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void btngergel_Click(object sender, RoutedEventArgs e)
        {
            string zadanyText = textboxinput.Text;

            QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();

            QRCodeData dataQRkodu = qRCodeGenerator.CreateQrCode(zadanyText, QRCodeGenerator.ECCLevel.M);

            XamlQRCode Kod = new XamlQRCode(dataQRkodu);

            DrawingImage vkladanyObrazek = Kod.GetGraphic(30);
            obrazek.Source = vkladanyObrazek;
        }
    }
}
