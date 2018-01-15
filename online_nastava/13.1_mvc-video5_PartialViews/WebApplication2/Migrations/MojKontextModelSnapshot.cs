﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using WebApplication2.Models;

namespace WebApplication2.Migrations
{
    [DbContext(typeof(MojKontext))]
    partial class MojKontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication2.Models.Grad", b =>
                {
                    b.Property<int>("GradID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv");

                    b.HasKey("GradID");

                    b.ToTable("gradovi");
                });

            modelBuilder.Entity("WebApplication2.Models.Ocjene", b =>
                {
                    b.Property<int>("OcjeneID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("StudentID");

                    b.Property<int>("Vrijednost");

                    b.Property<string>("VrijednostOpisna");

                    b.Property<DateTime>("datum");

                    b.HasKey("OcjeneID");

                    b.HasIndex("StudentID");

                    b.ToTable("ocjeneStudenata");
                });

            modelBuilder.Entity("WebApplication2.Models.Student", b =>
                {
                    b.Property<int>("SudentID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<int?>("GradID");

                    b.Property<string>("Ime");

                    b.Property<string>("Index");

                    b.Property<string>("Prezime");

                    b.HasKey("SudentID");

                    b.HasIndex("GradID");

                    b.ToTable("studenti");
                });

            modelBuilder.Entity("WebApplication2.Models.Ocjene", b =>
                {
                    b.HasOne("WebApplication2.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WebApplication2.Models.Student", b =>
                {
                    b.HasOne("WebApplication2.Models.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID");
                });
#pragma warning restore 612, 618
        }
    }
}
