using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace proyecto_Famular_Lezcano.Models;

public partial class ProyectoFamularLezcanoContext : DbContext
{
    public ProyectoFamularLezcanoContext()
    {
    }

    public ProyectoFamularLezcanoContext(DbContextOptions<ProyectoFamularLezcanoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categorium> Categoria { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Pelicula> Peliculas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<VentaCabecera> VentaCabeceras { get; set; }

    public virtual DbSet<VentaDetalle> VentaDetalles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=proyecto_Famular_Lezcano;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categorium>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("pk_categoria");

            entity.Property(e => e.IdCategoria)
                .ValueGeneratedNever()
                .HasColumnName("id_categoria");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("pk_cliente");

            entity.ToTable("Cliente");

            entity.HasIndex(e => e.Email, "uq_email").IsUnique();

            entity.Property(e => e.IdCliente)
                .ValueGeneratedNever()
                .HasColumnName("id_cliente");
            entity.Property(e => e.ApellidoCliente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellido_cliente");
            entity.Property(e => e.Direccion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre_cliente");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Pelicula>(entity =>
        {
            entity.HasKey(e => e.IdPelicula).HasName("pk_pelicula");

            entity.ToTable("Pelicula");

            entity.Property(e => e.IdPelicula)
                .ValueGeneratedNever()
                .HasColumnName("id_pelicula");
            entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");
            entity.Property(e => e.Imagen)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("imagen");
            entity.Property(e => e.NombrePelicula)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nombre_pelicula");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio");
            entity.Property(e => e.Sinopsis)
                .HasColumnType("text")
                .HasColumnName("sinopsis");
            entity.Property(e => e.Stock).HasColumnName("stock");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Peliculas)
                .HasForeignKey(d => d.IdCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_categoria");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("pk_usuario");

            entity.ToTable("Usuario");

            entity.HasIndex(e => e.Email, "UQ__Usuario__AB6E616422F44CAA").IsUnique();

            entity.HasIndex(e => e.NombreUsuario, "UQ__Usuario__D4D22D74788D54C1").IsUnique();

            entity.Property(e => e.IdUsuario)
                .ValueGeneratedNever()
                .HasColumnName("id_usuario");
            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Contrasena)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("contrasena");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Estado)
                .HasDefaultValue(true)
                .HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_usuario");
            entity.Property(e => e.Rol)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("rol");
        });

        modelBuilder.Entity<VentaCabecera>(entity =>
        {
            entity.HasKey(e => e.IdVenta).HasName("pk_venta");

            entity.ToTable("Venta_Cabecera");

            entity.Property(e => e.IdVenta)
                .ValueGeneratedNever()
                .HasColumnName("id_venta");
            entity.Property(e => e.FechaCompra)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_compra");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.TotalVenta)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("totalVenta");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.VentaCabeceras)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cliente");
        });

        modelBuilder.Entity<VentaDetalle>(entity =>
        {
            entity.HasKey(e => e.IdDetalle).HasName("pk_detalle");

            entity.ToTable("Venta_Detalle");

            entity.Property(e => e.IdDetalle)
                .ValueGeneratedNever()
                .HasColumnName("id_detalle");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.IdPelicula).HasColumnName("id_pelicula");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.IdVenta).HasColumnName("id_venta");

            entity.HasOne(d => d.IdPeliculaNavigation).WithMany(p => p.VentaDetalles)
                .HasForeignKey(d => d.IdPelicula)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pelicula");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.VentaDetalles)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_vendedor");

            entity.HasOne(d => d.IdVentaNavigation).WithMany(p => p.VentaDetalles)
                .HasForeignKey(d => d.IdVenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_venta");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
