﻿// <auto-generated />
using eUniverzitet.Data.EF;
using eUniverzitet.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace eUniverzitet.Data.Migrations
{
    [DbContext(typeof(MojContext))]
    [Migration("20180111174106_AB")]
    partial class AB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("eUniverzitet.Data.Models.AkademskaGodina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Opis");

                    b.HasKey("Id");

                    b.ToTable("AkademskaGodinas");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.AngaziranNaPredmet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AngaziranNaPredmetTip");

                    b.Property<int>("IzvodjenjePredmetaId");

                    b.Property<int>("NastavnoOsobljeId");

                    b.HasKey("Id");

                    b.HasIndex("IzvodjenjePredmetaId");

                    b.HasIndex("NastavnoOsobljeId");

                    b.ToTable("AngaziranNaPredmets");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.IspitniRok", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AkademskaGodinaId");

                    b.Property<string>("Opis");

                    b.HasKey("Id");

                    b.HasIndex("AkademskaGodinaId");

                    b.ToTable("IspitniRoks");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.IspitniTermin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IspitniRokId");

                    b.Property<int>("IzvodjenjePredmetaId");

                    b.Property<string>("MjestoIspita");

                    b.Property<DateTime>("VrijemeIspita");

                    b.HasKey("Id");

                    b.HasIndex("IspitniRokId");

                    b.HasIndex("IzvodjenjePredmetaId");

                    b.ToTable("IspitniTermins");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.IzvodjenjePredmeta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AkademskaGodinaId");

                    b.Property<int>("PredmetId");

                    b.HasKey("Id");

                    b.HasIndex("AkademskaGodinaId");

                    b.HasIndex("PredmetId");

                    b.ToTable("IzvodjenjePredmetas");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.Korisnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ime");

                    b.Property<int?>("KorisnickaUloga");

                    b.Property<string>("KorisnickoIme");

                    b.Property<string>("Lozinka");

                    b.Property<string>("Prezime");

                    b.HasKey("Id");

                    b.ToTable("Korisniks");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.NaucnaOblast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Opis");

                    b.HasKey("Id");

                    b.ToTable("NaucnaOblasts");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.Notifikacija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsRead");

                    b.Property<int>("KorisnikId");

                    b.Property<string>("Naslov");

                    b.Property<string>("Opis");

                    b.Property<DateTime>("Vrijeme");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Notifikacijas");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.NPP", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AkademskaGodinaId");

                    b.Property<int>("FakultetId");

                    b.Property<string>("Naziv");

                    b.Property<int?>("OdsjekId");

                    b.HasKey("Id");

                    b.HasIndex("AkademskaGodinaId");

                    b.HasIndex("FakultetId");

                    b.HasIndex("OdsjekId");

                    b.ToTable("NPPs");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.Odsjek", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FakultetId");

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.HasIndex("FakultetId");

                    b.ToTable("Odsjeks");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.Opstina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Opis");

                    b.Property<int>("RegijaId");

                    b.HasKey("Id");

                    b.HasIndex("RegijaId");

                    b.ToTable("Opstinas");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.OrganizacionaJedinica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("OrganizacionaJedinicas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("OrganizacionaJedinica");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.Predmet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Ects");

                    b.Property<int>("GodinaStudija");

                    b.Property<string>("Naziv");

                    b.Property<int>("NppId");

                    b.HasKey("Id");

                    b.HasIndex("NppId");

                    b.ToTable("Predmets");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.PrijavaIspita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IspitniTerminId");

                    b.Property<DateTime?>("OdjavaDatum");

                    b.Property<DateTime>("PrijavaDatum");

                    b.Property<int>("SlusaPredmetId");

                    b.HasKey("Id");

                    b.HasIndex("IspitniTerminId");

                    b.HasIndex("SlusaPredmetId");

                    b.ToTable("PrijavaIspitas");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.Regija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("Regijas");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.SlusaPredmet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DatumOcjene");

                    b.Property<int?>("FinalnaOcjena");

                    b.Property<int>("IzvodjenjePredmetaId");

                    b.Property<bool>("Priznato");

                    b.Property<int>("UpisGodineId");

                    b.HasKey("Id");

                    b.HasIndex("IzvodjenjePredmetaId");

                    b.HasIndex("UpisGodineId");

                    b.ToTable("SlusaPredmets");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<int>("KorisnikId");

                    b.Property<int?>("KorisnikId1");

                    b.Property<int?>("OpstinaPrebivalistaId");

                    b.Property<int?>("OpstinaRodjenjaId");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("KorisnikId1");

                    b.HasIndex("OpstinaPrebivalistaId");

                    b.HasIndex("OpstinaRodjenjaId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.Studiranje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrojIndeksa");

                    b.Property<int>("NppId");

                    b.Property<int>("StudentId");

                    b.Property<int>("StudentiranjeStatus");

                    b.Property<DateTime?>("UgovorKraj");

                    b.Property<DateTime>("UgovorPocetak");

                    b.HasKey("Id");

                    b.HasIndex("NppId");

                    b.HasIndex("StudentId");

                    b.ToTable("Studiranjes");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsZatvoren");

                    b.Property<int?>("IzvodjenjePredmetaId");

                    b.Property<string>("Naslov");

                    b.Property<int>("StudiranjeId");

                    b.Property<int?>("TicketKategorijaId");

                    b.Property<int?>("ZaposlenikId");

                    b.HasKey("Id");

                    b.HasIndex("IzvodjenjePredmetaId");

                    b.HasIndex("StudiranjeId");

                    b.HasIndex("TicketKategorijaId");

                    b.HasIndex("ZaposlenikId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.TicketKategorija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Opis");

                    b.HasKey("Id");

                    b.ToTable("TicketKategorijas");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.TicketPoruka", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("KorisnikId");

                    b.Property<string>("Poruka");

                    b.Property<int>("TicketId");

                    b.Property<int?>("TicketId1");

                    b.Property<DateTime>("Vrijeme");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("TicketId");

                    b.HasIndex("TicketId1");

                    b.ToTable("TicketPorukas");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.UpisGodine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AkademskaGodinaId");

                    b.Property<float>("Cijena");

                    b.Property<DateTime?>("Datum1_ZimskiUpis");

                    b.Property<DateTime?>("Datum2_ZimskiOvjera");

                    b.Property<DateTime?>("Datum3_LjetniUpis");

                    b.Property<DateTime?>("Datum4_LjetniOvjera");

                    b.Property<int>("GodinaStudija");

                    b.Property<int>("StudiranjeId");

                    b.HasKey("Id");

                    b.HasIndex("AkademskaGodinaId");

                    b.HasIndex("StudiranjeId");

                    b.ToTable("UpisGodines");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.UplataStudija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumUplate");

                    b.Property<DateTime>("EvidentiranoDatum");

                    b.Property<int>("EvidentiranoKorisnikId");

                    b.Property<float>("Iznos");

                    b.Property<string>("Svrha");

                    b.Property<int>("UpisGodineId");

                    b.HasKey("Id");

                    b.HasIndex("EvidentiranoKorisnikId");

                    b.HasIndex("UpisGodineId");

                    b.ToTable("UplataStudijas");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.Zaposlenik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("KorisnikId");

                    b.Property<int?>("KorisnikId1");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("KorisnikId1");

                    b.ToTable("Zaposleniks");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.Zaposlenje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int>("KorisnickaUloga");

                    b.Property<int>("OrganizacionaJedinicaId");

                    b.Property<DateTime?>("UgovorKraj");

                    b.Property<DateTime>("UgovorPocetak");

                    b.Property<int>("ZaposlenikId");

                    b.Property<int>("ZaposlenjeMjestoId");

                    b.HasKey("Id");

                    b.HasIndex("OrganizacionaJedinicaId");

                    b.HasIndex("ZaposlenikId");

                    b.HasIndex("ZaposlenjeMjestoId");

                    b.ToTable("Zaposlenjes");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Zaposlenje");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.ZaposlenjeMjesto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv");

                    b.Property<int>("ZaposlenjeNacin");

                    b.HasKey("Id");

                    b.ToTable("ZaposlenjeMjestos");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.Fakultet", b =>
                {
                    b.HasBaseType("eUniverzitet.Data.Models.OrganizacionaJedinica");

                    b.Property<int>("NaucnaOblastId");

                    b.HasIndex("NaucnaOblastId");

                    b.ToTable("Fakultet");

                    b.HasDiscriminator().HasValue("Fakultet");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.Institut", b =>
                {
                    b.HasBaseType("eUniverzitet.Data.Models.OrganizacionaJedinica");


                    b.ToTable("Institut");

                    b.HasDiscriminator().HasValue("Institut");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.Rektorat", b =>
                {
                    b.HasBaseType("eUniverzitet.Data.Models.OrganizacionaJedinica");


                    b.ToTable("Rektorat");

                    b.HasDiscriminator().HasValue("Rektorat");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.NastavnoOsoblje", b =>
                {
                    b.HasBaseType("eUniverzitet.Data.Models.Zaposlenje");

                    b.Property<int>("NastavnoOsobljeZvanje");

                    b.ToTable("NastavnoOsoblje");

                    b.HasDiscriminator().HasValue("NastavnoOsoblje");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.AngaziranNaPredmet", b =>
                {
                    b.HasOne("eUniverzitet.Data.Models.IzvodjenjePredmeta", "IzvodjenjePredmeta")
                        .WithMany()
                        .HasForeignKey("IzvodjenjePredmetaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eUniverzitet.Data.Models.NastavnoOsoblje", "NastavnoOsoblje")
                        .WithMany()
                        .HasForeignKey("NastavnoOsobljeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.IspitniRok", b =>
                {
                    b.HasOne("eUniverzitet.Data.Models.AkademskaGodina", "AkademskaGodina")
                        .WithMany()
                        .HasForeignKey("AkademskaGodinaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.IspitniTermin", b =>
                {
                    b.HasOne("eUniverzitet.Data.Models.IspitniRok", "IspitniRok")
                        .WithMany()
                        .HasForeignKey("IspitniRokId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eUniverzitet.Data.Models.IzvodjenjePredmeta", "IzvodjenjePredmeta")
                        .WithMany()
                        .HasForeignKey("IzvodjenjePredmetaId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.IzvodjenjePredmeta", b =>
                {
                    b.HasOne("eUniverzitet.Data.Models.AkademskaGodina", "AkademskaGodina")
                        .WithMany()
                        .HasForeignKey("AkademskaGodinaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eUniverzitet.Data.Models.Predmet", "Predmet")
                        .WithMany()
                        .HasForeignKey("PredmetId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.Notifikacija", b =>
                {
                    b.HasOne("eUniverzitet.Data.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.NPP", b =>
                {
                    b.HasOne("eUniverzitet.Data.Models.AkademskaGodina", "AkademskaGodina")
                        .WithMany()
                        .HasForeignKey("AkademskaGodinaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eUniverzitet.Data.Models.Fakultet", "Fakultet")
                        .WithMany()
                        .HasForeignKey("FakultetId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eUniverzitet.Data.Models.Odsjek", "Odsjek")
                        .WithMany()
                        .HasForeignKey("OdsjekId");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.Odsjek", b =>
                {
                    b.HasOne("eUniverzitet.Data.Models.Fakultet", "Fakultet")
                        .WithMany()
                        .HasForeignKey("FakultetId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.Opstina", b =>
                {
                    b.HasOne("eUniverzitet.Data.Models.Regija", "Regija")
                        .WithMany()
                        .HasForeignKey("RegijaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.Predmet", b =>
                {
                    b.HasOne("eUniverzitet.Data.Models.NPP", "Npp")
                        .WithMany()
                        .HasForeignKey("NppId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.PrijavaIspita", b =>
                {
                    b.HasOne("eUniverzitet.Data.Models.IspitniTermin", "IspitniTermin")
                        .WithMany()
                        .HasForeignKey("IspitniTerminId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eUniverzitet.Data.Models.SlusaPredmet", "SlusaPredmet")
                        .WithMany()
                        .HasForeignKey("SlusaPredmetId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.SlusaPredmet", b =>
                {
                    b.HasOne("eUniverzitet.Data.Models.IzvodjenjePredmeta", "IzvodjenjePredmeta")
                        .WithMany()
                        .HasForeignKey("IzvodjenjePredmetaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eUniverzitet.Data.Models.UpisGodine", "UpisGodine")
                        .WithMany()
                        .HasForeignKey("UpisGodineId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.Student", b =>
                {
                    b.HasOne("eUniverzitet.Data.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eUniverzitet.Data.Models.Korisnik")
                        .WithMany("Students")
                        .HasForeignKey("KorisnikId1");

                    b.HasOne("eUniverzitet.Data.Models.Opstina", "OpstinaPrebivalista")
                        .WithMany()
                        .HasForeignKey("OpstinaPrebivalistaId");

                    b.HasOne("eUniverzitet.Data.Models.Opstina", "OpstinaRodjenja")
                        .WithMany()
                        .HasForeignKey("OpstinaRodjenjaId");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.Studiranje", b =>
                {
                    b.HasOne("eUniverzitet.Data.Models.NPP", "Npp")
                        .WithMany()
                        .HasForeignKey("NppId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eUniverzitet.Data.Models.Student", "Student")
                        .WithMany("Studiranjes")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.Ticket", b =>
                {
                    b.HasOne("eUniverzitet.Data.Models.IzvodjenjePredmeta", "IzvodjenjePredmeta")
                        .WithMany()
                        .HasForeignKey("IzvodjenjePredmetaId");

                    b.HasOne("eUniverzitet.Data.Models.Studiranje", "Studiranje")
                        .WithMany()
                        .HasForeignKey("StudiranjeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eUniverzitet.Data.Models.TicketKategorija", "TicketKategorija")
                        .WithMany()
                        .HasForeignKey("TicketKategorijaId");

                    b.HasOne("eUniverzitet.Data.Models.Zaposlenik", "Zaposlenik")
                        .WithMany()
                        .HasForeignKey("ZaposlenikId");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.TicketPoruka", b =>
                {
                    b.HasOne("eUniverzitet.Data.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eUniverzitet.Data.Models.Ticket", "Ticket")
                        .WithMany()
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("eUniverzitet.Data.Models.Ticket")
                        .WithMany("TicketPorukas")
                        .HasForeignKey("TicketId1");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.UpisGodine", b =>
                {
                    b.HasOne("eUniverzitet.Data.Models.AkademskaGodina", "AkademskaGodina")
                        .WithMany()
                        .HasForeignKey("AkademskaGodinaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eUniverzitet.Data.Models.Studiranje", "Studiranje")
                        .WithMany()
                        .HasForeignKey("StudiranjeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.UplataStudija", b =>
                {
                    b.HasOne("eUniverzitet.Data.Models.Korisnik", "EvidentiranoKorisnik")
                        .WithMany()
                        .HasForeignKey("EvidentiranoKorisnikId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eUniverzitet.Data.Models.UpisGodine", "UpisGodine")
                        .WithMany()
                        .HasForeignKey("UpisGodineId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.Zaposlenik", b =>
                {
                    b.HasOne("eUniverzitet.Data.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eUniverzitet.Data.Models.Korisnik")
                        .WithMany("Zaposleniks")
                        .HasForeignKey("KorisnikId1");
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.Zaposlenje", b =>
                {
                    b.HasOne("eUniverzitet.Data.Models.OrganizacionaJedinica", "OrganizacionaJedinica")
                        .WithMany()
                        .HasForeignKey("OrganizacionaJedinicaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eUniverzitet.Data.Models.Zaposlenik", "Zaposlenik")
                        .WithMany("Zaposlenja")
                        .HasForeignKey("ZaposlenikId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eUniverzitet.Data.Models.ZaposlenjeMjesto", "ZaposlenjeMjesto")
                        .WithMany()
                        .HasForeignKey("ZaposlenjeMjestoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eUniverzitet.Data.Models.Fakultet", b =>
                {
                    b.HasOne("eUniverzitet.Data.Models.NaucnaOblast", "NaucnaOblast")
                        .WithMany()
                        .HasForeignKey("NaucnaOblastId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
