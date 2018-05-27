
namespace BusStations.Business.Abstract
{
    public interface IBusLayer
    {
        void SetBusLocation(decimal x,decimal y);
        void SetDirection(bool value);
        decimal[] GetBusLocation();
    }
}