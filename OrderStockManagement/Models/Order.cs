namespace OrderStockManagement.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public float TotalPrice { get; set; }
        public string OrderStatus { get; set; }
    }
}
