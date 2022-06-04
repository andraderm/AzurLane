using AutoMapper;
using AzurLaneApi.Application.Dtos.Ship;
using AzurLaneApi.Application.Interfaces;
using AzurLaneApi.Domain.Entities;
using AzurLaneApi.Domain.Interfaces;

namespace AzurLaneApi.Application.Services
{
    public class ShipApplicationService : IShipApplicationService
    {
        private readonly IShipService _shipService;
        private readonly IMapper _mapper;

        public ShipApplicationService(
            IShipService shipService,
            IMapper mapper)
        {
            _shipService = shipService;
            _mapper = mapper;
        }

        public async Task<List<ReadShipDto>> GetAll()
        {
            List<Ship> ships = await _shipService.GetAll();

            return _mapper.Map<List<ReadShipDto>>(ships);
        }

        public async Task Insert(CreateShipDto model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            Ship entity = _mapper.Map<Ship>(model);
            await _shipService.Insert(entity);
        }

        public async Task InsertImage(string id, IFormFile image)
        {
            if (image.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    image.CopyTo(ms);
                    var fileBytes = ms.ToArray();

                    Ship entity = await _shipService.GetById(id);

                    if (entity != null)
                        entity.Image = fileBytes;

                    await _shipService.Update(entity);
                }
            }
        }
    }
}
