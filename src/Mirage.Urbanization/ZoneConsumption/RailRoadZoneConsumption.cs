﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using Mirage.Urbanization.ZoneConsumption.Base;

namespace Mirage.Urbanization.ZoneConsumption
{
    public class RailRoadZoneConsumption : BaseInfrastructureNetworkZoneConsumption
    {
        public RailRoadZoneConsumption(ZoneInfoFinder neighborNavigator) : base(neighborNavigator) { }

        public override string Name
        {
            get { return "Railroad"; }
        }

        public override bool CanBeOverriddenByZoneClusters
        {
            get { return false; }
        }

        public override Color Color
        {
            get { return System.Drawing.Color.SaddleBrown; }
        }
    }
}