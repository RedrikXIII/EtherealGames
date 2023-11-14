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
                        Image = "https://cdn2.unrealengine.com/egs-farlight-84-carousel-thumb-1200x1600-1a3698d6350b.jpg?h=128&amp"
                    },
                    new SliderModel()
                    {
                        Title = "Test 1",
                        Image = "https://cdn2.unrealengine.com/egs-farlight-84-carousel-thumb-1200x1600-1a3698d6350b.jpg?h=128&amp"
                    },
                    new SliderModel()
                    {
                        Title = "Test 2",
                        Image = "https://cdn2.unrealengine.com/egs-farlight-84-carousel-thumb-1200x1600-1a3698d6350b.jpg?h=128&amp"
                    },
                    new SliderModel()
                    {
                        Title = "Test 3",
                        Image = "https://cdn2.unrealengine.com/egs-farlight-84-carousel-thumb-1200x1600-1a3698d6350b.jpg?h=128&amp"
                    },
                    new SliderModel()
                    {
                        Title = "Test 4",
                        Image = "https://cdn2.unrealengine.com/egs-farlight-84-carousel-thumb-1200x1600-1a3698d6350b.jpg?h=128&amp"
                    },
                    new SliderModel()
                    {
                        Title = "Test 5",
                        Image = "https://cdn2.unrealengine.com/egs-farlight-84-carousel-thumb-1200x1600-1a3698d6350b.jpg?h=128&amp"
                    },
                };

                return slides;
            } 
        }

    }
}
