﻿using ClinicScheduler.forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicScheduler.panels
{
    internal class PnlLogIn:Panel
    {
        private Label lbltitlu;
        private Label lblnume;
        private Label lblparola;
        private TextBox txtnume;
        private TextBox txtparola;
        private Button btnlogin;
        private Button btnregister;
        private FrmHome frmHome;

        public PnlLogIn(FrmHome frmHome)
        {
            this.frmHome = frmHome;
            this.Size=new Size(818, 497);

            this.lbltitlu = new Label();
            this.Controls.Add(this.lbltitlu);
            this.lbltitlu.Location=new Point(350, 80);
            this.lbltitlu.Size=new Size(121, 42);
            this.lbltitlu.Text ="Log In";
            this.lbltitlu.Font=new Font("Arial", 22, FontStyle.Regular);
           
            this.lblnume = new Label();
            this.Controls.Add(this.lblnume);
            this.lblnume.Location=new Point(172, 170);
            this.lblnume.Size=new Size(64, 25);
            this.lblnume.Text ="Nume";
            this.lblnume.Font=new Font("Arial", 12, FontStyle.Regular);

            this.lblparola = new Label();
            this.Controls.Add(this.lblparola);
            this.lblparola.Location=new Point(172, 219);
            this.lblparola.Size=new Size(68, 25);
            this.lblparola.Text ="Parola";
            this.lblparola.Font=new Font("Arial", 12, FontStyle.Regular);

            this.txtnume=new TextBox();
            this.Controls.Add(this.txtnume);
            this.txtnume.Location=new Point(270, 170);
            this.txtnume.Size = new Size(333, 22);

            this.txtparola=new TextBox();
            this.Controls.Add(this.txtparola);
            this.txtparola.Location=new Point(270, 222);
            this.txtparola.Size = new Size(333, 22);

            this.btnlogin=new Button();
            this.Controls.Add(this.btnlogin);
            this.btnlogin.Location=new Point(341, 274);
            this.btnlogin.Size=new Size(114, 30);
            this.btnlogin.Text="Log In";
            this.btnlogin.Font=new Font("Arial", 10, FontStyle.Regular);

            this.btnregister=new Button();
            this.Controls.Add(this.btnregister);
            this.btnregister.Location=new Point(341, 310);
            this.btnregister.Size=new Size(114, 30);
            this.btnregister.Text="Register";
            this.btnregister.Font=new Font("Arial", 10, FontStyle.Regular);

        }

    }
}
