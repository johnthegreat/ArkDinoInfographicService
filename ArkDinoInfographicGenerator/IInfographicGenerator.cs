using ArkDinoInfographicGenerator.ColorResolver;
using ArkDinoInfographicGenerator.CreatureImageProvider;
using ArkDinoInfographicGenerator.Localization;
using ArkDinoInfographicGenerator.Dto;

namespace ArkDinoInfographicGenerator;

public interface IInfographicGenerator
{
    public Task<byte[]> GenerateInfographicAsync(InfographicConfiguration configuration,
        CreatureSpecification creatureSpecification, IColorResolver colorResolver,
        ILocalizationProvider localizationProvider, ICreatureImageResolver creatureImageResolver);
}