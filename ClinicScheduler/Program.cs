using ClinicScheduler.doctor.model;
using ClinicScheduler.forms;
using ClinicScheduler.programare.model;
using ClinicScheduler.programare.repository;
using ClinicScheduler.programare.service;
using ClinicScheduler.user.model;
using ClinicScheduler.user.repository;
using ClinicScheduler.user.service;
using ClinicScheduler.user.service.interfaces;
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

            //string c = Directory.GetCurrentDirectory();
            //IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(c).AddJsonFile("appsettings.json").Build();
            //string connectionStringIs = configuration.GetConnectionString("Default");

            //string connectionString = connectionStringIs;

            //using (var runner = new RunnerContext())
            //{
            //    runner.MigrateUp(connectionString);
            //}


            ProgramareRepository a = new ProgramareRepository();
            List<Programare> programari2 = a.GetAllProgramari();

            //Programare pr = new Programare(12, 2, 18, 2, new DateTime(2020, 2, 1), new DateTime(2012, 4, 13));
            //a.Add(pr);

            foreach (Programare program in programari2)
            {
                Debug.WriteLine(program.ToString());
            }

        }

        

    }
}
