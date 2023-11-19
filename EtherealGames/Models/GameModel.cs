namespace EtherealGames.Models
{
    public class GameModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        public string SmallImageUrl { get; set; }
        public bool IsMainSlider { get; set; }
    }
}
