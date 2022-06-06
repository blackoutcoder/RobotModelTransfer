using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Head
    {
        public string Color { get; set; }
        enum HeadType
        {
            HumanType,
            Android
        }

        public Head (string color)
        {
            Color = color;
        }
    }
}
