using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle.ViewModel
{
    class Item:ViewModelBase
    {
        private Bitmap _img;
        public Bitmap img
        {
            get
            {
                return _img;
            }
            set
            {
                _img = value;
                RaisePropertyChanged("img");
            }

        }    
        private int _index;
        public int index 
        { 
            get
            {
            return _index;
            }
            set
            {
                _index = value;
                RaisePropertyChanged("index");
            }
            
        }
      

         
    }
}
