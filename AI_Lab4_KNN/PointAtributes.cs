using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Lab4_KNN
{
    public class PointAtributes
    {
        public List<int> attributes;
        public int? OtherImageIndex { get; set; }
        public int PointX { get; set; }
        public int PointY { get; set; }

        public PointAtributes()
        {
            attributes = new List<int>();
            OtherImageIndex = null;
        }
        public PointAtributes(List<int> attributes, string x, string y)
        {
            this.attributes = attributes;
            OtherImageIndex = null;
            SetXandYFromDouble(x, y);
        }

        public void SetOtherInageIndex(int otherInageIndex)
        {
            OtherImageIndex = otherInageIndex;
        }
        public void SetXandYFromDouble(string x, string y)
        {
            PointX = (int)Double.Parse(x);
            PointY = (int)Double.Parse(y);
        }
    }
}
