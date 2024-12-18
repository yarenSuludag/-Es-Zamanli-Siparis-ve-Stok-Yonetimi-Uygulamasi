namespace OrderStockManagement.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public float Budget { get; set; }
        public string CustomerType { get; set; } // Premium or Standard
        public float TotalSpent { get; set; }

        public int PriorityScore { get; set; } // Dinamik öncelik skoru
    }
}
