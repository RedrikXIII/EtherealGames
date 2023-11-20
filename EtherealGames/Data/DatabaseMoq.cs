using EtherealGames.Models;
using static System.Net.WebRequestMethods;

namespace EtherealGames.Data
{
    public static class DatabaseMoq
    {

        public static List<GameModel> Games { get; set; }

        static DatabaseMoq()
        {
            Games = new List<GameModel>()
            {
                new GameModel()
                {
                    Id = Guid.NewGuid(),
                    Price = 15.29,
                    Discount = 20,
                    Title = "Oirbo",
                    SmallImageUrl = "https://cdn1.epicgames.com/spt-assets/2d4f1465e9254425b5b03c8a429d4d9b/oirbo-ffbg6.png?h=480&amp",
                    IsMainSlider = true
                },
                new GameModel()
                {
                    Id = Guid.NewGuid(),
                    Price = 0,
                    Discount = 0,
                    Title = "The Lord Of The Rings: Gollum",
                    SmallImageUrl = "https://cdn1.epicgames.com/spt-assets/d20026139e774e57ab451e2a1b94c6e2/download-the-lord-of-the-rings--gollum-offer-clg3r.png?h=480&amp",
                    IsMainSlider = true
                },
                new GameModel()
                {
                    Id = Guid.NewGuid(),
                    Price = 52.9,
                    Discount = 0,
                    Title = "Kerbal Space Program 2",
                    SmallImageUrl = "https://cdn1.epicgames.com/offer/038295c445bb40d1b06545fd75741af1/EGS_KerbalSpaceProgram2_InterceptGames_S2_1200x1600-a28fc59b570d183358da192385d777d5?h=480&amp",
                    IsMainSlider = true
                },
                new GameModel()
                {
                    Id = Guid.NewGuid(),
                    Price = 2.99,
                    Discount = 20,
                    Title = "Hanoi Puzzles: Solid Match",
                    SmallImageUrl = "https://cdn1.epicgames.com/spt-assets/58e43b2cb77d4087882873f43831b6a1/hanoi-puzzles--solid-match-c5eqt.png?h=480&amp",
                    IsMainSlider = true

                },
                new GameModel()
                {
                    Id = Guid.NewGuid(),
                    Price = 6.09,
                    Discount = 17,
                    Title = "Skotos",
                    SmallImageUrl = "https://cdn1.epicgames.com/spt-assets/bcf3123569854b6899bdb845592f6a6f/skotos-gw3w4.png?h=480&amp",
                    IsMainSlider = true
                },
                new GameModel()
                {
                    Id = Guid.NewGuid(),
                    Price = 7.09,
                    Discount = 40,
                    Title = "The Shape of Things",
                    SmallImageUrl = "https://cdn1.epicgames.com/spt-assets/4e98b450d40e4a189f5466490627f6f5/the-shape-of-things-sg3x4.png?h=480&amp",
                    IsMainSlider = true
                },
                new GameModel()
                {
                    Id = Guid.NewGuid(),
                    Price = 16.5,
                    Discount = 13,
                    Title = "Ginsha",
                    SmallImageUrl = "https://cdn1.epicgames.com/spt-assets/d9cf30b30233475dbcf56055db33c826/ginsha-11fm9.jpg?h=480&amp",
                    IsMainSlider = false
                }
            };
        }
    }
}
