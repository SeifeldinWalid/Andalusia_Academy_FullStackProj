using Full_Stack_Grad_Project.Model;

namespace Full_Stack_Grad_Project.Repo.Interfaces
{
    public interface ICareerPathRepo
    {
        Task<IEnumerable<CareerPath>> GetAllCareerPathsAsync();
        Task<CareerPath> GetCareerPathDetailsAsync(int id);
    }
}
