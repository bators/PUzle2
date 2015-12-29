using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Puzzle.Model.Interface
{
 public   class AbstractBridge
 {
    
   
     public int Rows
     {
         get
         {
             


             return 3;
         }
         set
         {
             throw new NotImplementedException();
         }
     }

     public int Columns
     {
         get
         {
             return Rows;
         }

         set
         {
             throw new NotImplementedException();
         }
     }
    
        

   
 public string SaveCurrentPuzleToFile(string path2 = null)
     {
         BitmapImage Img = new BitmapImage(new Uri("C:/Users/NB HP/Source/Repos/NewRepo/Puzzle/Puzzle/Img/444.jpg"));
         Guid photoID = System.Guid.NewGuid();
         string photolocation = photoID.ToString() + ".jpg";  //file name
         FileStream filestream = new FileStream(photolocation, FileMode.Create);
         JpegBitmapEncoder encoder = new JpegBitmapEncoder();
         encoder.Frames.Add(BitmapFrame.Create(Img));
         encoder.Save(filestream);
         return path2;
        }
        

    }
}
