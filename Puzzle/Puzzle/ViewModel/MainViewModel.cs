using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Puzzle.Model;

using System.ComponentModel;
using System.Collections.ObjectModel;
namespace Puzzle.ViewModel
{
    public class MainViewModel:INotifyPropertyChanged
    {
        
        private Model.Fragment img =new Fragment();
        private ObservableCollection<Fragment> _Fragment;
        
        public ObservableCollection<Fragment> Fragments
        {
            get { return _Fragment; }
            set
            {
               
                    _Fragment = value;
                    
                    RaisePropertyChanged("Fragments");
               
            }
        
        }

        public MainViewModel()
        {
            
            FragmentCreator fc = new FragmentCreator();
            fc.Clone();
            fc.CreatFragment();

            _Fragment = new ObservableCollection<Model.Fragment>(fc.Fragments);
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
