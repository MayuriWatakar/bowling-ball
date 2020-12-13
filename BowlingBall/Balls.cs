using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public class Ball
    {
        private int _iPinsKnocked;
        private bool _bThrowIsStrike;
        private bool _bThrowIsSpare;
        public Ball()
        {
        }
        public Ball(int iPinsKnocked)
        {
            _iPinsKnocked = iPinsKnocked;
        }
        public void MarkBall(int iPinsKnocked)
        {
            _iPinsKnocked = iPinsKnocked;
        }
        public void MarkBall(bool bStrike, bool bSpare)
        {
            _bThrowIsStrike = bStrike;
            _bThrowIsSpare = bSpare;
        }
    }

}
