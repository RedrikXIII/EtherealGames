namespace EtherealGames.Extensions
{
    public static class WebAppExtensions
    {
        public static void UseLocalization(this WebApplication app)
        {
            var cultures = new string[] { "en", "uk" };

            var localisationOption = new RequestLocalizationOptions()
                .SetDefaultCulture(cultures[0])
                .AddSupportedCultures(cultures)
                .AddSupportedUICultures(cultures);

            app.UseRequestLocalization(localisationOption);
        }
    }
}
