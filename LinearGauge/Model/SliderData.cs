using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearGauge
{
    class SliderData : INotifyPropertyChanged
    {
        
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public SliderData(int minValue, int maxValue)
        {
            min = minValue;
            max = maxValue;
        }

        private int _value;

        public int Value
        {
            get { return _value; }
            set
            {
                _value = value;
                NotifyPropertyChanged("Value");
            }
        }

        private int min;

        public int Min
        {
            get { return min; }
            set { min = value; }
        }

        private int max;

        public int Max
        {
            get { return max; }
            set { max = value; }
        }

    }
}
