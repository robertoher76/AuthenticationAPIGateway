﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PeliculaAPI.Models;

#nullable disable

namespace PeliculaAPI.Migrations
{
    [DbContext(typeof(PeliculaContext))]
    partial class PeliculaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PeliculaAPI.Models.Pelicula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnioLanzamiento")
                        .HasColumnType("int");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Libros");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AnioLanzamiento = 1972,
                            Director = "Francis Ford Coppola",
                            Titulo = "El padrino"
                        },
                        new
                        {
                            Id = 2,
                            AnioLanzamiento = 2016,
                            Director = "Damien Chazelle",
                            Titulo = "La La Land: ciudad de sueños"
                        },
                        new
                        {
                            Id = 3,
                            AnioLanzamiento = 1999,
                            Director = "Anthony Minghella",
                            Titulo = "El paciente inglés"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
