using Logic.Classes.Orders;
using Logic.Classes.Products;
using Logic.Interfaces.Data;
using Logic.Interfaces.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.ProductOrder
{
    public class ProductOrderManager : IProductOrderManager
    {
        private IDBProductOrderManager dBProductOrderManager;

        public ProductOrderManager(IDBProductOrderManager dBProductOrderManager)
        {
            this.dBProductOrderManager = dBProductOrderManager;
        }

        public void AddProductToOrder(ProductOrder productOrder, int cartId)
        {
            dBProductOrderManager.CreateAProductOrder(productOrder, cartId);
        }

        public void EditProductOrder(ProductOrder productOrder, int orderId)
        {
            dBProductOrderManager.UpdateProductOrder(productOrder, orderId);    
        }

        public void RemoveProduct(int productId, int orderId)
        {
            dBProductOrderManager.DeleteProductOrder(productId, orderId);
        }

        public ProductOrder GetProductOrder(int orderId, int productId)
        {
            return dBProductOrderManager.ReadProductOrder(productId, orderId);
        }

        public double CalculateOrderTotalPrice(int orderId)
        {
            return dBProductOrderManager.ReadOrderTotalPrice(orderId);
        }
    }
}
