using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projekt_Semestralny.DataBaseContext;

namespace Projekt_Semestralny.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Projekt_Semestralny.Model.Gatunki", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NazwaGatunku")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Gatunki");
                });

            modelBuilder.Entity("Projekt_Semestralny.Model.Lekarze", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Imie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwisko")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pesel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Lekarze");
                });

            modelBuilder.Entity("Projekt_Semestralny.Model.Opiekunowie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Imie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Wiek")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Opiekunowie");
                });

            modelBuilder.Entity("Projekt_Semestralny.Model.Pacjenci", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("GatunekId")
                        .HasColumnType("int");

                    b.Property<int?>("LekarzId")
                        .HasColumnType("int");

                    b.Property<int?>("OpiekunId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GatunekId");

                    b.HasIndex("LekarzId");

                    b.HasIndex("OpiekunId");

                    b.ToTable("Pacjenci");
                });

            modelBuilder.Entity("Projekt_Semestralny.Model.Pacjenci", b =>
                {
                    b.HasOne("Projekt_Semestralny.Model.Gatunki", "Gatunek")
                        .WithMany()
                        .HasForeignKey("GatunekId");

                    b.HasOne("Projekt_Semestralny.Model.Lekarze", "Lekarz")
                        .WithMany()
                        .HasForeignKey("LekarzId");

                    b.HasOne("Projekt_Semestralny.Model.Opiekunowie", "Opiekun")
                        .WithMany()
                        .HasForeignKey("OpiekunId");
                });
#pragma warning restore 612, 618
        }
    }
}
