using EtherealGames.Models;

namespace EtherealGames.Data
{
    public static class DatabaseMoq
    {
        public static List<SliderModel> Slides { 
            get 
            {
                var slides = new List<SliderModel>
                {
                    new SliderModel()
                    {
                        Title = "Farlight 84",
                        Image = "https://cdn2.unrealengine.com/egs-farlight-84-carousel-thumb-1200x1600-1a3698d6350b.jpg?h=128&amp",
                        Url = "/games"
                    },
                    new SliderModel()
                    {
                        Title = "Test 1",
                        Image = "https://cdn2.unrealengine.com/egs-farlight-84-carousel-thumb-1200x1600-1a3698d6350b.jpg?h=128&amp",
                        Url = "/games"
                    },
                    new SliderModel()
                    {
                        Title = "Test 2",
                        Image = "https://cdn2.unrealengine.com/egs-farlight-84-carousel-thumb-1200x1600-1a3698d6350b.jpg?h=128&amp",
                        Url = "/games"
                    },
                    new SliderModel()
                    {
                        Title = "Test 3",
                        Image = "https://cdn2.unrealengine.com/egs-farlight-84-carousel-thumb-1200x1600-1a3698d6350b.jpg?h=128&amp",
                        Url = "/games"
                    },
                    new SliderModel()
                    {
                        Title = "Test 4",
                        Image = "https://cdn2.unrealengine.com/egs-farlight-84-carousel-thumb-1200x1600-1a3698d6350b.jpg?h=128&amp",
                        Url = "/games"
                    },
                    new SliderModel()
                    {
                        Title = "Test 5",
                        Image = "https://cdn2.unrealengine.com/egs-farlight-84-carousel-thumb-1200x1600-1a3698d6350b.jpg?h=128&amp",
                        Url = "/games"
                    },
                };

                return slides;
            } 
        }

        public static List<GameModel> Games { get; set; }

        static DatabaseMoq()
        {
            Games = new List<GameModel>()
            {
                new GameModel()
                {
                    Id = Guid.NewGuid(),
                    Price = 1200,
                    Sale = 0,
                    Title = "Game1"
                },
                new GameModel()
                {
                    Id = Guid.NewGuid(),
                    Price = 0,
                    Sale = 0,
                    Title = "Game2"
                },
                new GameModel()
                {
                    Id = Guid.NewGuid(),
                    Price = 999,
                    Sale = 0,
                    Title = "Game3"
                },
                new GameModel()
                {
                    Id = Guid.NewGuid(),
                    Price = 500,
                    Sale = 50,
                    Title = "Game4"
                },
                new GameModel()
                {
                    Id = Guid.NewGuid(),
                    Price = 1200,
                    Sale = 33,
                    Title = "Game5"
                },
                new GameModel()
                {
                    Id = Guid.NewGuid(),
                    Price = 120,
                    Sale = 10,
                    Title = "Game6"
                },
                new GameModel()
                {
                    Id = Guid.NewGuid(),
                    Price = 1200,
                    Sale = 0,
                    Title = "Game7"
                }
            };
        }
    }
}
