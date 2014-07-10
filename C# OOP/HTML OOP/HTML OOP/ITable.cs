﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HTMLRenderer
{
    public interface ITable : IElement
    {
        int Rows { get; }
        int Cols { get; }
        IElement this[int row, int col] { get; set; }
    }
}
