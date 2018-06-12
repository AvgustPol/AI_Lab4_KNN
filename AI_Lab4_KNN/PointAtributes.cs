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
        public int? OtherInageIndex { get; set; }

        public PointAtributes()
        {
            attributes = new List<int>();
            OtherInageIndex = null;
        }
        public PointAtributes(List<int> attributes)
        {
            this.attributes = attributes;
            OtherInageIndex = null;
        }

        public void SetOtherInageIndex(int otherInageIndex)
        {
            OtherInageIndex = otherInageIndex;
        }
    }
}
