using System;
using System.IO;

namespace AI_Lab4_KNN
{
    public static class FileReader
    {
        static Random random = new Random((int)DateTime.Now.Ticks + 42);
        
        public static ImageParametrs ReadParametrs(int playerIndex)
        {
            Cell lastMove = null;
            if (File.Exists(playerIndex == 0 ? Parametrs.PATH_MOVE : Parametrs.PATH_MADE_MOVE))
            {
                using (StreamReader reader = File.OpenText(playerIndex == 0 ? Parametrs.PATH_MOVE : Parametrs.PATH_MADE_MOVE))
                {
                    string fileContent = reader.ReadToEnd();

                    string[] integerStrings = fileContent.Split(new char[] { ' ', '\t', '\r', '\n' , ';'}, StringSplitOptions.RemoveEmptyEntries);
                    
                    Parametrs.NumberOfGameMoves = int.Parse(integerStrings[Parametrs.GameTimeIndex]);
                    int EnemyMoveCellX = int.Parse(integerStrings[Parametrs.MoveCellXIndex]);
                    int EnemyMoveCellY = int.Parse(integerStrings[Parametrs.MoveCellYIndex]);

                    lastMove = new Cell(EnemyMoveCellX, EnemyMoveCellY);
                }
                File.Delete(playerIndex == 0 ? Parametrs.PATH_MOVE : Parametrs.PATH_MADE_MOVE);
            }
            return lastMove;
        }
    }
}
