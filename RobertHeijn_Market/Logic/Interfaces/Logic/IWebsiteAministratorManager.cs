using Logic.Classes.Accounts.WebsiteAdminstrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Logic
{
	public interface IWebsiteAministratorManager
	{
		void SignUpAsWebsiteAdministrator(WebsiteAdministrator websiteAdministrator);
		List<WebsiteAdministrator> GetWebsiteAdministrators();
		void EditWebsiteAdministrator(WebsiteAdministrator websiteAdministrator);
		void RemoveWebsiteAdministrator(WebsiteAdministrator websiteAdministrator);
		bool LoginAsWebsiteAdministrator(string emailAddress, string password);
	}
}
