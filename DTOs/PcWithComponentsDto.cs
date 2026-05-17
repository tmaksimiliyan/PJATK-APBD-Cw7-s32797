namespace Cwiczenia7.DTOs;

public class PcWithComponentsDto
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public double Weight { get; set; }

    public int Warranty { get; set; }

    public DateTime CreatedAt { get; set; }

    public int Stock { get; set; }

    public ICollection<PcComponentDto> Components { get; set; } = new List<PcComponentDto>();
}