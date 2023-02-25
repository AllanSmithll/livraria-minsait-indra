﻿// <auto-generated />
using System;
using Livraria.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace APILivraria.Migrations
{
    [DbContext(typeof(MainContext))]
    [Migration("20230225024447_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Livraria.Api.Models.Autor", b =>
                {
                    b.Property<int>("IdAutor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAutor"));

                    b.Property<int>("DataNascimento")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Obras")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAutor");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("Livraria.Api.Models.Livro", b =>
                {
                    b.Property<Guid>("Isbn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DataPublicacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edicao")
                        .HasColumnType("int");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeAutor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeEditora")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantPaginas")
                        .HasColumnType("int");

                    b.Property<string>("Resumo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subtitulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Isbn");

                    b.ToTable("Livros");
                });
#pragma warning restore 612, 618
        }
    }
}