using Full_Stack_Grad_Project.DTOs;

namespace Full_Stack_Grad_Project.Services.Interfaces
{
    public interface IProgramService
    {
        Task<IEnumerable<ProgramSummaryDTO>> GetAllProgramsAsync();
        Task<ProgramDetailsDTO> GetProgramDetailsAsync(int id);
    }
}
