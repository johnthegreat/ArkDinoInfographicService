using ArkDinoInfographicGenerator.ColorResolver.Dto;

namespace ArkDinoInfographicGenerator.ColorResolver;

public interface IColorResolver
{
    public Task<ArkColorDto?> ResolveColorCodeAsync(int arkColorId);
}