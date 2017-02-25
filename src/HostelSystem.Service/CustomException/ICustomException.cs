namespace HostelSystem.Service.CustomException
{
    public interface ICustomException
    {
        void ThrowNotFoundException(string message);
    }
}