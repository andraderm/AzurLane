using AzurLaneApi.Application.Dtos.Ship;

namespace AzurLaneApi.Application.Interfaces
{
    public interface IShipApplicationService
    {
        Task<List<ReadShipDto>> GetAll();
        Task Insert(CreateShipDto model);
        Task InsertImage(string id, IFormFile image);
    }
}
