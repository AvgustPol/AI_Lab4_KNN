using System.Collections.Generic;

namespace AI_Lab4_KNN
{
    public class ImageParametrs
    {
        /// <summary>
        /// int - point index
        /// list - list of index parametrs
        /// </summary>
        Dictionary<int, List<int>> attributes;

        public ImageParametrs()
        {
            // Parametrs.NUMBER_OF_PARAMETR
            attributes = new Dictionary<int, List<int>>();
        }
    }
}