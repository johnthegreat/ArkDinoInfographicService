namespace ArkDinoInfographicGenerator.Dto;

public class CreatureSpecification
{
    public string Species { get; set; }
    public string Name { get; set; }
    public int CurrentLevel;
    public int MaxLevel;
    public bool? IsMale { get; set; }
    public int MutationsCount { get; set; }
    public int Generation { get; set; }
    public bool HasMutagen { get; set; }
    
    public CreatureColorSet Color0 { get; set; }
    public CreatureColorSet Color1 { get; set; }
    public CreatureColorSet Color2 { get; set; }
    public CreatureColorSet Color3 { get; set; }
    public CreatureColorSet Color4 { get; set; }
    public CreatureColorSet Color5 { get; set; }
    
    public CreatureStats StatsBred { get; set; }
    public CreatureStats StatsLeveled { get; set; }
}