﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    public class GameFrame
    {
        private readonly int _iFrameNo;
        private List<Ball> _throwList;
        public GameFrame(int iFrameNo)
        {
            _iFrameNo = iFrameNo;
            _throwList = new List<Ball>();
        }
    }
}
