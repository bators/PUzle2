using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle.Model.Interface
{
  public   interface IImageHolder
  {
      IEnumerable<Fragment> GetImgPuzzles(int rows, int columns);
      bool SaveImg(string pathImg);
    }
}
