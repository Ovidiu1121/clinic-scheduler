using ClinicScheduler.doctor.model;
using ClinicScheduler.forms;
using ClinicScheduler.programare.model;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());

            //string c = Directory.GetCurrentDirectory();
            //IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(c).AddJsonFile("appsettings.json").Build();
            //string connectionStringIs = configuration.GetConnectionString("Default");

            //string connectionString = connectionStringIs;

            //using (var runner = new RunnerContext())
            //{
            //    runner.MigrateUp(connectionString);
            //}

            //IUserQueryService a=new UserQueryService();

            //User user = a.GetByNume("Ana");
            //User expected = new User(1, "Ana", "parola1", 1);

            //Debug.WriteLine(user.ToString());

        }

        

    }
}
