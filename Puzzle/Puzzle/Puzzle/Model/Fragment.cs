using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
namespace Puzzle.Model
{
    public class Fragment : INotifyPropertyChanged
    {


        public int[] index0 = new int[9];

        public string Name { get; set; }
        public int I { get; set; }
        public int J { get; set; }
        private Bitmap _Pic;
        public Bitmap Pic
        {
            get 
            { 
                return _Pic;
            }
            set
            {
                if (_Pic != value)
                {
                    _Pic = value;
                    RaisePropertyChanged("Pic");

                }
            }

        }
        public event PropertyChangedEventHandler PropertyChanged;


        private void RaisePropertyChanged(string propertyFragment)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyFragment));
            }
        }
        
        
    }
}
