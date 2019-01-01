﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseDefense
{
    class BasicInvader : Invader
    {
        public override int Health { get; protected set; } = 2;
        public BasicInvader (Path path) : base(path)
        { } 
    }
}
