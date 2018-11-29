using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Service
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginWindow login = new LoginWindow();
            Application.Run(login);
            if (login.active != null)
            {
                switch (login.active.role)
                {
                    case "adm":
                        Application.Run(new AdminWindow());
                        break;
                    case "wor":
                        Application.Run(new WorkerWindow());
                        break;
                    case "man":
                        Application.Run(new ManagerWindow());
                        break;
                    default:
                        MessageBox.Show("Błedna rola użytkowanika prosze skotaktować się z administratorem.");
                        break;
                }
            }       
        }
    }
}
