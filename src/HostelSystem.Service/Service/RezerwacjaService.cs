using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using HostelSystem.Dal;
using HostelSystem.Model;
using HostelSystem.Service.CustomException;
using HostelSystem.Service.ModelFactory;

namespace HostelSystem.Service.Service
{
    public class RezerwacjaService : IRezerwacjaService
    {
        private readonly HostelSystemDbContext _dbContext;
        private readonly IRezerwacjaFactory _rezerwacjaFactory;
        private readonly ICustomException _customException;

        public RezerwacjaService(HostelSystemDbContext dbContext, IRezerwacjaFactory rezerwacjaFactory, ICustomException customException)
        {
            _dbContext = dbContext;
            _rezerwacjaFactory = rezerwacjaFactory;
            _customException = customException;
        }

        public async Task<RezerwacjeResultModel> Get()
        {
            var rezerwacje = await _dbContext.Rezerwacja.Include(r => r.Goscie).ToListAsync();
            var rezerwacjeDto = rezerwacje.Select(_rezerwacjaFactory.CreateModel);
            return new RezerwacjeResultModel
            {
                Rezerwacje = rezerwacjeDto
            };
        }

        public async Task<RezerwacjaDto> Get(Guid id)
        {
            var rezerwacja =
                await _dbContext.Rezerwacja.Include(r => r.Goscie).SingleOrDefaultAsync(r => r.Id.Equals(id));

            if (rezerwacja == null)
                _customException.ThrowNotFoundException(string.Format("Brak rezerwacji o Id: {0}", id));
            return _rezerwacjaFactory.CreateModel(rezerwacja);
        }
    }
}