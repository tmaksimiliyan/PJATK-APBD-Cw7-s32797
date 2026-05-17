using Cwiczenia7.DTOs;

namespace Cwiczenia7.Services;

public interface IPcService
{
    Task<ICollection<PcDto>> GetAllAsync();

    Task<PcWithComponentsDto?> GetByIdWithComponentsAsync(int id);

    Task<PcDto> CreateAsync(CreatePcDto request);

    Task<PcDto?> UpdateAsync(int id, UpdatePcDto request);

    Task<bool> DeleteAsync(int id);
}