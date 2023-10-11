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
    public class PnlRegister:Panel
    {
        private Label lbltitlu;
        private Label lblnume;
        private Label lblprenume;
        private Label lbltip;
        private TextBox txtnume;
        private TextBox txtprenume;
        private TextBox txttip;
        private Button btnregister;
        private Button btncancel;
        private FrmHome frmHome;

        public PnlRegister(FrmHome frmHome)
        {
            this.frmHome = frmHome;
            this.Size=new Size(818, 497);

            this.lbltitlu = new Label();
            this.Controls.Add(this.lbltitlu);
            this.lbltitlu.Location=new Point(320, 71);
            this.lbltitlu.Size=new Size(157, 42);
            this.lbltitlu.Text ="Register";
            this.lbltitlu.Font=new Font("Arial", 22, FontStyle.Regular);

            this.lblnume = new Label();
            this.Controls.Add(this.lblnume);
            this.lblnume.Location=new Point(146, 161);
            this.lblnume.Size=new Size(64, 25);
            this.lblnume.Text ="Nume";
            this.lblnume.Font=new Font("Arial", 12, FontStyle.Regular);

            this.lblprenume = new Label();
            this.Controls.Add(this.lblprenume);
            this.lblprenume.Location=new Point(146, 209);
            this.lblprenume.Size=new Size(91, 25);
            this.lblprenume.Text ="Prenume";
            this.lblprenume.Font=new Font("Arial", 12, FontStyle.Regular);

            this.lbltip = new Label();
            this.Controls.Add(this.lbltip);
            this.lbltip.Location=new Point(146, 260);
            this.lbltip.Size=new Size(40, 25);
            this.lbltip.Text ="Tip";
            this.lbltip.Font=new Font("Arial", 12, FontStyle.Regular);

            this.txtnume=new TextBox();
            this.Controls.Add(this.txtnume);
            this.txtnume.Location=new Point(266, 165);
            this.txtnume.Size = new Size(320, 22);

            this.txtprenume=new TextBox();
            this.Controls.Add(this.txtprenume);
            this.txtprenume.Location=new Point(266, 213);
            this.txtprenume.Size = new Size(320, 22);

            this.txttip=new TextBox();
            this.Controls.Add(this.txttip);
            this.txttip.Location=new Point(266, 263);
            this.txttip.Size = new Size(320, 22);

            this.btnregister=new Button();
            this.Controls.Add(this.btnregister);
            this.btnregister.Location=new Point(300, 320);
            this.btnregister.Size=new Size(150, 35);
            this.btnregister.Text="Register";
            this.btnregister.Font=new Font("Arial", 10, FontStyle.Regular);

            this.btncancel=new Button();
            this.Controls.Add(this.btncancel);
            this.btncancel.Location=new Point(300, 361);
            this.btncancel.Size=new Size(150, 35);
            this.btncancel.Text="Cancel";
            this.btncancel.Font=new Font("Arial", 10, FontStyle.Regular);
        }



    }
}
