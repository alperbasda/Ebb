namespace BusStations.Business.Abstract
{
    public interface IBusStationLayer
    {
        void SetBusStationLocation(decimal x, decimal y);
        decimal[] GetBusStationLocation();
    }
}