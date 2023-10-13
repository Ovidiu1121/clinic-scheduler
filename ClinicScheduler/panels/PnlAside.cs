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
    public class PnlAside:Panel
    {
        private Label lblprogramari;
        private Button btnaddprogramare;
        private Button btnstergeprogramare;
        private Button btnmodificaprogramare;
        private Button btngasesteprogramare;
        private Button btnacasa;
        private Button btnprogramari;
        private Button btnplati;
        private Button btnfacturi;
        private Button btnsetari;
        private Button btnpacienti;
        private Button btnrapoarte;
        private FrmMain frmMain;

        public PnlAside(FrmMain frmMain)
        {
            this.frmMain = frmMain;
            this.Size=new Size(206, 683);
            this.BackColor=Color.LightSteelBlue;

            this.lblprogramari=new Label();
            this.Controls.Add(this.lblprogramari);
            this.lblprogramari.Location=new Point(3, 70);
            this.lblprogramari.Size=new Size(143, 29);
            this.lblprogramari.Text="Programari";
            this.lblprogramari.Font=new Font("Arial", 14, FontStyle.Bold);

            this.btnaddprogramare=new Button();
            this.Controls.Add(this.btnaddprogramare);
            this.btnaddprogramare.Location=new Point(16, 114);
            this.btnaddprogramare.Size=new Size(159, 26);
            this.btnaddprogramare.Text="Adauga programare";
            this.btnaddprogramare.FlatAppearance.BorderSize=0;
            this.btnaddprogramare.FlatStyle=FlatStyle.Flat;
            this.btnaddprogramare.TextAlign=ContentAlignment.MiddleLeft;

            this.btnmodificaprogramare=new Button();
            this.Controls.Add(this.btnmodificaprogramare);
            this.btnmodificaprogramare.Location=new Point(16, 146);
            this.btnmodificaprogramare.Size=new Size(159, 26);
            this.btnmodificaprogramare.Text="Modifica programare";
            this.btnmodificaprogramare.FlatAppearance.BorderSize=0;
            this.btnmodificaprogramare.FlatStyle=FlatStyle.Flat;
            this.btnmodificaprogramare.TextAlign=ContentAlignment.MiddleLeft;

            this.btnstergeprogramare=new Button();
            this.Controls.Add(this.btnstergeprogramare);
            this.btnstergeprogramare.Location=new Point(16, 178);
            this.btnstergeprogramare.Size=new Size(159, 26);
            this.btnstergeprogramare.Text="Sterge programare";
            this.btnstergeprogramare.FlatAppearance.BorderSize=0;
            this.btnstergeprogramare.FlatStyle=FlatStyle.Flat;
            this.btnstergeprogramare.TextAlign=ContentAlignment.MiddleLeft;

            this.btngasesteprogramare=new Button();
            this.Controls.Add(this.btngasesteprogramare);
            this.btngasesteprogramare.Location=new Point(16, 210);
            this.btngasesteprogramare.Size=new Size(159, 26);
            this.btngasesteprogramare.Text="Gaseste programare";
            this.btngasesteprogramare.FlatAppearance.BorderSize=0;
            this.btngasesteprogramare.FlatStyle=FlatStyle.Flat;
            this.btngasesteprogramare.TextAlign=ContentAlignment.MiddleLeft;

            this.btnacasa=new Button();
            this.Controls.Add(this.btnacasa);
            this.btnacasa.Location=new Point(0, 342);
            this.btnacasa.Size=new Size(206, 40);
            this.btnacasa.Text="Acasa";
            this.btnacasa.FlatAppearance.BorderSize=1;
            this.btnacasa.FlatStyle=FlatStyle.Flat;
            this.btnacasa.TextAlign=ContentAlignment.MiddleLeft;
            this.btnacasa.Font=new Font("Arial", 10, FontStyle.Regular);

            this.btnprogramari=new Button();
            this.Controls.Add(this.btnprogramari);
            this.btnprogramari.Location=new Point(0, 382);
            this.btnprogramari.Size=new Size(206, 40);
            this.btnprogramari.Text="Programari";
            this.btnprogramari.FlatAppearance.BorderSize=1;
            this.btnprogramari.FlatStyle=FlatStyle.Flat;
            this.btnprogramari.TextAlign=ContentAlignment.MiddleLeft;
            this.btnprogramari.Font=new Font("Arial", 10, FontStyle.Regular);

            this.btnpacienti=new Button();
            this.Controls.Add(this.btnpacienti);
            this.btnpacienti.Location=new Point(0, 422);
            this.btnpacienti.Size=new Size(206, 40);
            this.btnpacienti.Text="Pacienti";
            this.btnpacienti.FlatAppearance.BorderSize=1;
            this.btnpacienti.FlatStyle=FlatStyle.Flat;
            this.btnpacienti.TextAlign=ContentAlignment.MiddleLeft;
            this.btnpacienti.Font=new Font("Arial", 10, FontStyle.Regular);

            this.btnpacienti=new Button();
            this.Controls.Add(this.btnpacienti);
            this.btnpacienti.Location=new Point(0, 462);
            this.btnpacienti.Size=new Size(206, 40);
            this.btnpacienti.Text="Pacienti";
            this.btnpacienti.FlatAppearance.BorderSize=1;
            this.btnpacienti.FlatStyle=FlatStyle.Flat;
            this.btnpacienti.TextAlign=ContentAlignment.MiddleLeft;
            this.btnpacienti.Font=new Font("Arial", 10, FontStyle.Regular);

            this.btnplati=new Button();
            this.Controls.Add(this.btnplati);
            this.btnplati.Location=new Point(0, 502);
            this.btnplati.Size=new Size(206, 40);
            this.btnplati.Text="Plati";
            this.btnplati.FlatAppearance.BorderSize=1;
            this.btnplati.FlatStyle=FlatStyle.Flat;
            this.btnplati.TextAlign=ContentAlignment.MiddleLeft;
            this.btnplati.Font=new Font("Arial", 10, FontStyle.Regular);

            this.btnrapoarte=new Button();
            this.Controls.Add(this.btnrapoarte);
            this.btnrapoarte.Location=new Point(0, 542);
            this.btnrapoarte.Size=new Size(206, 40);
            this.btnrapoarte.Text="Rapoarte";
            this.btnrapoarte.FlatAppearance.BorderSize=1;
            this.btnrapoarte.FlatStyle=FlatStyle.Flat;
            this.btnrapoarte.TextAlign=ContentAlignment.MiddleLeft;
            this.btnrapoarte.Font=new Font("Arial", 10, FontStyle.Regular);

            this.btnfacturi=new Button();
            this.Controls.Add(this.btnfacturi);
            this.btnfacturi.Location=new Point(0, 582);
            this.btnfacturi.Size=new Size(206, 40);
            this.btnfacturi.Text="Facturi";
            this.btnfacturi.FlatAppearance.BorderSize=1;
            this.btnfacturi.FlatStyle=FlatStyle.Flat;
            this.btnfacturi.TextAlign=ContentAlignment.MiddleLeft;
            this.btnfacturi.Font=new Font("Arial", 10, FontStyle.Regular);

            this.btnsetari=new Button();
            this.Controls.Add(this.btnsetari);
            this.btnsetari.Location=new Point(0, 622);
            this.btnsetari.Size=new Size(206, 40);
            this.btnsetari.Text="Setari";
            this.btnsetari.FlatAppearance.BorderSize=1;
            this.btnsetari.FlatStyle=FlatStyle.Flat;
            this.btnsetari.TextAlign=ContentAlignment.MiddleLeft;
            this.btnsetari.Font=new Font("Arial", 10, FontStyle.Regular);

        }


    }
}
