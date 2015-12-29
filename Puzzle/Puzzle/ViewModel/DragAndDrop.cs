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

            var res=DragDrop.DoDragDrop(list, vm, DragDropEffects.All);
            if (res == DragDropEffects.Move)
                (list.SelectedItem as IList).Remove(vm);
        }
    }
}
        


    



