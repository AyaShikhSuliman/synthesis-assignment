using Logic.Classes.Orders;
using Logic.Classes.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Classes.ProductOrder;

namespace Logic.Interfaces.Data
{
    public interface IDBProductOrderManager
    {
        void CreateAProductOrder(ProductOrder productOrder, int cartId);
        void UpdateProductOrder(ProductOrder productOrder, int orderId);
        void DeleteProductOrder(int productId, int orderId);
        ProductOrder ReadProductOrder(int orderId, int productId);
        double ReadOrderTotalPrice(int orderId);
    }
}
