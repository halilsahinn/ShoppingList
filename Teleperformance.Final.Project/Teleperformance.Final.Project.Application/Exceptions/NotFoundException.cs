namespace Teleperformance.Final.Project.Application.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string name, object key) : base($"{name} ({key}) Bulunamadı")
        {

        }

    }
}
