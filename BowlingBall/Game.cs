using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public class Game : IGame
    {
        private readonly int strikeX = 10;
        private readonly int _spareY;
        public Game(int spareY)
        {
            _spareY = spareY;
        }
        public void Roll(int pins)
        {
            try
            {
                List<int> frameScores = new List<int>();
                int frames = 10;
                int firstTry = 0; int secondTry = 0; int thirdRoll = 0;
                int score = 0;
                for (int i = 0; i <= frames; i++)
                {
                    if (firstTry == pins && secondTry == strikeX) //1
                    {
                        score = GetScore(firstTry, secondTry, frameScores, thirdRoll);
                    }
                    else if(firstTry == pins && secondTry == _spareY)
                    {
                        score = GetScore(firstTry, secondTry, frameScores, thirdRoll);
                    }
                    frameScores.Add(score);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int GetScore(int firstTry, int secondTry, List<int> frameScores, int? thirdRoll = 0)
        {
            try
            {
                int recordScore = 0;
                if(frameScores.Count == 0)
                {
                    recordScore = firstTry + secondTry;
                }
               
                
                return recordScore;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
