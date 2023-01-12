﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rediRND
{
    internal interface IContainer : IStaker
    {
        public void PrintContents(bool isRecursive);
        public void CalculateStake(bool isRecursive);
        public void SetWeight(IStaker staker, int weight);

    }

}
