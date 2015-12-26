using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Collections;
//using System.Collections.Generic;
//using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GalaSoft.MvvmLight.Messaging;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.IO;
using Puzzle.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Puzzle.ViewModel
{
    public class DragAndDrop:ViewModelBase
    {

        private Fragment _perentfragment;
        public DragAndDrop(Fragment perentfragment)
        {
            if (perentfragment == null) throw new ArgumentNullException("perentfragment");

            _perentfragment = perentfragment;
        }
        private ObservableCollection<Fragment> _Fragment;
        
        public ObservableCollection<Fragment> Fragments
        {
            get
            {
                if (_Fragment == null)
                {
                    FragmentCreator fc= new FragmentCreator();
                    fc.CreatFragment();
                    _Fragment = new ObservableCollection<Fragment>(fc.Fragments);
                }
                return _Fragment;
            }
            set
            {
               
                    _Fragment = value;
                    
                    RaisePropertyChanged("Fragments");
               
            }
        
        }
        //private ObservableCollection<DragAndDrop> _drag;
        //public ObservableCollection<DragAndDrop> drag
        //{
        //    get
        //    {
        //        return _drag;
        //    }
        //    set
        //    {
        //        _drag = value;
        //    }
        //}
        //public void RemoveToHeap()
        //{
        //    if (_Fragment == null)
        //    {
        //        MessageBox.Show("_parentCollection is null");
        //    };

        //    if (!_drag.Contains(this))
        //        _drag.Add(this);

           
        //}

        public DragAndDrop()
        {
           

            FragmentCreator fc = new FragmentCreator();
            fc.Clone();
            fc.CreatFragment();

            _Fragment = new ObservableCollection<Model.Fragment>(fc.Fragments);
        }
        
                
      
        private RelayCommand<MouseButtonEventArgs> _listBoxMouseDown;
        public RelayCommand<MouseButtonEventArgs> ListBoxMouseDown
        {
            get
            {
                if (_listBoxMouseDown == null)
                    _listBoxMouseDown = new RelayCommand<MouseButtonEventArgs>(executeListBoxMouseDown);

                return _listBoxMouseDown;
            }
        }

        private void executeListBoxMouseDown(MouseButtonEventArgs e)
        {
            //MessageBox.Show(e.Source.GetType().ToString());

            ListBox list = e.Source as ListBox;

            if (list == null)
                return;

            if (list.SelectedItem == null)
                return;

            Fragment vm = list.SelectedItem as Fragment;

            if (vm == null)
                return;

            DragDrop.DoDragDrop(list, vm, DragDropEffects.Move);
        }
       

   
        

            

       // void   ForDrog()
       //{
       //    for (int i = 1; i <= 9; i++)
       //    {
       //        this.Canvas[i].name=
       //    }
       //}



        //    #region drag
        //    private void DragImage(object sender, MouseButtonEventArgs e)
        //    {
        //        Image image = e.Source as Image;
        //        DataObject data = new DataObject(typeof(ImageSource), image.Source);
        //        DragDrop.DoDragDrop(image, data, DragDropEffects.All);

        //    }

        //    void imageControl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //    {
        //        Image image = e.Source as Image;
        //        DataObject data = new DataObject(typeof(Image), image);
        //        DragDrop.DoDragDrop(image, data, DragDropEffects.All);

        //    }

        //  #endregion





        //    #region Drop
        //    private void DropImage(object sender, DragEventArgs e)
        //    {
        //        Image imageControl = new Image();
        //        if ((e.Data.GetData(typeof(ImageSource)) != null))
        //        {
        //            ImageSource image = e.Data.GetData(typeof(ImageSource)) as ImageSource;
        //            imageControl = new Image() { Width = image.Width / 3, Height = image.Height / 3, Source = image };
        //        }
        //        else
        //        {
        //            if ((e.Data.GetData(typeof(Image)) != null))
        //            {
        //                Image image = e.Data.GetData(typeof(Image)) as Image;
        //                imageControl = image;
        //                if (this.Canvas.Children.Contains(image))
        //                {
        //                    this.Canvas.Children.Remove(image);
        //                }
        //            }
        //        }


        //        imageControl.MouseLeftButtonDown += imageControl_MouseLeftButtonDown;
        //        this.Canvas.Children.Add(imageControl);

        //    }
        //    #endregion
        //}

    }
}
        


    



