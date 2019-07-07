﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using engie_dashboard.Models;

namespace engie_dashboard.Migrations
{
    [DbContext(typeof(ModelContext))]
    [Migration("20190707041213_DatabaseChange2")]
    partial class DatabaseChange2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("engie_dashboard.Models.HistoricoSolicitacao", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comando");

                    b.Property<DateTime>("Date");

                    b.Property<string>("SolicitacaoId");

                    b.Property<int>("StatusSolicitacao");

                    b.Property<string>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("SolicitacaoId");

                    b.ToTable("HistoricoSolicitacao");
                });

            modelBuilder.Entity("engie_dashboard.Models.Solicitacao", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("Chuva");

                    b.Property<int?>("ComandoDePotencia");

                    b.Property<DateTime>("Data");

                    b.Property<string>("EncaminhadoId");

                    b.Property<int?>("EstadoOperacional");

                    b.Property<string>("NivelDeReservatorio");

                    b.Property<string>("OperadorId");

                    b.Property<string>("Precipitacao");

                    b.Property<string>("SolicitanteId");

                    b.Property<int>("StatusSolicitacao");

                    b.Property<int?>("TipoDePotencia");

                    b.Property<int>("TipoSolicitacao");

                    b.Property<string>("UG");

                    b.Property<string>("UnidadeMedida");

                    b.Property<string>("Usina");

                    b.Property<string>("Valor");

                    b.Property<string>("VazaoAfluente");

                    b.Property<string>("VazaoDefluente");

                    b.Property<string>("VazaoTurbinada");

                    b.Property<string>("VazaoVertida");

                    b.HasKey("Id");

                    b.HasIndex("EncaminhadoId");

                    b.HasIndex("OperadorId");

                    b.HasIndex("SolicitanteId");

                    b.ToTable("Solicitacao");
                });

            modelBuilder.Entity("engie_dashboard.Models.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataCriacao");

                    b.Property<int>("Empresa");

                    b.Property<string>("NomeCompleto");

                    b.Property<int>("Profile");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("engie_dashboard.Models.HistoricoSolicitacao", b =>
                {
                    b.HasOne("engie_dashboard.Models.Solicitacao")
                        .WithMany("HistoricosSolicitacao")
                        .HasForeignKey("SolicitacaoId");
                });

            modelBuilder.Entity("engie_dashboard.Models.Solicitacao", b =>
                {
                    b.HasOne("engie_dashboard.Models.Usuario", "Encaminhado")
                        .WithMany()
                        .HasForeignKey("EncaminhadoId");

                    b.HasOne("engie_dashboard.Models.Usuario", "Operador")
                        .WithMany()
                        .HasForeignKey("OperadorId");

                    b.HasOne("engie_dashboard.Models.Usuario", "Solicitante")
                        .WithMany()
                        .HasForeignKey("SolicitanteId");
                });
#pragma warning restore 612, 618
        }
    }
}
