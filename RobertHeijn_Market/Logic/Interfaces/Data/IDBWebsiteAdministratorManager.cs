using Logic.Classes.Accounts.DesktopAdministrator;
using Logic.Classes.Accounts.WebsiteAdminstrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Data
{
	public interface IDBWebsiteAdministratorManager
	{
		void CreateWebsiteAdministrator(WebsiteAdministrator websiteAdministrator);
		List<WebsiteAdministrator> ReadAllWebsiteAdministrators();
		void UpdateWebsiteAdministrator(WebsiteAdministrator websiteAdministrator);
		void DeleteWebsiteAdministrator(WebsiteAdministrator websiteAdministrator);
		bool GetWebsiteAdministrator(string emailAddress, string password);
	}
}
