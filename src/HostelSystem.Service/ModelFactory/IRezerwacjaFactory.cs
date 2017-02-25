using HostelSystem.Domain;
using HostelSystem.Model;

namespace HostelSystem.Service.ModelFactory
{
    public interface IRezerwacjaFactory
    {
        RezerwacjaDto CreateModel(Rezerwacja rezerwacja);
    }
}