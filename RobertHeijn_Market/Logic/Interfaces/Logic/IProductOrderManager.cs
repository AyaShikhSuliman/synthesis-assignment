using Logic.Classes.Orders;
using Logic.Classes.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Classes.ProductOrder;

namespace Logic.Interfaces.Logic
{
    public interface IProductOrderManager
    {
        void AddProductToOrder(ProductOrder productOrder, int cartId);
        void EditProductOrder(ProductOrder productOrder, int orderId);
        void RemoveProduct(int productId, int orderId);
        ProductOrder GetProductOrder(int orderId, int productId);
        double CalculateOrderTotalPrice(int orderId);
    }
}
