using System;
using System.Threading.Tasks;
using HostelSystem.Model;

namespace HostelSystem.Service.Service
{
    public interface IRezerwacjaService
    {
        Task<RezerwacjeResultModel> Get();
        Task<RezerwacjaDto> Get(Guid id);
    }
}