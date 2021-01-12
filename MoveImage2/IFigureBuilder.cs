using System;
using System.Collections.Generic;
using System.Text;

namespace Form
{
    interface IFigureBuilder
    {
        IShape Create();
    }
}