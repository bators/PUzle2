using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;




using Puzzle.Model;
using System.Drawing;
using System.Windows.Input;
using System.Windows.Controls;
using System.Collections.ObjectModel;
namespace Puzzle.ViewModel
{
   public  class Drop:ViewModelBase
    {
       
       private Fragment _frag;
       public Bitmap Image
       {
           get
           {
               if (_frag!= null)
                   return _frag.Pic;

               return null;
           }
           set 
           {
               _frag.Pic = value;
           }

       }

       private RelayCommand<DragEventArgs> _ImageDrop;
       public RelayCommand<DragEventArgs> ImageDrop
        {
            get
            {
                if (_ImageDrop == null)

                    _ImageDrop = new RelayCommand<DragEventArgs>(hatDropExecute);

                return _ImageDrop;
            }
        }


        private void hatDropExecute( DragEventArgs e)
        {
            Fragment vm = e.Data.GetData(typeof(Fragment)) as Fragment;
            if (vm != null) return;
            _frag= vm;
            RaisePropertyChanged("Image");
            
        }

        //private RelayCommand<MouseButtonEventArgs> _CanvasMouseDown;
        //public RelayCommand<MouseButtonEventArgs> CanvasMouseDown
        //{
        //    get
        //    {
        //        if (_CanvasMouseDown == null)
        //            _CanvasMouseDown = new RelayCommand<MouseButtonEventArgs>(executeListBoxMouseDown);

        //        return _CanvasMouseDown;
        //    }
        //}

        //private void executeListBoxMouseDown(MouseButtonEventArgs e)
        //{
        //    MessageBox.Show(e.Source.GetType().ToString());

        //    Canvas list = e.Source as Canvas;

        //    if (list == null)
        //        return;

        //    if (list.Children == null)
        //        return;
        //    Fragment vm = list. as Fragment;

        //    if (vm == null)
        //        return;

        //    DragDrop.DoDragDrop(list, vm, DragDropEffects.All);
        //}
    }
}
