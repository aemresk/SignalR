namespace SignalR.EntityLayer.Entities
{
    public class Discount
    {
        public int DiscountId { get; set; }
        public string Title { get; set; }
        public string Amount { get; set; } // miktar 
        public string ImageURL { get; set; }
        public string Description { get; set; }

    }
}
