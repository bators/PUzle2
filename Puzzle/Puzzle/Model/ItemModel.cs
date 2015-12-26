using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media.Imaging;

namespace Puzzle.Model
{
   public  class ItemModel
   {
    //   protected BitmapImage _Image;
    //public virtual BitmapImage Image
    //{
    //    get
    //    {
    //        return _Image;
    //    }
    //    set
    //    {
    //        _Image = value;
    //    }
    //}

    //protected BitmapImage Bitmap2BitmapImage(Bitmap bitmap)
    //{
    //    BitmapSource i = Imaging.CreateBitmapSourceFromHBitmap(
    //                   bitmap.GetHbitmap(),
    //                   IntPtr.Zero,
    //                   Int32Rect.Empty,
    //                   BitmapSizeOptions.FromEmptyOptions());


    //    JpegBitmapEncoder encoder = new JpegBitmapEncoder();
    //    MemoryStream memoryStream = new MemoryStream();
    //    BitmapImage bImg = new BitmapImage();

    //    encoder.Frames.Add(BitmapFrame.Create(i));
    //    encoder.Save(memoryStream);

    //    bImg.BeginInit();
    //    bImg.StreamSource = new MemoryStream(memoryStream.ToArray());
    //    bImg.EndInit();

    //    memoryStream.Close();

    //    return bImg;
    //}
    }
}
