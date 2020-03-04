﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCartographyObjects
{
    public class POI : Coordonnees, ICartoObj
    {

        #region MemberVars

        private string _description;
        private object _tag;

        #endregion

        #region Properties

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public object Tag
        {
            get { return _tag; }
            set { _tag = value; }
        }

        #endregion

        #region Constructors

        public POI(double latitude, double longitude, string description) : base(latitude, longitude)
        {
            Description = description;
        }

        public POI(double latitude, double longitude) : base(latitude, longitude) { }

        public POI(string description) : this(50.6088641, 5.5110179, description) { }

        public POI() : this("HEPL Seraing") {}

        #endregion

        #region Functions

        public override string ToString()
        {
            return base.ToString() + " « " + Description + " »";
        }

        #endregion

    }
}
