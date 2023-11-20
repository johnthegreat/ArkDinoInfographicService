namespace ArkDinoInfographicGenerator.Dto;

public class InfographicConfiguration
{
    public string Locale { get; set; }
    public int HeightPixels { get; set; }
    public string ForeColor { get; set; }
    public string BackColor { get; set; }
    public string BorderColor { get; set; }
    public string FontName { get; set; }
    public int MaxWildServerLevel { get; set; }
    public bool ShowMaxWildServerLevel { get; set; }
    public ImageExportFormat ImageExportFormat { get; set; }
}