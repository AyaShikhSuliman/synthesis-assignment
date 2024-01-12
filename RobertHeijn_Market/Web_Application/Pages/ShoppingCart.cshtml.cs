using Data;
using Logic.Classes.Accounts.Customer;
using Logic.Classes.Orders;
using Logic.Classes.ProductOrder;
using Logic.Classes.Products;
using Logic.Interfaces.Logic;
using Logic.Interfaces.Logic.Orders;
using Logic.Interfaces.Logic.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web_Application.Pages
{
    public class ShoppingCartModel : PageModel
    {
        [BindProperty]
        public List<ProductOrder> productOrders { get; set; }
        public int CustomerID { get; set; }
        [BindProperty]
        public int ProductId { get; set; }
        [BindProperty]
        public double OrderTotalPrice { get; set; }

        private ICustomerOrderManager customerOrderManager = new OrderManager(new DBOrderManager(), new DBCustomerManager());
        private ICustomerProductManager customerProductManager = new ProductManager(new DBProductManager());
        private IProductOrderManager productOrderManager = new ProductOrderManager(new DBProductOrderManage());

        public void OnGet()
        {
            try
            {
                CustomerID = HttpContext.Session.GetInt32("CustomerID").Value;
                Order cart = customerOrderManager.GetCart(CustomerID);
                productOrders = cart.ProductOrder;

                OrderTotalPrice = productOrderManager.CalculateOrderTotalPrice(cart.Id);
                cart.TotalOrderPrice = OrderTotalPrice;
                customerOrderManager.AddOrderTotalPrice(cart);
            }
            catch
            {
                Response.Redirect("/LogIn");
            }
        }

        public void OnPostDeleteProduct()
        {
            CustomerID = HttpContext.Session.GetInt32("CustomerID").Value;
            int cartId = customerOrderManager.GetCartId(CustomerID);
            productOrderManager.RemoveProduct(ProductId, cartId);
            OnGet();
        }
    }
}
