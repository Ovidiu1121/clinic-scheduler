using ClinicScheduler.forms;
using ClinicScheduler.user.model;
using ClinicScheduler.user.service;
using ClinicScheduler.user.service.interfaces;
using ClinicScheduler.user.service.singleton;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicScheduler.panels
{
    public class PnlPatientsPage:Panel
    {
        private DataGridView datagridview;
        private FrmMain frmMain;

        public PnlPatientsPage(FrmMain frmMain)
        {
            this.frmMain = frmMain;
            this.Size=new Size(1168, 693);
            this.Location=new Point(206, 76);

            this.datagridview=new DataGridView();
            this.Controls.Add(datagridview);
            this.datagridview.Location=new Point(20, 0);
            this.datagridview.Size = new Size(1126, 550);

            populate();


        }

        public void populate()
        {

            DataTable table=new DataTable();

            table.Columns.Add("ID",typeof(int));
            table.Columns.Add("Name",typeof(string));
            table.Columns.Add("Password",typeof (string));
            table.Columns.Add("Is Patient",typeof(string));
            table.Columns.Add("Status",typeof (string));

            //UserCommandService service = UserCommandServiceSingleton.Instance;

            IUserCommandService service = new UserCommandService();

            List<User> users =service.GetAllUsers();

            foreach (User user in users)
            {
                table.Rows.Add(user.Id,user.Nume,user.Parola,"Yes","Active");
            }

            this.datagridview.DataSource = table;
        }




    }
}
