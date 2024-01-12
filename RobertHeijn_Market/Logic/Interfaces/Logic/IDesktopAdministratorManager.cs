using Logic.Classes.Accounts.DesktopAdministrator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Interfaces.Logic
{
	public interface IDesktopAdministratorManager
	{
		void SignUpAsDesktopAdministrator(DesktopAdministrator desktopAdministrator);
		List<DesktopAdministrator> GetDesktopAdministrators();
		void EditDesktopAdministrator(DesktopAdministrator desktopAdministrator);
		void RemoveDesktopAdministrator(DesktopAdministrator desktopAdministrator);
		bool LoginAsDesktopAdministrator(string emailAddress, string password);
	}
}
