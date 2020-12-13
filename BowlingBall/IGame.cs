using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public interface IGame
    {
        void Roll(int pins);
        int GetScore(int firstTry, int secondTry, List<int> frameScores, int? thirdRoll = 0);
    }
}
