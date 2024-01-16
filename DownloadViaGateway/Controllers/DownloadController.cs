using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace DownloadViaGateway.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DownloadController : ControllerBase
    {
        private readonly ILogger<DownloadController> _logger;

        public DownloadController(ILogger<DownloadController> logger)
        {
            _logger = logger;
        }

        //[HttpGet("BigFile")]
        //public async Task<FileStreamResult> BigFile()
        //{
        //    var fileName = "big.mp4";
        //    var stream = System.IO.File.OpenRead(Path.Combine("Files", fileName));

        //    Response.Headers.Add("Content-Disposition", $"attachment; filename={fileName}");
        //    return new FileStreamResult(stream, "application/octet-stream");
        //}

        [HttpGet("SmallFile")]
        public async Task<FileStreamResult> SmallFile()
        {
            var fileName = "smallFile";
            var stream = System.IO.File.OpenRead(Path.Combine("Files", fileName));

            Response.Headers.Add("Content-Disposition", $"attachment; filename={fileName}");
            return new FileStreamResult(stream, "application/octet-stream");
        }
    }
}
