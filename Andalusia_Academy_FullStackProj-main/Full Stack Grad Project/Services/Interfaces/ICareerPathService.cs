using Full_Stack_Grad_Project.DTOs;

namespace Full_Stack_Grad_Project.Services.Interfaces
{
    public interface ICareerPathService
    {
        Task<IEnumerable<CareerPathSummaryDTO>> GetAllCareerPathsAsync();
        Task<CareerPathDetailsDTO> GetCareerPathDetailsAsync(int id);
    }
}
