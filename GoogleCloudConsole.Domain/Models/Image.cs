using CSharpFunctionalExtensions;

namespace GoogleCloudConsole.Domain.Models;

public class Image
{
    private Image(string fileName, string url)
    {
        FileName = fileName;
        Url = url;
    }

    public string FileName { get; } = string.Empty;
    public string Url { get; } = string.Empty; // Добавляем свойство Path

    public static Result<Image> Create(string fileName, string url)
    {
        if (string.IsNullOrWhiteSpace(fileName))
        {
            return Result.Failure<Image>($"'{nameof(fileName)}' can't be null or empty");
        }

        if (string.IsNullOrWhiteSpace(url))
        {
            return Result.Failure<Image>($"'{nameof(url)}' can't be null or empty");
        }

        return Result.Success(new Image(fileName, url));
    }
}