﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Rock : StaticObject, IResource
    {
        public Rock(int hitpoints, Point position)
            : base(position)
        {
            this.HitPoints = hitpoints;
        }

        public int Quantity
        {
            get { return (this.HitPoints / 2); }
        }

        public ResourceType Type
        {
            get { return ResourceType.Stone; }
        }
    }
}
