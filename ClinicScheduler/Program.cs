using ClinicScheduler.doctor.model;
using ClinicScheduler.doctor.service;
using ClinicScheduler.doctor.service.interfaces;
using ClinicScheduler.doctor.service.singleton;
using ClinicScheduler.forms;
using ClinicScheduler.pacient.model;
using ClinicScheduler.pacient.repository;
using ClinicScheduler.pacient.service.interfaces;
using ClinicScheduler.pacient.service.singleton;
using ClinicScheduler.programare.model;
using ClinicScheduler.programare.repository;
using ClinicScheduler.programare.service;
using ClinicScheduler.programare.service.interfaces;
using ClinicScheduler.programare.service.singleton;
using ClinicScheduler.serviciu.model;
using ClinicScheduler.serviciu.service.interfaces;
using ClinicScheduler.serviciu.service.singleton;
using ClinicScheduler.user.model;
using ClinicScheduler.user.repository;
using ClinicScheduler.user.service;
using ClinicScheduler.user.service.interfaces;
using ClinicScheduler.user.service.singleton;
using FluentMigrator.Runner.Initialization;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConfigurationBuilder = Microsoft.Extensions.Configuration.ConfigurationBuilder;

namespace ClinicScheduler
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmMain());



            IProgramareCommandService a = ProgramareCommandServiceSingleton.Instance;
            IProgramareQueryService b = ProgramareQueryServiceSingleton.Instance;

            Programare programare = Programare.ProgramareBuild()
               .setId(1)
               .setPacientId(6)
               .setDoctorId(3)
               .setDataInceput(new DateTime(2020, 3, 21))
               .setDataSfarsit(new DateTime(2020, 3, 25));

          // a.Add(programare);

            Programare pr=b.GetById(2);

            Debug.WriteLine(pr.ToString());

            //foreach (Programare pr in b.GetAllProgramari())
            //{
            //    Debug.WriteLine(pr.ToString());
            //}



        }



    }
}
