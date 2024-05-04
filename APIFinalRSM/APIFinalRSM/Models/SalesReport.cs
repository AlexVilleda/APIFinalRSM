namespace APIFinalRSM.Models
{
    public class SalesReport
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        // ... other properties as defined in the requirements
        public string SalesPersonName { get; set; }
        public string ShippingAddress { get; set; }
        public string BillingAddress { get; set; }
        public string ProductCategory { get; internal set; }
    }
}
