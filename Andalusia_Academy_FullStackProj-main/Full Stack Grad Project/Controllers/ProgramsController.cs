using Full_Stack_Grad_Project.DTOs;
using Full_Stack_Grad_Project.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Full_Stack_Grad_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProgramsController : ControllerBase
    {
        private readonly IProgramService _programService;

        public ProgramsController(IProgramService programService)
        {
            _programService = programService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProgramSummaryDTO>>> GetPrograms()
        {
            var programs = await _programService.GetAllProgramsAsync();
            return Ok(programs);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProgramDetailsDTO>> GetProgramDetails(int id)
        {
            var program = await _programService.GetProgramDetailsAsync(id);
            return Ok(program);
        }
    }
}
