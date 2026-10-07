using Full_Stack_Grad_Project.Model;

namespace Full_Stack_Grad_Project.Repo.Interfaces
{
    public interface IProgramRepo
    {
        Task<IEnumerable<LearningProgram>> GetAllProgramsAsync();
        Task<LearningProgram> GetProgramDetailsAsync(int id);
        Task<IEnumerable<LearningProgram>> GetRelatedProgramsAsync(LearningProgram program, int count);
    }
}
