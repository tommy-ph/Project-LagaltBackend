using Project_LagaltBackend.Models.Main;

namespace Project_LagaltBackend.Services
{
    public interface IProjectService
    {
        Task<IEnumerable<Project>> GetAllProjects();
        Task<Project> GetProjectById(int id);
        Task<Project> UpdateProject(Project project);
        Task<Project> AddProject(Project project);
        Task DeleteProject(int id);
    }
}
