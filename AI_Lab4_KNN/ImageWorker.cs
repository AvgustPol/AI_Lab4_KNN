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
            foreach (var pointIndex in firstImageParametrs.allPointAttributes.Keys)
            {
                FindNearestNeighbour(pointIndex, ref firstImageParametrs, secondImageParametrs);
            }
        }

        private void FindNearestNeighbour(int firstPointIndex, ref ImageParametrs firstImageParametrs, ImageParametrs secondImageParametrs)
        {
            int smallestDistanceID = 0;
            double smallestDistance = double.MaxValue;

            foreach (var secondPointIndex in secondImageParametrs.allPointAttributes.Keys)
            {
                double foundDistance = FindEuclideanDistance(firstImageParametrs.allPointAttributes[firstPointIndex].attributes, secondImageParametrs.allPointAttributes[secondPointIndex].attributes);
                if (smallestDistance > foundDistance)
                {
                    smallestDistance = foundDistance;
                    smallestDistanceID = secondPointIndex;
                    firstImageParametrs.allPointAttributes[firstPointIndex].SetOtherInageIndex(secondPointIndex);
                }
            }
        }

        private double FindEuclideanDistance(List<int> firstPointAttributes, List<int> secondPointAttributes)
        {
            double sum = 0;
            for (int i = 0; i < Parametrs.NUMBER_OF_PARAMETRS; i++)
            {
                sum += (firstPointAttributes[i] - secondPointAttributes[i]) * (firstPointAttributes[i] - secondPointAttributes[i]);
            }
            return Math.Sqrt(sum);
        }
    }
}
