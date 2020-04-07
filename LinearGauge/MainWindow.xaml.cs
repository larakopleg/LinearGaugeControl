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

namespace LinearGauge
{

    public partial class MainWindow : Window
    {
        private Thickness originalMargin;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (e.PreviousSize.Height != 0 && e.PreviousSize.Width != 0)
            {
                double originalHeight = e.PreviousSize.Height;
                double originalWidth = e.PreviousSize.Width;
                double newHeight = ActualHeight;
                double newWidth = ActualWidth;

                double percentH = newHeight / originalHeight;
                double percentW = newWidth / originalWidth;

                double controlHeight = LinearGauge.ActualHeight;
                double controlWidth = LinearGauge.ActualWidth;

                LinearGauge.Height = controlHeight * percentH;
                LinearGauge.Width = controlWidth * percentW;

                Thickness newMargin = new Thickness();
                newMargin.Left = originalMargin.Left * percentW;
                newMargin.Top = originalMargin.Top * percentH;
                newMargin.Bottom = originalMargin.Bottom * percentH;
                newMargin.Right = originalMargin.Right * percentW;
                LinearGauge.Margin = newMargin;
                originalMargin = newMargin;
            }
        }
    }


}
