using System.ComponentModel.DataAnnotations;

namespace Cwiczenia7.DTOs;

public class CreatePcDto
{
    [Required]
    [MaxLength(40)]
    public string Name { get; set; } = null!;

    [Range(0.01, double.MaxValue)]
    public double Weight { get; set; }

    [Range(0, int.MaxValue)]
    public int Warranty { get; set; }

    public DateTime CreatedAt { get; set; }

    [Range(0, int.MaxValue)]
    public int Stock { get; set; }
}