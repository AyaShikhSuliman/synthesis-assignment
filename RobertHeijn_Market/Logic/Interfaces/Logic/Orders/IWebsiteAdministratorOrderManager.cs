using Logic.Classes.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Logic.Orders
{
	public interface IWebsiteAdministratorOrderManager
	{
		void UpdateOrderStatus(Order order);
	}
}
