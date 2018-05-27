using System.ComponentModel.DataAnnotations;

namespace BusStations.Core.Abstract
{
    public interface IEntity
    {
        [Key]
        int Id { get; set; }

    }
}