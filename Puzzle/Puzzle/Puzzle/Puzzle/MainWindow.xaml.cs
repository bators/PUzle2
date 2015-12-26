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

namespace Puzzle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Point _startPoint;
        private static readonly string _dropIdentifier = "dropIdentifier";

        private void ListBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            _startPoint = e.GetPosition(null);
        }

        private void listBox_PreviewMouseMove(object sender, MouseEventArgs e)
        {

            Point mousePos = e.GetPosition(null);
            Vector diff = _startPoint - mousePos;

            if (e.LeftButton == MouseButtonState.Pressed &&
                (Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance ||
                Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance))
            {

                var listBox = sender as ListBox;
                var listBoxItem = listBox.SelectedItem;


                DataObject dragData = new DataObject(_dropIdentifier, listBoxItem);
                DragDrop.DoDragDrop(listBox, dragData, DragDropEffects.Move);
            }
        }

        private void canvasImage_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(_dropIdentifier))
            {
                var item = e.Data.GetData(_dropIdentifier) as ListBoxItem;

                DropOnCanvas(sender as Canvas, item);
            }
        }

        private void canvasImage_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(_dropIdentifier) ||
              sender == e.Source)
            {
                e.Effects = DragDropEffects.None;
            }
        }
        public void DropOnCanvas(Canvas targetCanvas, ListBoxItem item)
        {
            // do your stuff here ...

            var Img = new Image() { Source = item, Image.Height, Image.Width };
            Canvas.SetTop(Img, targetCanvas.Children.Count * Height);
            Canvas.SetLeft(Img, targetCanvas.Children.Count * Width);
            targetCanvas.Children.Add(Img);
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

        public MainWindow()
        {

            InitializeComponent();

        }
    }
    
    public partial class Mainvindow : Window
    {
       
       

            //this.ListViewUI.Height = c.ListViewUI.Height;
            //this.ListViewUI.Width = c.ListViewUI.Height;
            //this.ListViewUI.Fill = c.ListViewUI.Fill; 
        
        //protected override void OnMouseMove(MouseEventArgs e)
        //{
        //    base.OnMouseMove(e);
        //    if (e.LeftButton == MouseButtonState.Pressed)
        //    {
        //        // Package the data.
        //        DataObject data = new DataObject();
        //        data.SetData(DataFormats.StringFormat, ListViewUI.Fill.ToString());
        //        data.SetData("Double", ListViewUI.Height);
        //        data.SetData("Object", this);

        //        // Inititate the drag-and-drop operation.
        //        DragDrop.DoDragDrop(this, data, DragDropEffects.Copy | DragDropEffects.Move);
        //    }
        //}
    }
}
