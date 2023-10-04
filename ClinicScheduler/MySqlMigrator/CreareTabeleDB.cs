
using FluentMigrator;

namespace ClinicScheduler.MySqlMigrator
{
    [Migration(1695263542)] // Use a unique timestamp as the version
    public class CreareTabeleDB : Migration
    {
        public override void Down()
        {
            Create.Table("user")
                .WithColumn("id").AsInt32().PrimaryKey().Identity()
                .WithColumn("nume").AsString(255)
                .WithColumn("parola").AsString(255)
                .WithColumn("tip").AsInt32();

            Create.Table("doctor")
                 .WithColumn("id").AsInt32().PrimaryKey().Identity()
                 .WithColumn("nume").AsString(255)
                .WithColumn("parola").AsString(255)
                .WithColumn("id_clinica").AsString(255).ForeignKey("clinica", "id")
                .WithColumn("telefon").AsInt32();

            Create.Table("pacient")
                .WithColumn("id").AsInt32().PrimaryKey().Identity()
                .WithColumn("nume").AsString(255)
                .WithColumn("parola").AsString(255)
                .WithColumn("dob").AsDateTime()
                .WithColumn("telefon").AsInt32();

            Create.Table("programare")
                .WithColumn("id").AsInt32().PrimaryKey().Identity()
                .WithColumn("id_pacient").AsInt32().ForeignKey("pacient", "id")
                .WithColumn("id_doctor").AsInt32().ForeignKey("doctor", "id")
                .WithColumn("data_inceput").AsDateTime()
                .WithColumn("data_sfarsit").AsDateTime();
        }

        public override void Up()
        {
            Delete.Table("user");
            Delete.Table("pacient");
            Delete.Table("doctor");
            Delete.Table("programare");
            Delete.Table("clinica");
            Delete.Table("servicii");
        }
    }
}
