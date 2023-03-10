using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni10._3
{
    public class ListNum : List<int>
    {
        private int maximum;
        private int minimum;
        public int Maximum { get; }
        public int Minimum { get; }
        public void Max()
        {
            maximum = this.Select(x => x).Max();
        }
        public void Min()
        {
            minimum = this.Select(x => x).Min();
        }
    }
}
