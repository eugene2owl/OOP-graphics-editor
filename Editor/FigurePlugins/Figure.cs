﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

public abstract class Figure
{
    abstract public GraphicsPath GetPath();
    abstract public void SetManualParameters(int[] values);
}
