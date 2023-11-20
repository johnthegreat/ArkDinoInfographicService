using ArkDinoInfographicGenerator.ColorResolver.Dto;

namespace ArkDinoInfographicGenerator.ColorResolver.Default;

public class DefaultColorResolverImpl : IColorResolver
{
    public Task<ArkColorDto?> ResolveColorCodeAsync(int arkColorId)
    {
        // TODO pull from external resource e.g. json, database, etc.
        
        if (arkColorId == 1)
        {
            return Task.FromResult<ArkColorDto?>(new ArkColorDto()
            {
                ColorId = 1,
                ColorName = "Red",
                HexCode = "#ff0000"
            });
        }

        return Task.FromResult<ArkColorDto?>(null);
    }
}