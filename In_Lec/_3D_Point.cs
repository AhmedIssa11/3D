﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace In_Lec
{
    class _3D_Point
    {
        public float X, Y, Z;
        public _3D_Point(float xx, float yy, float zz)
        {
            X = xx;
            Y = yy;
            Z = zz;
        }

        public _3D_Point(_3D_Point p)
        {
            X = p.X;
            Y = p.Y;
            Z = p.Z;
        }
    }
}
