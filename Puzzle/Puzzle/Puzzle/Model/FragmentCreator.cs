using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Collections;


namespace Puzzle.Model
{
    public class FragmentCreator :Coppy, ICreateFragment
    {

        Image _img = Image.FromFile("C:/Users/NB HP/Desktop/Puzzle/Puzzle/Img/111.jpg");

     
        public FragmentCreator()
        {
            Fragments = new List<Fragment>();
         
         }

        public override Coppy Clone()
        {
            return (Coppy)this.MemberwiseClone();
        }

        public void CreatFragment()
        {

            int widthThird = (int)((double)_img.Width / 3.0 + 0.5);
            int heightThird = (int)((double)_img.Height / 3.0 + 0.5);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    var bmp = new Bitmap(widthThird, heightThird);
                    Graphics graph = Graphics.FromImage(bmp);
                    graph.DrawImage(_img, new Rectangle(0, 0, widthThird, heightThird), new Rectangle(j * widthThird, i * heightThird, widthThird, heightThird), GraphicsUnit.Pixel);
                   
                    Fragments.Add(new Model.Fragment() { Name = "рис " + (i+ j).ToString(), I = i, J = j, Pic = bmp});
                    
                    graph.Dispose();
                }
            }
            
        }
    }

  
}
