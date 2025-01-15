using GoogleCloudConsole.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GoogleCloudConsoleAPI_Tests.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GoogleDriveController : ControllerBase
{
    private readonly IGoogleDriveService _googleDriveService;

    public GoogleDriveController(IGoogleDriveService googleDriveService)
    {
        _googleDriveService = googleDriveService;
    }

    [HttpPost("upload")]
    public async Task<IActionResult> UploadImage([FromForm] IFormFile file)
    {
        if (file == null || file.Length == 0)
        {
            return BadRequest("Invalid file.");
        }

        var result = await _googleDriveService.CreateImage(file, file.FileName);

        if (result.IsFailure)
        {
            return BadRequest(result.Error);
        }

        return Ok(new { result.Value.FileName, result.Value.Url });
    }
}