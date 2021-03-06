﻿using System.Collections.Generic;

namespace AI_Lab4_KNN
{
    public class ImageParametrs
    {
        /// <summary>
        /// int - point index
        /// list - list of index parametrs
        /// </summary>
        public Dictionary<int, PointAtributes> allPointAttributes;

        public ImageParametrs()
        {
            // Parametrs.NUMBER_OF_PARAMETR
            allPointAttributes = new Dictionary<int, PointAtributes>();
        }

        public void AddPointParametr(int pointIndex, List<int> parametrs, string pointX, string pointY)
        {
            allPointAttributes.Add(pointIndex, new PointAtributes(parametrs, pointX , pointY));
        }

    }
}