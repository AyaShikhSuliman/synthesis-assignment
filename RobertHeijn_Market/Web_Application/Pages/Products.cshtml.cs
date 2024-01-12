using Data;
using Logic.Classes;
using Logic.Classes.Accounts.Customer;
using Logic.Classes.Orders;
using Logic.Classes.ProductOrder;
using Logic.Classes.Products;
using Logic.Interfaces.Data;
using Logic.Interfaces.Logic;
using Logic.Interfaces.Logic.Customers;
using Logic.Interfaces.Logic.Orders;
using Logic.Interfaces.Logic.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Web_Application.Pages.Shared;

namespace Web_Application.Pages
{
    public class ProductsModel : PageModel
    {
        [BindProperty]
        public List<Product> products { get; set; }
        [BindProperty]
        public double productNewPrice { get; set; }
        [BindProperty]
        public int Quantity { get; set; }
        [BindProperty]
        public int productId { get; set; }
        [BindProperty]
        public int CustomerID { get; set; }

        private ICustomerProductManager customerProductManager = new ProductManager(new DBProductManager());
        private ICustomerManager customerManager = new CustomerManager(new DBCustomerManager());
        private ICustomerOrderManager customerOrderManager = new OrderManager(new DBOrderManager(), new DBCustomerManager());
        private IProductOrderManager productOrderManager = new ProductOrderManager(new DBProductOrderManage());

        public void OnGet()
        {
            products = customerProductManager.GetProducts();
        }

        public void OnPost()
        {
            try
            {
                CustomerID = HttpContext.Session.GetInt32("CustomerID").Value;

                if (customerOrderManager.GetCart(CustomerID) != null)
                {
                    Order order = customerOrderManager.GetCart(CustomerID);
                    Product product = customerProductManager.GetProductByID(productId);

                    if (productOrderManager.GetProductOrder(order.Id, productId) != null)
                    {
                        ProductOrder productOrder = productOrderManager.GetProductOrder(order.Id, productId);

                        if (productOrder.Product.Id == productId)
                        {
                            productOrder.Quantity = Quantity;
                            productOrder.Price = productNewPrice;

                            productOrderManager.EditProductOrder(productOrder, order.Id);

                            OnGet();

                            return;
                        }
                    }
                    else
                    {
                        ProductOrder productOrder2 = new ProductOrder(product, Quantity, productNewPrice);
                        order.ProductOrder.Add(productOrder2);

                        productOrderManager.AddProductToOrder(productOrder2, order.Id);

                        OnGet();

                        return;
                    }
                }
                else
                {
                    DateTime thisDay = DateTime.Today;

                    Product product = customerProductManager.GetProductByID(productId);

                    ProductOrder productOrder = new ProductOrder(product, Quantity, productNewPrice);
                    List<ProductOrder> productOrders = new List<ProductOrder>();
                    productOrders.Add(productOrder);

                    Order order = new Order(0, thisDay.ToString(), productOrders);

                    customerOrderManager.CreateCart(order, CustomerID);

                    int cartId = customerOrderManager.GetCartId(CustomerID);
                    productOrderManager.AddProductToOrder(productOrder, cartId);

                    OnGet();

                    return;
                }
            }
            catch
            {
                Response.Redirect("/LogIn");
            }
        }
    }
}
