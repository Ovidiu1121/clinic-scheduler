using ClinicScheduler.forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicScheduler.panels
{
    public class PnlHeader:Panel
    {
        private Label lblcurrentdate;
        private Label lbltitlu;
        private FrmMain frmMain;
        public PnlHeader(FrmMain frmMain)
        {
            this.frmMain = frmMain;
            this.Size=new Size(1376, 50);
            this.BackColor = Color.LightGray;

            this.lbltitlu=new Label();
            this.Controls.Add(this.lbltitlu);
            this.lbltitlu.Location=new Point(65, 7);
            this.lbltitlu.Size=new Size(142, 40);
            this.lbltitlu.Text ="Polisano";
            this.lbltitlu.Font=new Font("Segoe Print", 14, FontStyle.Bold);

            this.lblcurrentdate=new Label();
            this.Controls.Add(this.lblcurrentdate);
            this.lblcurrentdate.Location=new Point(1250, 4);
            this.lblcurrentdate.Size=new Size(120, 50);
            this.lblcurrentdate.Text =DateTime.Now.ToString();
            this.lblcurrentdate.Font=new Font("Arial", 14, FontStyle.Bold);

        }

    }
}
