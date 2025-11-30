namespace DrumlineLessonWebApp.Models
{

    public class PricingOption
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Features { get; set; }
        public bool IsPopular { get; set; }

    }

}