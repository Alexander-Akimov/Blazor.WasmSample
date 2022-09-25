using System.ComponentModel.DataAnnotations;

namespace Blazor.WasmSample.Client.Models;

public class BookEditModel
{
    [StringLength(20, ErrorMessage = "Title is too long")]
    [Required]
    public string Title { get; set; } = string.Empty;
    public DateTime ReleaseDate { get; set; } = DateTime.Today;
    public string? Type { get; set; } = string.Empty;
}
