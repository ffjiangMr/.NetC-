using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8.Core
{
    public sealed class ReadonlyDemo
    {
    }

    public struct Point
    {
        public Double X { get; set; }

        public Double Y { get; set; }

        public Double Distance => Math.Sqrt(X * X + Y * Y);

        public readonly override string ToString() => $"({X},{Y}) is {Distance} from the origin";       
    }
}
