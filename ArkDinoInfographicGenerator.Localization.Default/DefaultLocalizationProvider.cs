namespace ArkDinoInfographicGenerator.Localization.Default;

public class DefaultLocalizationProvider : ILocalizationProvider
{
    public Task<string> GetLocalizedStringAsync(string locale, string messageKey)
    {
        // This is just an example...
        
        if (locale == "en-CA")
        {
            if (messageKey == "Color")
            {
                return Task.FromResult<string>("Colour");
            }
        }

        throw new UnsupportedLocaleException();
    }
}