using System;
using System.Collections.Generic;
using System.Text;

namespace Form
{
    interface IShape
    {
        int height { get; }
        int width { get; }
        void Print(int x, int y);
    }
}