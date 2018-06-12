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
            foreach (var pointIndex in firstImageParametrs.attributes.Keys)
            {
                FindNearestNeighbour(pointIndex, secondImageParametrs);
            }
        }

        private Tuple<int, int> FindNearestNeighbour(int firstPointIndex, ImageParametrs firstImageParametrs, ImageParametrs secondImageParametrs)
        {
            int smallestDistanceID = 0;
            double smallestDistance = double.MaxValue;

            foreach (var secondPointIndex in secondImageParametrs.attributes.Keys)
            {
                double foundDistance = FindEuclideanDistance(firstImageParametrs.attributes[firstPointIndex], secondImageParametrs.attributes[secondPointIndex]);
                if (smallestDistance > foundDistance)
                {
                    smallestDistance = foundDistance;
                    smallestDistanceID = secondPointIndex;
                }
            }

            firstImageParametrs.pairIndexes[firstPointIndex].Value = secondPointIndex;

            return new Tuple<int, int>(firstPointIndex, );
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
