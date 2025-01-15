using CSharpFunctionalExtensions;
using GoogleCloudConsole.Domain.Models;
using Microsoft.AspNetCore.Http;

namespace GoogleCloudConsole.Application.Interfaces;

public interface IGoogleDriveService
{
    Task<Result<Image>> CreateImage(IFormFile file, string fileName);
}