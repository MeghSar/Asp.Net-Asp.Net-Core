// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TimeSheetManagement.DAL.Data;

namespace TimeSheetManagement.DAL.Migrations
{
    [DbContext(typeof(TimeSheetDBContext))]
    [Migration("20220206181414_UpdatedModels")]
    partial class UpdatedModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TimeSheetManagement.Entity.Models.Employee", b =>
                {
                    b.Property<int>("EmpID")
                        .HasColumnType("int");

                    b.Property<int>("CurrentProjectID")
                        .HasColumnType("int");

                    b.Property<string>("EmpDOJ")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpDesig")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpEmailID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpPsw")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmpUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MgrID")
                        .HasColumnType("int");

                    b.HasKey("EmpID");

                    b.ToTable("employee");
                });

            modelBuilder.Entity("TimeSheetManagement.Entity.Models.Project", b =>
                {
                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.Property<string>("ProjectDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectID");

                    b.ToTable("project");
                });

            modelBuilder.Entity("TimeSheetManagement.Entity.Models.TimeSheet", b =>
                {
                    b.Property<int>("TimeSheetID")
                        .HasColumnType("int");

                    b.Property<int>("EmpID")
                        .HasColumnType("int");

                    b.Property<decimal>("Hours")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeFrom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeTo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TimeSheetID");

                    b.HasIndex("EmpID");

                    b.HasIndex("ProjectID");

                    b.ToTable("timesheet");
                });

            modelBuilder.Entity("TimeSheetManagement.Entity.Models.TimeSheet", b =>
                {
                    b.HasOne("TimeSheetManagement.Entity.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmpID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TimeSheetManagement.Entity.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Project");
                });
#pragma warning restore 612, 618
        }
    }
}
