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
       ObservableCollection<Fragment> itemPlacement = new ObservableCollection<Fragment>();
       public Drop(Fragment frag)
        {
            if (frag == null) throw new ArgumentNullException("Image");
            _frag = frag;
            RaisePropertyChanged("Image");
            
        }
       #region IsItRightPosition
       public bool IsItRightPosition()
       {
           if (ind0 == 1 && ind1 == 2 && ind2 == 3 && ind3 == 4 && ind4 == 5 && ind5 == 6 && ind6 == 7 && ind7 == 8 && ind8==9)

            return true; 
           else return false;
           
               
               
       }


       #endregion
       #region properties


       public int ind0;
       public int ind1;
       public int ind2;
       public int ind3;
       public int ind4;
       public int ind5;
       public int ind6;
       public int ind7;
       public int ind8;
       private Fragment _frag1;
       private Fragment _frag;
       private Fragment _frag2;
       private Fragment _frag3;
       private Fragment _frag4;
       private Fragment _frag5;
       private Fragment _frag6;
       private Fragment _frag7;
       private Fragment _frag8;

       public Bitmap Image8
       {
           get
           {
               if (_frag8 != null)
                   return _frag8.Pic;

               return null;
           }
           set
           {
               _frag8.Pic = value;
           }

       }
       public Bitmap Image7
       {
           get
           {
               if (_frag7 != null)
                   return _frag7.Pic;

               return null;
           }
           set
           {
               _frag7.Pic = value;
           }

       }
       public Bitmap Image6
       {
           get
           {
               if (_frag6 != null)
                   return _frag6.Pic;

               return null;
           }
           set
           {
               _frag6.Pic = value;
           }

       }
       public Bitmap Image5
       {
           get
           {
               if (_frag5 != null)
                   return _frag5.Pic;

               return null;
           }
           set
           {
               _frag5.Pic = value;
           }

       }
       public Bitmap Image4
       {
           get
           {
               if (_frag4 != null)
                   return _frag4.Pic;

               return null;
           }
           set
           {
               _frag4.Pic = value;
           }

       }
       public Bitmap Image3
       {
           get
           {
               if (_frag3 != null)
                   return _frag3.Pic;

               return null;
           }
           set
           {
               _frag3.Pic = value;
           }

       }
       public Bitmap Image2
       {
           get
           {
               if (_frag2 != null)
                   return _frag2.Pic;

               return null;
           }
           set
           {
               _frag2.Pic = value;
           }

       }
       public Bitmap Image1
       {
           get
           {
               if (_frag1 != null)
                   return _frag1.Pic;

               return null;
           }
           set
           {
               _frag1.Pic = value;
           }

       }
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
       #endregion
       #region Drop

       private RelayCommand<DragEventArgs> _ImageDrop8;
       public RelayCommand<DragEventArgs> ImageDrop8
       {
           get
           {
               if (_ImageDrop8 == null)

                   _ImageDrop8 = new RelayCommand<DragEventArgs>(hatDropExecute8);

               return _ImageDrop8;
           }
       }


       private void hatDropExecute8(DragEventArgs e)
       {
           Fragment vm = e.Data.GetData(typeof(Fragment)) as Fragment;
           if (vm == null) return;
           _frag8 = vm;
           ind8 = _frag8.ind;
           RaisePropertyChanged("Image8");
           if (IsItRightPosition() == true) MessageBox.Show("You win!");
              


       }

       private RelayCommand<DragEventArgs> _ImageDrop7;
       public RelayCommand<DragEventArgs> ImageDrop7
       {
           get
           {
               if (_ImageDrop7 == null)

                   _ImageDrop7 = new RelayCommand<DragEventArgs>(hatDropExecute7);

               return _ImageDrop7;
           }
       }


       private void hatDropExecute7(DragEventArgs e)
       {
           Fragment vm = e.Data.GetData(typeof(Fragment)) as Fragment;
           if (vm == null) return;
           _frag7 = vm;
           ind7 = _frag7.ind;
           RaisePropertyChanged("Image7");
           if (IsItRightPosition() == true) MessageBox.Show("You win!");


       }

       private RelayCommand<DragEventArgs> _ImageDrop6;
       public RelayCommand<DragEventArgs> ImageDrop6
       {
           get
           {
               if (_ImageDrop6 == null)

                   _ImageDrop6 = new RelayCommand<DragEventArgs>(hatDropExecute6);

               return _ImageDrop6;
           }
       }


       private void hatDropExecute6(DragEventArgs e)
       {
           Fragment vm = e.Data.GetData(typeof(Fragment)) as Fragment;
           if (vm == null) return;
           _frag6 = vm;
           ind6 = _frag6.ind;
           RaisePropertyChanged("Image6");
           if (IsItRightPosition() == true) MessageBox.Show("You win!");

       }

       private RelayCommand<DragEventArgs> _ImageDrop5;
       public RelayCommand<DragEventArgs> ImageDrop5
       {
           get
           {
               if (_ImageDrop5 == null)

                   _ImageDrop5 = new RelayCommand<DragEventArgs>(hatDropExecute5);

               return _ImageDrop5;
           }
       }


       private void hatDropExecute5(DragEventArgs e)
       {
           Fragment vm = e.Data.GetData(typeof(Fragment)) as Fragment;
           if (vm == null) return;
           _frag5 = vm;
           ind5 = _frag5.ind;
           RaisePropertyChanged("Image5");
           if (IsItRightPosition() == true) MessageBox.Show("You win!");

       }

       private RelayCommand<DragEventArgs> _ImageDrop4;
       public RelayCommand<DragEventArgs> ImageDrop4
       {
           get
           {
               if (_ImageDrop4 == null)

                   _ImageDrop4 = new RelayCommand<DragEventArgs>(hatDropExecute4);

               return _ImageDrop4;
           }
       }


       private void hatDropExecute4(DragEventArgs e)
       {
           Fragment vm = e.Data.GetData(typeof(Fragment)) as Fragment;
           if (vm == null) return;
           _frag4 = vm;
           ind4 = _frag4.ind;
           RaisePropertyChanged("Image4");
           if (IsItRightPosition() == true) MessageBox.Show("You win!");
       }

       private RelayCommand<DragEventArgs> _ImageDrop3;
       public RelayCommand<DragEventArgs> ImageDrop3
       {
           get
           {
               if (_ImageDrop3 == null)

                   _ImageDrop3 = new RelayCommand<DragEventArgs>(hatDropExecute3);

               return _ImageDrop3;
           }
       }


       private void hatDropExecute3(DragEventArgs e)
       {
           Fragment vm = e.Data.GetData(typeof(Fragment)) as Fragment;
           if (vm == null) return;
           _frag3 = vm;
           ind3 = _frag3.ind;
           RaisePropertyChanged("Image3");
           if (IsItRightPosition() == true) MessageBox.Show("You win!");

       }

       private RelayCommand<DragEventArgs> _ImageDrop2;
       public RelayCommand<DragEventArgs> ImageDrop2
       {
           get
           {
               if (_ImageDrop2 == null)

                   _ImageDrop2 = new RelayCommand<DragEventArgs>(hatDropExecute2);

               return _ImageDrop2;
           }
       }


       private void hatDropExecute2(DragEventArgs e)
       {
           Fragment vm = e.Data.GetData(typeof(Fragment)) as Fragment;
           if (vm == null) return;
           _frag2 = vm;
           ind2 = _frag2.ind;
           RaisePropertyChanged("Image2");
           if (IsItRightPosition() == true) MessageBox.Show("You win!");

       }

       private RelayCommand<DragEventArgs> _ImageDrop1;
       public RelayCommand<DragEventArgs> ImageDrop1
       {
           get
           {
               if (_ImageDrop1 == null)

                   _ImageDrop1 = new RelayCommand<DragEventArgs>(hatDropExecute1);

               return _ImageDrop1;
           }
       }


       private void hatDropExecute1(DragEventArgs e)
       {
           Fragment vm = e.Data.GetData(typeof(Fragment)) as Fragment;
           if (vm == null) return;
           _frag1 = vm;
           ind1 = _frag1.ind;
           RaisePropertyChanged("Image1");
           if (IsItRightPosition() == true) MessageBox.Show("You win!");

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
            if (vm == null) return;
            _frag= vm;
            ind0 = _frag.ind;
            RaisePropertyChanged("Image");
            if (IsItRightPosition() == true) MessageBox.Show("You win!");
           
        }
#endregion
       #region CanvasMouseDown

        private RelayCommand<MouseButtonEventArgs> _CanvasMouseDown8;
        public RelayCommand<MouseButtonEventArgs> CanvasMouseDown8
        {
            get
            {
                if (_CanvasMouseDown8 == null)
                    _CanvasMouseDown8 = new RelayCommand<MouseButtonEventArgs>(executeListBoxMouseDown8);

                return _CanvasMouseDown8;
            }
        }

        private void executeListBoxMouseDown8(MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                _frag8 = null;
                ind8 = 0;
                RaisePropertyChanged("Image8");
            }
        }
        private RelayCommand<MouseButtonEventArgs> _CanvasMouseDown7;
        public RelayCommand<MouseButtonEventArgs> CanvasMouseDown7
        {
            get
            {
                if (_CanvasMouseDown7 == null)
                    _CanvasMouseDown7 = new RelayCommand<MouseButtonEventArgs>(executeListBoxMouseDown7);

                return _CanvasMouseDown7;
            }
        }

        private void executeListBoxMouseDown7(MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                _frag7 = null;
                ind7 = 0;
                RaisePropertyChanged("Image7");
            }
        }
        private RelayCommand<MouseButtonEventArgs> _CanvasMouseDown6;
        public RelayCommand<MouseButtonEventArgs> CanvasMouseDown6
        {
            get
            {
                if (_CanvasMouseDown6 == null)
                    _CanvasMouseDown6 = new RelayCommand<MouseButtonEventArgs>(executeListBoxMouseDown6);

                return _CanvasMouseDown6;
            }
        }

        private void executeListBoxMouseDown6(MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                _frag6 = null;
                ind6 = 0;
                RaisePropertyChanged("Image6");
            }
        }
        private RelayCommand<MouseButtonEventArgs> _CanvasMouseDown5;
        public RelayCommand<MouseButtonEventArgs> CanvasMouseDown5
        {
            get
            {
                if (_CanvasMouseDown5 == null)
                    _CanvasMouseDown5 = new RelayCommand<MouseButtonEventArgs>(executeListBoxMouseDown5);

                return _CanvasMouseDown5;
            }
        }

        private void executeListBoxMouseDown5(MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                _frag5 = null;
                ind5 = 0;
                RaisePropertyChanged("Image5");
            }
        }

        private RelayCommand<MouseButtonEventArgs> _CanvasMouseDown4;
        public RelayCommand<MouseButtonEventArgs> CanvasMouseDown4
        {
            get
            {
                if (_CanvasMouseDown4 == null)
                    _CanvasMouseDown4 = new RelayCommand<MouseButtonEventArgs>(executeListBoxMouseDown4);

                return _CanvasMouseDown4;
            }
        }

        private void executeListBoxMouseDown4(MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                _frag4 = null;
                ind4 = 0;
                RaisePropertyChanged("Image4");
            }
        }

        private RelayCommand<MouseButtonEventArgs> _CanvasMouseDown3;
        public RelayCommand<MouseButtonEventArgs> CanvasMouseDown3
        {
            get
            {
                if (_CanvasMouseDown3 == null)
                    _CanvasMouseDown3 = new RelayCommand<MouseButtonEventArgs>(executeListBoxMouseDown3);

                return _CanvasMouseDown3;
            }
        }

        private void executeListBoxMouseDown3(MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                _frag3 = null;
                ind3 = 0;
                RaisePropertyChanged("Image3");
            }
        }

        private RelayCommand<MouseButtonEventArgs> _CanvasMouseDown2;
        public RelayCommand<MouseButtonEventArgs> CanvasMouseDown2
        {
            get
            {
                if (_CanvasMouseDown2 == null)
                    _CanvasMouseDown2 = new RelayCommand<MouseButtonEventArgs>(executeListBoxMouseDown2);

                return _CanvasMouseDown2;
            }
        }

        private void executeListBoxMouseDown2(MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                _frag2 = null;
                ind2 = 0;
                RaisePropertyChanged("Image2");
            }
        }

        private RelayCommand<MouseButtonEventArgs> _CanvasMouseDown1;
        public RelayCommand<MouseButtonEventArgs> CanvasMouseDown1
        {
            get
            {
                if (_CanvasMouseDown1 == null)
                    _CanvasMouseDown1 = new RelayCommand<MouseButtonEventArgs>(executeListBoxMouseDown1);

                return _CanvasMouseDown1;
            }
        }

        private void executeListBoxMouseDown1(MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                _frag1 = null;
                ind1 = 0;
                RaisePropertyChanged("Image1");
            }
        }
        private RelayCommand<MouseButtonEventArgs> _CanvasMouseDown;
        public RelayCommand<MouseButtonEventArgs> CanvasMouseDown
        {
            get
            {
                if (_CanvasMouseDown == null)
                    _CanvasMouseDown = new RelayCommand<MouseButtonEventArgs>(executeListBoxMouseDown);

                return _CanvasMouseDown;
            }
        }

        private void executeListBoxMouseDown(MouseButtonEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                _frag = null;
                ind0 = 0;
                RaisePropertyChanged("Image");
            }
        }
       #endregion
   }
}
