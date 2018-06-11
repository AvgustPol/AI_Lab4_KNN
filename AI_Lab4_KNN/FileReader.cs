using System;
using System.IO;

namespace AI_Lab4_KNN
{
    public static class FileReader
    {
        static Random random = new Random((int)DateTime.Now.Ticks + 42);
        
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
                    string fileContent = reader.ReadToEnd();

                    string[] integerStrings = fileContent.Split(new char[] { ' ', '\t', '\r', '\n', ';' }, StringSplitOptions.RemoveEmptyEntries);
                }
            }
            return parametrs;
        }

        /*
                    string fileContent = reader.ReadToEnd();

                    string[] integerStrings = fileContent.Split(new char[] { ' ', '\t', '\r', '\n' , ';'}, StringSplitOptions.RemoveEmptyEntries);
                    
                    Parametrs.NumberOfGameMoves = int.Parse(integerStrings[Parametrs.GameTimeIndex]);
                    int EnemyMoveCellX = int.Parse(integerStrings[Parametrs.MoveCellXIndex]);
                    int EnemyMoveCellY = int.Parse(integerStrings[Parametrs.MoveCellYIndex]);

                    lastMove = new Cell(EnemyMoveCellX, EnemyMoveCellY);
                
         */
    }
}
