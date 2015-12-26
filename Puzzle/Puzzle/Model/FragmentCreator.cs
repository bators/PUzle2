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

        Image _img = Image.FromFile("C:/Users/NB HP/Desktop/ПРОГА2курс/BuildProcessTemplates/Puzzle/Puzzle/Img/444.jpg");
     
        public FragmentCreator()
        {
            Fragments = new List<Fragment>();
         
         }

        public override Coppy Clone()
        {
            return (Coppy)this.MemberwiseClone();
        }
       
        public void CreatFragment()
        {int index=0;
            
            int widthThird = (int)((double)_img.Width / 3.0 + 0.5);
            int heightThird = (int)((double)_img.Height / 3.0 + 0.5);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    var bmp = new Bitmap(widthThird, heightThird);
                    Graphics graph = Graphics.FromImage(bmp);
                    graph.DrawImage(_img, new Rectangle(0, 0, widthThird, heightThird), new Rectangle(j * widthThird, i * heightThird, widthThird, heightThird), GraphicsUnit.Pixel);

                    Fragments.Add(new Model.Fragment() { ind = index++, Pic = bmp, });
                    
                    graph.Dispose();
                }
            }
            
        }
    }

  
}
