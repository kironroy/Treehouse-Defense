using System;
using System.Collections.Generic;
using System.Text;

namespace TreehouseDefense
{
    class StrongInvader : Invader
    {
        public override int Health { get; protected set; } = 2;
        public StrongInvader(Path path) : base(path)
        {

        }
    }
}
