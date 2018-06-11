using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Lab4_KNN
{
    class ImageWorker
    {
        public void FindKNN(ImageParametrs firstImageParametrs, ImageParametrs secondImageParametrs)
        {
            /*
            foreach (var pointA in pictureAParametrs)
            {
                1) найти соседа для пункта А
            }
            */
        }

        private double FindEuclideanDistance(List<int> x, List<int> y)
        {
            double sum = 0;
            for (int i = 0; i < Parametrs.NUMBER_OF_PARAMETRS; i++)
            {
                sum += (x[i] - y[i]) * (x[i] - y[i]);
            }
            return Math.Sqrt(sum);
        }
    }
}
