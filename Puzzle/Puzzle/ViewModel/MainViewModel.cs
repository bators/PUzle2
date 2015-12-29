using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Puzzle.Model;
using Puzzle.Model.Interface;
using System.ComponentModel;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using Microsoft.Win32;
using System.IO;
using System.Windows;
using GalaSoft.MvvmLight.Command;
namespace Puzzle.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        AbstractBridge _dataBridge;
        public MainViewModel(AbstractBridge bridge)
        {

            if (bridge == null) throw new ArgumentNullException("bridge");


            _dataBridge = bridge;
        }


        private RelayCommand _butSavePuzzle;
        public RelayCommand ButSavePuzzle
        {
            get
            {
                if (_butSavePuzzle == null)
                {
                    _butSavePuzzle = new RelayCommand(butSavePuzzleExecute);
                }

                return _butSavePuzzle;
            }
        }
        private void butSavePuzzleExecute()
        {

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "jpg Files (*.jpg)|*.jpg";

            if (dialog.ShowDialog() == true)
            {
                string pathImg = dialog.FileName;

                if (!Directory.Exists(Path.GetDirectoryName(pathImg)))
                {
                    MessageBox.Show("pathImg directory doesn't exist");
                    return;
                }

                if (File.Exists(pathImg))
                    File.Delete(pathImg);

                _dataBridge.SaveCurrentPuzleToFile(pathImg);
            }

          


            }





        }

    }

