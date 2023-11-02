using ClinicScheduler.doctor.model;
using ClinicScheduler.doctor.service;
using ClinicScheduler.doctor.service.interfaces;
using ClinicScheduler.doctor.service.singleton;
using ClinicScheduler.forms;
using ClinicScheduler.pacient.model;
using ClinicScheduler.pacient.service;
using ClinicScheduler.pacient.service.singleton;
using ClinicScheduler.programare.model;
using ClinicScheduler.programare.service;
using ClinicScheduler.programare.service.interfaces;
using ClinicScheduler.programare.service.singleton;
using ClinicScheduler.serviciu.model;
using ClinicScheduler.serviciu.service;
using ClinicScheduler.serviciu.service.interfaces;
using ClinicScheduler.serviciu.service.singleton;
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
    public class PnlAppointmentsPage:Panel
    {
        private DataGridView datagridview;
        private FrmMain frmMain;

        public PnlAppointmentsPage(FrmMain frmMain)
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
            DataTable table = new DataTable();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Nume Pacient", typeof(string));
            table.Columns.Add("Doctor", typeof(string));
            table.Columns.Add("Serviciu", typeof(string));
            table.Columns.Add("Data Inceput", typeof(DateTime));
            table.Columns.Add("Data Sfarsit", typeof(DateTime));

            ProgramareQueryService programareservice = new ProgramareQueryService();
            PacientQueryService pacientservice = PacientQueryServiceSingleton.Instance;
            DoctorQueryService doctorservice = DoctorQueryServiceSingleton.Instance;
            ServiciuQueryService serviciuservice = ServiciuQueryServiceSingleton.Instance;

            List<Programare> programari = programareservice.GetAllProgramari();

            foreach (Programare programare in programari)
            {
                Pacient pacient= pacientservice.GetById(programare.PacientId);
                Doctor doctor=doctorservice.GetById(programare.DoctorId);
                Serviciu serviciu = serviciuservice.GetById(programare.ServiciuId);
                table.Rows.Add(programare.Id, pacient.Nume,doctor.Nume,serviciu.Nume,programare.DataInceput,programare.DataSfarsit);
            }

            this.datagridview.DataSource = table;
        }

    }
}
