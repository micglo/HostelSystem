namespace HostelSystem.Service.CustomException
{
    public class CustomException : ICustomException
    {
        public void ThrowNotFoundException(string message)
        {
            throw new NotFoundException(message);
        }
    }
}