using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
namespace Puzzle.Model
{
    public class Fragment :ViewModelBase
    {


        private int _ind;
        public int ind
        {
            get
            {

                return _ind;
            }
            set
            {
                if (_ind != value)
                {
                    _ind = value;
                    RaisePropertyChanged("ind");

                }
            }

        }

 
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
       
        
        
    }
}
