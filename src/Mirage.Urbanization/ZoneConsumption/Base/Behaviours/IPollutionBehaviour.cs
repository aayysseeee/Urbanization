﻿namespace Mirage.Urbanization.ZoneConsumption.Base.Behaviours
{
    public interface IPollutionBehaviour : IBehaviour
    {
        int GetPollutionInUnits(RelativeZoneInfoQuery relativeZoneInfoQuery);
    }

    public interface ICrimeBehaviour : IBehaviour
    {
        int GetCrimeInUnits(RelativeZoneInfoQuery relativeZoneInfoQuery);
    }
}