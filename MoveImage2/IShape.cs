using System;
using System.Collections.Generic;
using System.Text;

namespace Form
{
    interface IShape
    {
        int GetHeight();
        int GetWidth();
        void Print(int x, int y);
    }
}