using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle.Model.Interface
{
   public  interface Idatabridge
    {
        IImageHolder ImgHolder { get; }

        bool SaveCurrentPuzleToFile(string path2 = null);
        int Rows { get; set; }
        int Columns { get; set; }
    }
}
