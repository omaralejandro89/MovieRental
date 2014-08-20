namespace GoToEat.Core.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public virtual int RestaurantId { get; set; }
        public string Reviewer { get; set; }
        public int Rating { get; set; }
        public string Body { get; set; }

    }
}
