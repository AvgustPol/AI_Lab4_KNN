using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Lab4_KNN
{
    class ImageWorker
    {
        public List<int> FindKNN(ref ImageParametrs firstImageParametrs, ref ImageParametrs secondImageParametrs)
        {
            FindNearestNeighbourForAllPoints(ref firstImageParametrs, ref secondImageParametrs);
            FindNearestNeighbourForAllPoints(ref secondImageParametrs, ref firstImageParametrs);
            return FindPointPairs(secondImageParametrs, firstImageParametrs);
        }

        public void DrawLines(List<int> pairIndexes, ImageParametrs firstImageParametrs, ImageParametrs secondImageParametrs)
        {
            Bitmap bitmap = (Bitmap)Image.FromFile(Parametrs.PATH_TO_WORKING_FILES + Parametrs.MERGED_IMAGE_NAME);

            int secondImageIndex = (int) firstImageParametrs.allPointAttributes[pairIndexes[0]].OtherImageIndex;
            DrawLine(bitmap, 
                firstImageParametrs.allPointAttributes[pairIndexes[0]].PointX, 
                firstImageParametrs.allPointAttributes[pairIndexes[0]].PointY,
                secondImageParametrs.allPointAttributes[pairIndexes[secondImageIndex]].PointX,
                secondImageParametrs.allPointAttributes[pairIndexes[secondImageIndex]].PointY
                );
        }

        public void DrawLine(Bitmap bmp, int x1, int y1, int x2, int y2)
        {
            Pen blackPen = new Pen(Color.Yellow, 2);
            // Draw line to screen.
            using (var graphics = Graphics.FromImage(bmp))
            {
                graphics.DrawLine(blackPen, x1, y1, x2, y2);
            }
            bmp.Save(Parametrs.PATH_TO_WORKING_FILES + Parametrs.EDITED_MERGED_IMAGE_NAME);
        }

        private List<int> FindPointPairs(ImageParametrs firstImageParametrs, ImageParametrs secondImageParametrs)
        {
            List<int> pairIndexes = new List<int>();
            foreach (var pointIndex in firstImageParametrs.allPointAttributes.Keys)
            {
                //firstIndex must point to secondIndex (firstIndex == secondIndex)
                int? firstIndex = firstImageParametrs.allPointAttributes[pointIndex].OtherImageIndex;
                if (firstIndex != null)
                {
                    int? secondIndex = secondImageParametrs.allPointAttributes[(int)firstIndex].OtherImageIndex;
                    //secondIndex must point to firstIndex (secondIndex == firstIndex)
                    if ((int)secondIndex == (int)firstIndex)
                    {
                        //Tuple<int, int> pairPointIndexes = new Tuple<int, int>((int) firstIndex, (int) secondIndex);
                        pairIndexes.Add((int)firstIndex);
                    }
                }
            }
            return pairIndexes;
        }

        private void FindNearestNeighbourForAllPoints(ref ImageParametrs firstImageParametrs, ref ImageParametrs secondImageParametrs)
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
