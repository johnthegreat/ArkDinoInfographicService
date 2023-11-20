namespace ArkDinoInfographicGenerator.Localization;

public interface ILocalizationProvider
{
    public Task<string> GetLocalizedStringAsync(string locale, string messageKey);
}