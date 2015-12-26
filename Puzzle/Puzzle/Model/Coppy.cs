using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle.Model
{
    public abstract class Coppy
    {
         public List<Fragment> Fragments
        {
            get; set;
        }
         public abstract Coppy Clone();
         
    }
}
