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
    /// <summary>
    /// Interaction logic for UserControlLinearGauge.xaml
    /// </summary>
    public partial class UserControlLinearGauge : UserControl
    {


        public UserControlLinearGauge()
        {
            InitializeComponent();
        }


        public int Value
        {
            get { return (int)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(int), typeof(UserControlLinearGauge), new PropertyMetadata(0, new PropertyChangedCallback(OnValueChanged)));

        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            UserControlLinearGauge uc = (UserControlLinearGauge)d;
            uc.Value = (int)e.NewValue;
        }


        public int MinValue
        {
            get { return (int)GetValue(MinValueProperty); }
            set { SetValue(MinValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MinValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MinValueProperty =
            DependencyProperty.Register("MinValue", typeof(int), typeof(UserControlLinearGauge), new PropertyMetadata(int.MinValue, new PropertyChangedCallback(OnMinValueChanged)));

        private static void OnMinValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            UserControlLinearGauge uc = (UserControlLinearGauge)d;
            uc.MinValue = (int)e.NewValue;
        }


        public int MaxValue
        {
            get { return (int)GetValue(MaxValueProperty); }
            set { SetValue(MaxValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MaxValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MaxValueProperty =
            DependencyProperty.Register("MaxValue", typeof(int), typeof(UserControlLinearGauge), new PropertyMetadata(int.MaxValue, new PropertyChangedCallback(OnMaxValueChanged)));

        private static void OnMaxValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            UserControlLinearGauge uc = (UserControlLinearGauge)d;
            uc.MaxValue = (int)e.NewValue;
        }


        private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (ActualWidth < 48 && ActualHeight < 48)
            {
                status.Visibility = Visibility.Collapsed;
            }
            else
            {
                status.Visibility = Visibility.Visible;
            }
        }
    }
}
