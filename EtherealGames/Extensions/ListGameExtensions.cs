using EtherealGames.Data;
using EtherealGames.Models;

namespace EtherealGames.Extensions
{
    public static class ListGameExtensions
    {
        public static List<SliderModel> GetSlides(this List<GameModel> games)
        {
            return games
                    .Where(g => g.IsMainSlider)
                    .Take(6)
                    .Select(g =>
                    {
                        SliderModel slider = g;
                        return slider;
                    }).ToList();
        }
    }
}
