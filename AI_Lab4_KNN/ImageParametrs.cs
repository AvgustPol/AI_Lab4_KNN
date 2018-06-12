using System.Collections.Generic;

namespace AI_Lab4_KNN
{
    public class ImageParametrs
    {
        /// <summary>
        /// int - point index
        /// list - list of index parametrs
        /// </summary>
        public Dictionary<int, List<int>> attributes;
        public Dictionary<int, int?> pairIndexes;
        //public int? OtherPicturePointIndex { get; set; }

        public ImageParametrs()
        {
            // Parametrs.NUMBER_OF_PARAMETR
            attributes = new Dictionary<int, List<int>>();
            pairIndexes = new Dictionary<int, int?>();
            OtherPicturePointIndex = null;
        }

        public void AddPointParametr(int pointIndex, List<int> parametrs)
        {
            attributes.Add(pointIndex, parametrs);
        }

        public void SetOtherImageIndex(int thisIndex, int otherIndex)
        {
            pairIndexes[123].
        }
    }
}