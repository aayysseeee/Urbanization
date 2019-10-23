﻿using SixLabors.ImageSharp;
using System.Reflection;
using Mirage.Urbanization.ZoneConsumption.Base;
using Mirage.Urbanization.ZoneConsumption.Base.Behaviours;

namespace Mirage.Urbanization.ZoneConsumption
{
    public class ParkZoneConsumption : BaseNetworkZoneConsumption, ISingleZoneConsumptionWithPollutionBehaviour
    {
        public override string Name => "Park";
        public override char KeyChar => 'n';
        public override int Cost => 25;
        public override IGetCanOverrideWithResult GetCanOverrideWith(IAreaZoneConsumption consumption)
        {
            return new AreaZoneConsumptionOverrideInfoResult(consumption, consumption);
        }

        public override Color Color => Color.DarkGreen;

        private static readonly DynamicPollutionBehaviour ParkPollutionBehaviour = new DynamicPollutionBehaviour(() => -40);

        public IPollutionBehaviour PollutionBehaviour => ParkPollutionBehaviour;
        public override Image Tile => Image.Load(Assembly.GetExecutingAssembly().GetManifestResourceStream("Mirage.Urbanization.Tiles.park.png"));

        public ParkZoneConsumption(ZoneInfoFinder neighborNavigator) : base(neighborNavigator)
        {
        }
    }
}