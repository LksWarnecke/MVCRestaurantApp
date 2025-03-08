namespace MVCRestaurantApp.Models
{
	public class OrderViewModel //for the view/ front-end
	{
		public decimal TotalAmount { get; set; }
		public List<OrderItemViewModel> OrderItems { get; set; }
		public IEnumerable<Product> Products { get; set; }
	}
}
