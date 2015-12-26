using GalaSoft.MvvmLight.Command;
using Puzzle.ViewModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GalaSoft.MvvmLight.Messaging;

using System.IO;
using GalaSoft.MvvmLight;

namespace Puzzle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window  
    {
      
      
        //private void DragImage(object sender, MouseButtonEventArgs e)
        //{
        //    Image image = e.Source as Image;
        //    DataObject data = new DataObject(typeof(ImageSource), image.Source);
        //    DragDrop.DoDragDrop(image, data, DragDropEffects.All);
        
        //}


        //private void DropImage(object sender, DragEventArgs e)
        //{
        //    Image imageControl = new Image();
        //    if ((e.Data.GetData(typeof(ImageSource)) != null))
        //    {
        //        ImageSource image = e.Data.GetData(typeof(ImageSource)) as ImageSource;
        //        imageControl = new Image() { Width = 100, Height = 100, Source = image };
        //    }
        //    else
        //    {
        //        if ((e.Data.GetData(typeof(Image)) != null))
        //        {
        //            Image image = e.Data.GetData(typeof(Image)) as Image;
        //            imageControl = image;
        //            if (((Canvas)sender).Children.Contains(image))
        //            {
        //                ((Canvas)sender).Children.Remove(image);
        //            }
        //        }
        //    }

           
            
        //    imageControl.MouseLeftButtonDown += imageControl_MouseLeftButtonDown;
        //    ((Canvas)sender).Children.Add(imageControl);

        //}

        //void imageControl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    Image image = e.Source as Image;
        //    DataObject data = new DataObject(typeof(Image), image);
        //    DragDrop.DoDragDrop(image, data, DragDropEffects.All);
          
        //}

    //   private void DragImage(object sender, MouseButtonEventArgs e)
    //{
    //    Image image = e.Source as Image;
    //    DataObject data = new DataObject(typeof(ImageSource), image.Source);
    //    DragDrop.DoDragDrop(image, data, DragDropEffects.Copy);
    //}

    //   private void PhotoDrop(object sender, DragEventArgs e)
    //   {
    //       ((Image)sender).Source = (ImageSource)e.Data.GetData("Object");

    //   }
//       private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
//       {
//           Bitmap bitmap = ImageToBitmap(e.Source as System.Windows.Controls.Image);

//           DataObject data = new DataObject(DataFormats.Bitmap, bitmap);

//           DragDrop.DoDragDrop((DependencyObject)e.Source, data, DragDropEffects.Copy);
//       }
//       private void Window_Drop(object sender, DragEventArgs e)
//       {
//           BitmapSource bmSource = (BitmapSource)e.Data.GetData(DataFormats.Bitmap);
//           imgDropHere.Source = bmSource;
//       }
       
//        private Bitmap ImageToBitmap(System.Windows.Controls.Image image)
//{
//    RenderTargetBitmap rtBmp = new RenderTargetBitmap((int)image.ActualWidth, (int)image.ActualHeight,
//        96.0, 96.0, PixelFormats.Pbgra32);
 
//    image.Measure(new System.Windows.Size((int)image.ActualWidth, (int)image.ActualHeight));
//    image.Arrange(new Rect(new System.Windows.Size((int)image.ActualWidth, (int)image.ActualHeight)));
 
//    rtBmp.Render(image);
 
//    PngBitmapEncoder encoder = new PngBitmapEncoder();
//    MemoryStream stream = new MemoryStream();
//    encoder.Frames.Add(BitmapFrame.Create(rtBmp));
 
//    // Save to memory stream and create Bitamp from stream
//    encoder.Save(stream);
 
//    return new System.Drawing.Bitmap(stream);
//}
    //private void Canvas1_Drop(object sender, DragEventArgs e)
    //    {
    //        ImageSource imageSource = e.Data.GetData(typeof(ImageSource)) as ImageSource;
    //        Image img = sender as Image;
    //        img.Source = imageSource;
    //        Canvas Canvas1 = sender as Canvas;
    //        Canvas1.Children.Add(img);

        //}

        //private Point _startPoint;
        //private static readonly string _dropIdentifier = "dropIdentifier";

        //private void ListBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{

        //    _startPoint = e.GetPosition(null);
        //}

        //private void listBox_PreviewMouseMove(object sender, MouseEventArgs e)
        //{

        //    Point mousePos = e.GetPosition(null);
        //    Vector diff = _startPoint - mousePos;

        //    if (e.LeftButton == MouseButtonState.Pressed &&
        //        (Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance ||
        //        Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance))
        //    {

        //        var listBox = sender as ListBox;
        //        var listBoxItem = listBox.SelectedItem;


        //        DataObject dragData = new DataObject(_dropIdentifier, listBoxItem);
        //        DragDrop.DoDragDrop(listBox, dragData, DragDropEffects.Move);
        //    }
        //}

        //private void canvasImage_Drop(object sender, DragEventArgs e)
        //{
        //    if (e.Data.GetDataPresent(_dropIdentifier))
        //    {
        //        var item = e.Data.GetData(_dropIdentifier) as ListBoxItem;

        //        DropOnCanvas(sender as Canvas, item);
        //    }
        //}

        //private void canvasImage_DragEnter(object sender, DragEventArgs e)
        //{
        //    if (!e.Data.GetDataPresent(_dropIdentifier) ||
        //      sender == e.Source)
        //    {
        //        e.Effects = DragDropEffects.None;
        //    }
        //}
        //public void DropOnCanvas(Canvas targetCanvas, ListBoxItem item)
        //{
        //    // do your stuff here ...

        //    var Img = new Image() { Source = item, Image.Height, Image.Width };
        //    Canvas.SetTop(Img, targetCanvas.Children.Count * Height);
        //    Canvas.SetLeft(Img, targetCanvas.Children.Count * Width);
        //    targetCanvas.Children.Add(Img);
        //}
        public MainWindow()
        {

                  InitializeComponent();

        }

        //ListView dragSource = null;
        //private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    if (e.LeftButton == MouseButtonState.Pressed)
        //    {
        //        ListView parent = (ListView)sender;
        //        dragSource = parent;
        //        DataObject data = new DataObject();
        //        data.SetData("Object", this);

        //        DragDrop.DoDragDrop(parent, data, DragDropEffects.Copy | DragDropEffects.Move);

        //    }
        //}
        //protected override void OnGiveFeedback(GiveFeedbackEventArgs e)
        //{
        //    base.OnGiveFeedback(e);
        //    // These Effects values are set in the drop target's
        //    // DragOver event handler.
        //    if (e.Effects.HasFlag(DragDropEffects.Copy))
        //    {
        //        Mouse.SetCursor(Cursors.Cross);
        //    }
        //    else if (e.Effects.HasFlag(DragDropEffects.Move))
        //    {
        //        Mouse.SetCursor(Cursors.Pen);
        //    }
        //    else
        //    {
        //        Mouse.SetCursor(Cursors.No);
        //    }
        //    e.Handled = true;
        //}
        //ListBox dragSource = null;
        //private void ListBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    ListBox parent = (ListBox)sender;
        //    dragSource = parent;
        //    object data = GetDataFromListBox(dragSource, e.GetPosition(parent));

        //    if (data != null)
        //    {
        //        DragDrop.DoDragDrop(parent, data, DragDropEffects.Move);
        //    }
        //}

        //private static object GetDataFromListBox(ListBox source, Point point)
        //{
        //    UIElement element = source.InputHitTest(point) as UIElement;
        //    if (element != null)
        //    {
        //        object data = DependencyProperty.UnsetValue;
        //        while (data == DependencyProperty.UnsetValue)
        //        {
        //            data = source.ItemContainerGenerator.ItemFromContainer(element);
        //            if (data == DependencyProperty.UnsetValue)
        //            {
        //                element = VisualTreeHelper.GetParent(element) as UIElement;
        //            }
        //            if (element == source)
        //            {
        //                return null;
        //            }
        //        }
        //        if (data != DependencyProperty.UnsetValue)
        //        {
        //            return data;
        //        }
        //    }
        //    return null;
        //}


        //private void Canvas_Drop(object sender, DragEventArgs e)
        //{
        //    Image parent = (Image)sender;
        //    object data = e.Data.GetData(typeof(ImageSource));
        //    ((IList)dragSource.Items).Remove(data);
        //    parent.Items.Add(data);
        //}


        //private void lbl1_MouseDown(object sender, MouseButtonEventArgs e)
        //{
        //    if (!this.AllowDragDrop)
        //    {
        //        return;
        //    }

        //        DragDrop.DoDragDrop(ListViewItemsCollection, this.SelectedItems, DragDropEffects.Copy | DragDropEffects.Move);


        //private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    List<string> stringItems = new List<string>();

        //    foreach (ListViewItem lbi in Fragments.Items)
        //        stringItems.Add((string)lbi.Content);

        //    string someValues = string.Join(",", stringItems);

        //    DataObject data = new DataObject(DataFormats.CommaSeparatedValue, someValues);

        //    DragDrop.DoDragDrop((DependencyObject)e.Source, data, DragDropEffects.Copy);
        //}

    }   
   
    
}
