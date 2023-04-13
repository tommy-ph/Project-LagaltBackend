namespace Project_LagaltBackend.Exceptions
{
    public class ProjectNotFoundException : Exception
    {
        public ProjectNotFoundException(int id) : base($"Project with id {id} was not found")
        {

        }
    }
}
