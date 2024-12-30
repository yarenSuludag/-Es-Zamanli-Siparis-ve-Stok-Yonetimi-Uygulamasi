using System;

namespace OrderStockManagement.Models
{
    public class Order
    {
		public int OrderId { get; set; }
		public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; private set; }

        public Order(int customerId, int productId, int quantity)
        {
            CustomerId = customerId;
            ProductId = productId;
            Quantity = quantity;
            CreatedAt = DateTime.Now;
            
        }

        public int Priority
        {
            get
            {
                // Premium müşterilere öncelik verin ve bekleme süresini artırıcı etki olarak kullanın
                int basePriority = CustomerId % 2 == 0 ? 10 : 5; // Örnek: Premium ise 10, Standard ise 5
                int waitingTimeFactor = (int)(DateTime.Now - CreatedAt).TotalMinutes;
                return basePriority + waitingTimeFactor;
            }
        }
    }
}
