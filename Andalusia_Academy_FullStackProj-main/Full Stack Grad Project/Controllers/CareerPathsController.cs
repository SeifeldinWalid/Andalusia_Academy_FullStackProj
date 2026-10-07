using Full_Stack_Grad_Project.DTOs;
using Full_Stack_Grad_Project.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Full_Stack_Grad_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CareerPathsController : ControllerBase
    {
        private readonly ICareerPathService _careerPathService;

        public CareerPathsController(ICareerPathService careerPathService)
        {
            _careerPathService = careerPathService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CareerPathSummaryDTO>>> GetCareerPaths()
        {
            var careerPaths = await _careerPathService.GetAllCareerPathsAsync();
            return Ok(careerPaths);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<CareerPathDetailsDTO>> GetCareerPathDetails(int id)
        {
            var careerPath = await _careerPathService.GetCareerPathDetailsAsync(id);
            return Ok(careerPath);
        }
    }
}
