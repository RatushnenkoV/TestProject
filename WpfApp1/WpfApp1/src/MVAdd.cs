using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace WpfApp1
{
    class MVAdd : INotifyPropertyChanged
    {
        Calc calc;

        public MVAdd(Calc calc)
        {
            this.calc = calc;
        }

        public double A
        {
            get => calc.a;
            set
            {
                calc.a = value;
                PropertyChangedInvoke("c");
            }
        }

        public double B
        {
            get => calc.b;
            set
            {
                calc.b = value;
                PropertyChangedInvoke("c");
            }
        }

        public double C => calc.Add();


        public event PropertyChangedEventHandler PropertyChanged;

        public void PropertyChangedInvoke(String propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}