﻿// <auto-generated />
using DbCwithLINKQ.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DbCwithLINKQ.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DbCwithLINKQ.Model.Class", b =>
                {
                    b.Property<int>("Cid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Cid"), 1L, 1);

                    b.Property<int>("FacultyFid")
                        .HasColumnType("int");

                    b.Property<int>("Fid")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.HasKey("Cid");

                    b.HasIndex("FacultyFid");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("DbCwithLINKQ.Model.Enrolled", b =>
                {
                    b.Property<int>("Cid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Cid"), 1L, 1);

                    b.Property<int>("Ci")
                        .HasColumnType("int");

                    b.Property<int>("ClassCid")
                        .HasColumnType("int");

                    b.Property<int>("Sid")
                        .HasColumnType("int");

                    b.Property<int>("StudentSid")
                        .HasColumnType("int");

                    b.HasKey("Cid");

                    b.HasIndex("ClassCid");

                    b.HasIndex("StudentSid");

                    b.ToTable("Enrolled");
                });

            modelBuilder.Entity("DbCwithLINKQ.Model.Faculty", b =>
                {
                    b.Property<int>("Fid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Fid"), 1L, 1);

                    b.Property<int>("Deptid")
                        .HasColumnType("int");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Standing")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Fid");

                    b.ToTable("Faculty");
                });

            modelBuilder.Entity("DbCwithLINKQ.Model.Student", b =>
                {
                    b.Property<int>("Sid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Sid"), 1L, 1);

                    b.Property<string>("Major")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Standing")
                        .HasColumnType("int");

                    b.HasKey("Sid");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("DbCwithLINKQ.Model.Class", b =>
                {
                    b.HasOne("DbCwithLINKQ.Model.Faculty", "Faculty")
                        .WithMany("Classes")
                        .HasForeignKey("FacultyFid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("DbCwithLINKQ.Model.Enrolled", b =>
                {
                    b.HasOne("DbCwithLINKQ.Model.Class", "Class")
                        .WithMany("Enrollments")
                        .HasForeignKey("ClassCid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DbCwithLINKQ.Model.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentSid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("DbCwithLINKQ.Model.Class", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("DbCwithLINKQ.Model.Faculty", b =>
                {
                    b.Navigation("Classes");
                });

            modelBuilder.Entity("DbCwithLINKQ.Model.Student", b =>
                {
                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
