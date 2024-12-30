namespace OrderStockManagement.Models
{
    public class Customer
    {


        private float _budget; // Private değişken
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public float Budget
        {
            get => _budget;
            set
            {
                // Budget sıfırın altına düşerse otomatik olarak sıfır yapılıyor
                if (value < 0)
                {
                    _budget = 0;
                }
                else
                {
                    _budget = value;
                }
            }
        }
        public string CustomerType { get; set; } // Premium or Standard
        public float TotalSpent { get; set; }

        public int PriorityScore { get; set; } // Dinamik öncelik skoru
    }
}
