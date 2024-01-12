using Logic.Interfaces.Data;
using Logic.Interfaces.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes.Accounts.Adminstrator
{
	public class DesktopAdministratorManager : IDesktopAdministratorManager
	{
		private IDBDesktopAdministratorManager dBDesktopAdministratorManager;

		public DesktopAdministratorManager(IDBDesktopAdministratorManager dBDesktopAdministratorManager)
		{
			this.dBDesktopAdministratorManager = dBDesktopAdministratorManager;
		}

		public void EditDesktopAdministrator(DesktopAdministrator.DesktopAdministrator desktopAdministrator)
		{
			throw new NotImplementedException();
		}

		public List<DesktopAdministrator.DesktopAdministrator> GetDesktopAdministrators()
		{
			return dBDesktopAdministratorManager.ReadAllDesktopAdministrators();
		}
		
		public void RemoveDesktopAdministrator(DesktopAdministrator.DesktopAdministrator desktopAdministrator)
		{
			throw new NotImplementedException();
		}

		public void SignUpAsDesktopAdministrator(DesktopAdministrator.DesktopAdministrator desktopAdministrator)
		{
			throw new NotImplementedException();
		}

		public bool LoginAsDesktopAdministrator(string emailAddress, string password)
		{
			return dBDesktopAdministratorManager.GetDesktopAdministrator(emailAddress, password);
		}
	}
}
