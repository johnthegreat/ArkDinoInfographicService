namespace ArkDinoInfographicGenerator.CreatureImageProvider;

public interface ICreatureImageResolver
{
    public Task<byte[]> GetCreatureImageAsync(string creatureName, int color0, int color1, int color2, int color3, int color4, int color5);
}