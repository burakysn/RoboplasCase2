using Business.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Model.Model;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessController : ControllerBase
    {
        private readonly IProcessBs _processBs;

        public ProcessController(IProcessBs processBs)
        {
            _processBs = processBs;
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Process([FromBody] Process pr)
        {
            var response = _processBs.Process(pr);
            return Ok(response);
        }
    }
}
