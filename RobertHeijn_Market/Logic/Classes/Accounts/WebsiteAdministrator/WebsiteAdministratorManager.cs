using Logic.Interfaces.Data;
using Logic.Interfaces.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.Accounts.WebsiteAdminstrator
{
	public class WebsiteAdministratorManager : IWebsiteAministratorManager
	{
		private IDBWebsiteAdministratorManager dBWebsiteAdministratorManager;

		public WebsiteAdministratorManager(IDBWebsiteAdministratorManager dBWebsiteAdministratorManager)
		{
			this.dBWebsiteAdministratorManager = dBWebsiteAdministratorManager;
		}

		public void EditWebsiteAdministrator(WebsiteAdministrator websiteAdministrator)
		{
			throw new NotImplementedException();
		}

		public List<WebsiteAdministrator> GetWebsiteAdministrators()
		{
			throw new NotImplementedException();
		}

		public void RemoveWebsiteAdministrator(WebsiteAdministrator websiteAdministrator)
		{
			throw new NotImplementedException();
		}

		public void SignUpAsWebsiteAdministrator(WebsiteAdministrator websiteAdministrator)
		{
			throw new NotImplementedException();
		}

		public bool LoginAsWebsiteAdministrator(string emailAddress, string password)
		{
			return dBWebsiteAdministratorManager.GetWebsiteAdministrator(emailAddress, password);
		}
	}
}
