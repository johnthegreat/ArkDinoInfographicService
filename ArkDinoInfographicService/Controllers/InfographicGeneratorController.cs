using ArkDinoInfographicGenerator;
using ArkDinoInfographicGenerator.ColorResolver.Default;
using ArkDinoInfographicGenerator.CreatureImageResolver.Default;
using ArkDinoInfographicGenerator.Dto;
using ArkDinoInfographicGenerator.Localization.Default;
using ArkDinoInfographicService.Dto;
using Microsoft.AspNetCore.Mvc;

namespace ArkDinoInfographicService.Controllers;

[ApiController]
[Route("[controller]")]
public class InfographicGeneratorController : ControllerBase
{
    private readonly ILogger<InfographicGeneratorController> _logger;
    private readonly IInfographicGenerator _infographicGenerator;

    public InfographicGeneratorController(ILogger<InfographicGeneratorController> logger,
        IInfographicGenerator infographicGenerator)
    {
        _logger = logger;
        _infographicGenerator = infographicGenerator;
    }

    [HttpPost]
    public async Task<ActionResult<byte[]>> GetInfographicAsync([FromBody] CreatureDetailDto creatureDetailDto)
    {
        _logger.LogTrace("In endpoint to return infographic");

        var infographicConfiguration = new InfographicConfiguration()
        {
            Locale = "en-US",
            BackColor = "#FAEBD7",
            ForeColor = "#000000",
            BorderColor = "#800000",
            FontName = "Arial",
            HeightPixels = 180,
            ImageExportFormat = ImageExportFormat.PNG,
            MaxWildServerLevel = 150,
            ShowMaxWildServerLevel = false
        };

        var creatureSpecification = new CreatureSpecification()
        {
            Species = "Achatina",
            Name = creatureDetailDto.Name,
            CurrentLevel = 177,
            MaxLevel = 241,
            MutationsCount = 0,
            Generation = 0,
            HasMutagen = false,
            StatsBred = new CreatureStats()
            {
                StatHp = 23,
                StatSt = 22,
                StatOx = 21,
                StatFo = 24,
                StatWe = 17,
                StatDm = 19,
                StatSp = 26,
            },
            StatsLeveled = new CreatureStats()
            {
                StatHp = 4,
                StatSt = 4,
                StatOx = 0,
                StatFo = 0,
                StatWe = 16,
                StatDm = 0,
                StatSp = 0,
            },
            Color0 = new CreatureColorSet()
            {
                Color = 33,
                ColorRegionName = "Body"
            },
            Color1 = new CreatureColorSet()
            {
                Color = 28,
                ColorRegionName = "Shell"
            },
            // Achatina does not use Color2 region
            Color3 = new CreatureColorSet()
            {
                Color = 32,
                ColorRegionName = "Shell Highlights"
            },
            Color4 = new CreatureColorSet()
            {
                Color = 23,
                ColorRegionName = "Stripe"
            },
            Color5 = new CreatureColorSet()
            {
                Color = 33,
                ColorRegionName = "Underside"
            }
        };

        try
        {
            var result = await _infographicGenerator.GenerateInfographicAsync(infographicConfiguration,
                creatureSpecification, new DefaultColorResolverImpl(), new DefaultLocalizationProvider(), new DefaultCreatureImageResolver());
            return Ok(result);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        return NoContent();
    }
}