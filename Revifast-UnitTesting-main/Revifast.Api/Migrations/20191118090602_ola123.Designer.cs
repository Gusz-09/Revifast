// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Revifast.Data;

namespace Revifast.Api.Migrations
{
    [DbContext(typeof(DbRevifastContext))]
    [Migration("20191118090602_ola123")]
    partial class ola123
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Revifast.Entities.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnName("Descripcion")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("Nombre")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.HasKey("CategoriaId");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("Revifast.Entities.Conductor", b =>
                {
                    b.Property<int>("ConductorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnName("Apellido")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Celular")
                        .HasColumnName("Celular")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Correo")
                        .HasColumnName("Correo")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Direccion")
                        .HasColumnName("Direccion")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<string>("Dni")
                        .IsRequired()
                        .HasColumnName("Dni")
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("Nombre")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("ConductorId");

                    b.ToTable("Conductor");
                });

            modelBuilder.Entity("Revifast.Entities.Departamento", b =>
                {
                    b.Property<int>("DepartamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("Nombre")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("DepartamentoId");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("Revifast.Entities.Distrito", b =>
                {
                    b.Property<int>("DistritoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("Nombre")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<int>("ProvinciaId")
                        .HasColumnType("int");

                    b.HasKey("DistritoId");

                    b.HasIndex("ProvinciaId");

                    b.ToTable("Distrito");
                });

            modelBuilder.Entity("Revifast.Entities.Empresa", b =>
                {
                    b.Property<int>("EmpresaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Correo")
                        .HasColumnName("Correo")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("Nombre")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Ruc")
                        .IsRequired()
                        .HasColumnName("Ruc")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Telefono")
                        .HasColumnName("Telefono")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.HasKey("EmpresaId");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("Revifast.Entities.Horario", b =>
                {
                    b.Property<int>("HorarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Dia")
                        .HasColumnName("Dia")
                        .HasColumnType("varchar(11)")
                        .HasMaxLength(11)
                        .IsUnicode(false);

                    b.Property<bool?>("Feriado")
                        .HasColumnName("Feriado")
                        .HasColumnType("bit");

                    b.Property<string>("HoraApertura")
                        .HasColumnName("HoraApertura")
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    b.Property<string>("HoraCierre")
                        .HasColumnName("HoraCierre")
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    b.HasKey("HorarioId");

                    b.ToTable("Horario");
                });

            modelBuilder.Entity("Revifast.Entities.Local", b =>
                {
                    b.Property<int>("LocalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnName("Direccion")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<int>("DistritoId")
                        .HasColumnType("int");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<int>("HorarioId")
                        .HasColumnType("int");

                    b.HasKey("LocalId");

                    b.HasIndex("DistritoId");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("HorarioId");

                    b.ToTable("Local");
                });

            modelBuilder.Entity("Revifast.Entities.Marca", b =>
                {
                    b.Property<int>("MarcaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("Nombre")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("MarcaId");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("Revifast.Entities.Modelo", b =>
                {
                    b.Property<int>("ModeloId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MarcaId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("Nombre")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("ModeloId");

                    b.HasIndex("MarcaId");

                    b.ToTable("Modelo");
                });

            modelBuilder.Entity("Revifast.Entities.PagoAdelantado", b =>
                {
                    b.Property<int>("PagoAdelantadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnName("Descripcion")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<string>("Nombre")
                        .HasColumnName("Nombre")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<decimal>("Procentaje")
                        .HasColumnName("Procentaje")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PagoAdelantadoId");

                    b.ToTable("PagoAdelantado");
                });

            modelBuilder.Entity("Revifast.Entities.Promocion", b =>
                {
                    b.Property<int>("PromocionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnName("Descripcion")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<decimal>("Descuento")
                        .HasColumnName("Descuento")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Nombre")
                        .HasColumnName("Nombre")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<int>("ServicioId")
                        .HasColumnType("int");

                    b.HasKey("PromocionId");

                    b.HasIndex("ServicioId");

                    b.ToTable("Promocion");
                });

            modelBuilder.Entity("Revifast.Entities.Provincia", b =>
                {
                    b.Property<int>("ProvinciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("Nombre")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("ProvinciaId");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Provincia");
                });

            modelBuilder.Entity("Revifast.Entities.Reserva", b =>
                {
                    b.Property<int>("ReservaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Fecha")
                        .HasColumnName("Fecha")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Hora")
                        .HasColumnName("Hora")
                        .HasColumnType("varchar(8)")
                        .HasMaxLength(8)
                        .IsUnicode(false);

                    b.Property<int>("LocalId")
                        .HasColumnType("int");

                    b.Property<string>("Observaciones")
                        .HasColumnName("Observaciones")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<int>("PagoAdelantadoId")
                        .HasColumnType("int");

                    b.Property<int>("ReservaEstadoId")
                        .HasColumnType("int");

                    b.Property<int>("VehiculoId")
                        .HasColumnType("int");

                    b.HasKey("ReservaId");

                    b.HasIndex("LocalId");

                    b.HasIndex("PagoAdelantadoId");

                    b.HasIndex("ReservaEstadoId");

                    b.HasIndex("VehiculoId");

                    b.ToTable("Reserva");
                });

            modelBuilder.Entity("Revifast.Entities.ReservaEstado", b =>
                {
                    b.Property<int>("ReservaEstadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Estado")
                        .HasColumnName("Estado")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("ReservaEstadoId");

                    b.ToTable("ReservaEstado");
                });

            modelBuilder.Entity("Revifast.Entities.Servicio", b =>
                {
                    b.Property<int>("ServicioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnName("Descripcion")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.Property<int>("LocalId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("Nombre")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.HasKey("ServicioId");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("LocalId");

                    b.ToTable("Servicio");
                });

            modelBuilder.Entity("Revifast.Entities.Vehiculo", b =>
                {
                    b.Property<int>("VehiculoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnName("Color")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<int>("ConductorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaFabricacion")
                        .HasColumnName("FechaFabricacion")
                        .HasColumnType("datetime");

                    b.Property<int>("ModeloId")
                        .HasColumnType("int");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnName("Placa")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.HasKey("VehiculoId");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("ConductorId");

                    b.HasIndex("ModeloId");

                    b.ToTable("Vehiculo");
                });

            modelBuilder.Entity("Revifast.Entities.Distrito", b =>
                {
                    b.HasOne("Revifast.Entities.Provincia", "Provincia")
                        .WithMany("Distritos")
                        .HasForeignKey("ProvinciaId")
                        .HasConstraintName("Distrito_Provincia")
                        .IsRequired();
                });

            modelBuilder.Entity("Revifast.Entities.Local", b =>
                {
                    b.HasOne("Revifast.Entities.Distrito", "Distrito")
                        .WithMany("Locales")
                        .HasForeignKey("DistritoId")
                        .HasConstraintName("Local_Distrito")
                        .IsRequired();

                    b.HasOne("Revifast.Entities.Empresa", "Empresa")
                        .WithMany("Locales")
                        .HasForeignKey("EmpresaId")
                        .HasConstraintName("Local_Empresa")
                        .IsRequired();

                    b.HasOne("Revifast.Entities.Horario", "Horario")
                        .WithMany("Locales")
                        .HasForeignKey("HorarioId")
                        .HasConstraintName("Local_Horario")
                        .IsRequired();
                });

            modelBuilder.Entity("Revifast.Entities.Modelo", b =>
                {
                    b.HasOne("Revifast.Entities.Marca", "Marca")
                        .WithMany("Modelos")
                        .HasForeignKey("MarcaId")
                        .HasConstraintName("Modelo_Marca")
                        .IsRequired();
                });

            modelBuilder.Entity("Revifast.Entities.Promocion", b =>
                {
                    b.HasOne("Revifast.Entities.Servicio", "Servicio")
                        .WithMany("Promociones")
                        .HasForeignKey("ServicioId")
                        .HasConstraintName("Servicio_Promocion")
                        .IsRequired();
                });

            modelBuilder.Entity("Revifast.Entities.Provincia", b =>
                {
                    b.HasOne("Revifast.Entities.Departamento", "Departamento")
                        .WithMany("Provincias")
                        .HasForeignKey("DepartamentoId")
                        .HasConstraintName("Provincia_Departamento")
                        .IsRequired();
                });

            modelBuilder.Entity("Revifast.Entities.Reserva", b =>
                {
                    b.HasOne("Revifast.Entities.Local", "Local")
                        .WithMany("Reservas")
                        .HasForeignKey("LocalId")
                        .HasConstraintName("Reserva_Local");

                    b.HasOne("Revifast.Entities.PagoAdelantado", "PagoAdelantado")
                        .WithMany("Reservas")
                        .HasForeignKey("PagoAdelantadoId")
                        .HasConstraintName("Reserva_PagoAdelantado");

                    b.HasOne("Revifast.Entities.ReservaEstado", "ReservaEstado")
                        .WithMany("Reservas")
                        .HasForeignKey("ReservaEstadoId")
                        .HasConstraintName("Reserva_ReservaEstado");

                    b.HasOne("Revifast.Entities.Vehiculo", "Vehiculo")
                        .WithMany("Reservas")
                        .HasForeignKey("VehiculoId")
                        .HasConstraintName("Reserva_Vehiculo");
                });

            modelBuilder.Entity("Revifast.Entities.Servicio", b =>
                {
                    b.HasOne("Revifast.Entities.Categoria", "Categoria")
                        .WithMany("Servicios")
                        .HasForeignKey("CategoriaId")
                        .HasConstraintName("Servicio_Categoria")
                        .IsRequired();

                    b.HasOne("Revifast.Entities.Local", "Local")
                        .WithMany("Servicios")
                        .HasForeignKey("LocalId")
                        .HasConstraintName("Servicio_Local")
                        .IsRequired();
                });

            modelBuilder.Entity("Revifast.Entities.Vehiculo", b =>
                {
                    b.HasOne("Revifast.Entities.Categoria", "Categoria")
                        .WithMany("Vehiculos")
                        .HasForeignKey("CategoriaId")
                        .HasConstraintName("Vehiculo_Categoria")
                        .IsRequired();

                    b.HasOne("Revifast.Entities.Conductor", "Conductor")
                        .WithMany("Vehiculos")
                        .HasForeignKey("ConductorId")
                        .HasConstraintName("Vehiculo_Conductor")
                        .IsRequired();

                    b.HasOne("Revifast.Entities.Modelo", "Modelo")
                        .WithMany("Vehiculos")
                        .HasForeignKey("ModeloId")
                        .HasConstraintName("Vehiculo_Modelo")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
