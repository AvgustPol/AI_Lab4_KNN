using System;
using System.Collections.Generic;
using System.IO;

namespace AI_Lab4_KNN
{
    public static class FileReader
    {
        static Random random = new Random((int)DateTime.UtcNow.Ticks + 42);
        
        public static ImageParametrs ReadParametrs(int pictureIndex)
        {
            ImageParametrs parametrs = new ImageParametrs();

            string pathToImage = Parametrs.PATH_TO_WORKING_FILES;
            // first(1) or second(2) image index
            if (pictureIndex == 1)
            {
                pathToImage += Parametrs.FIRST_IMAGE_NAME;
            }
            else
            {
                pathToImage += Parametrs.SECOND_IMAGE_NAME;
            }

            if (File.Exists(pathToImage))
            {
                using (StreamReader reader = File.OpenText(pathToImage))
                {
                    int pointCounter = 0;

                    //skip first two integers
                    reader.ReadLine();
                    reader.ReadLine();

                    string readLine = reader.ReadLine();
                
                    while (readLine != null)
                    {
                        string[] splitedParametrs = readLine.Split(new char[] { ' ', '\t', '\r', '\n', ';' }, StringSplitOptions.RemoveEmptyEntries);

                        ConvertParametrsFromString(splitedParametrs, pointCounter++, ref parametrs);

                        readLine = reader.ReadLine();
                    }
                }
            }
            return parametrs;
        }
        
        private static void ConvertParametrsFromString(string[] splitedParametrs, int pointIndex, ref ImageParametrs parametrs)
        {
            List<int> tmpParametrs = new List<int>();
            
            for (int i = 5; i < Parametrs.NUMBER_OF_PARAMETRS + 5; i++)
            {
                tmpParametrs.Add(Int32.Parse(splitedParametrs[i]));
            }
            parametrs.AddPointParametr(pointIndex, tmpParametrs, splitedParametrs[0], splitedParametrs[1] );
        }
    }
}
