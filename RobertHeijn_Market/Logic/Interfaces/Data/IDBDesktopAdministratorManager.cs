using Logic.Classes.Accounts.DesktopAdministrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Data
{
	public interface IDBDesktopAdministratorManager
	{
		void CreateDesktopAdministrator(DesktopAdministrator desktopAdministrator);
		List<DesktopAdministrator> ReadAllDesktopAdministrators();
		void UpdateDesktopAdministrator(DesktopAdministrator desktopAdministrator);
		void DeleteDesktopAdministrator(DesktopAdministrator desktopAdministrator);
		bool GetDesktopAdministrator(string emailAddress, string password);
	}
}
