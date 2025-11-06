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

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

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
            entity.HasKey(e => e.IdCategoria).HasName("PK__Categori__CD54BC5A43A477C2");

            entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");
            entity.Property(e => e.Activo)
                .HasDefaultValue(true)
                .HasColumnName("activo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .HasColumnName("descripcion");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PK__Cliente__677F38F58FF81F05");

            entity.ToTable("Cliente");

            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.ApellidoCliente)
                .HasMaxLength(50)
                .HasColumnName("apellido_cliente");
            entity.Property(e => e.ContrasenaCliente)
                .HasMaxLength(255)
                .HasColumnName("contrasena_cliente");
            entity.Property(e => e.Direccion)
                .HasMaxLength(150)
                .HasColumnName("direccion");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(50)
                .HasColumnName("nombre_cliente");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Pelicula>(entity =>
        {
            entity.HasKey(e => e.IdPelicula).HasName("PK__Pelicula__B5017F4D11E60425");

            entity.ToTable("Pelicula");

            entity.Property(e => e.IdPelicula).HasColumnName("id_pelicula");
            entity.Property(e => e.IdCategoria).HasColumnName("id_categoria");
            entity.Property(e => e.IdTicket).HasColumnName("id_ticket");
            entity.Property(e => e.Imagen)
                .HasMaxLength(255)
                .HasColumnName("imagen");
            entity.Property(e => e.NombrePelicula)
                .HasMaxLength(100)
                .HasColumnName("nombre_pelicula");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precio");
            entity.Property(e => e.Sinopsis)
                .HasMaxLength(500)
                .HasColumnName("sinopsis");
            entity.Property(e => e.Stock).HasColumnName("stock");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Peliculas)
                .HasForeignKey(d => d.IdCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pelicula_categoria");

            entity.HasOne(d => d.IdTicketNavigation).WithMany(p => p.Peliculas)
                .HasForeignKey(d => d.IdTicket)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pelicula_ticket");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("PK__Rol__6ABCB5E0D9A49C12");

            entity.ToTable("Rol");

            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.NombreRol)
                .HasMaxLength(50)
                .HasColumnName("nombre_rol");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.IdTicket).HasName("PK__Ticket__48C6F5233E330E37");

            entity.ToTable("Ticket");

            entity.HasIndex(e => e.CodVisualizacion, "UQ__Ticket__3792E9D0FE9D8255").IsUnique();

            entity.Property(e => e.IdTicket).HasColumnName("id_ticket");
            entity.Property(e => e.CodVisualizacion)
                .HasMaxLength(20)
                .HasColumnName("cod_visualizacion");
            entity.Property(e => e.Link)
                .HasMaxLength(255)
                .HasColumnName("link");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuario__4E3E04AD6B76542E");

            entity.ToTable("Usuario");

            entity.HasIndex(e => e.NombreUsuario, "UQ__Usuario__D4D22D74F3B5F4CC").IsUnique();

            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .HasColumnName("apellido");
            entity.Property(e => e.Contrasena)
                .HasMaxLength(255)
                .HasColumnName("contrasena");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Estado)
                .HasDefaultValue(true)
                .HasColumnName("estado");
            entity.Property(e => e.IdRol).HasColumnName("id_rol");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(50)
                .HasColumnName("nombre_usuario");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_usuario_rol");
        });

        modelBuilder.Entity<VentaCabecera>(entity =>
        {
            entity.HasKey(e => e.IdVenta).HasName("PK__Venta_Ca__459533BF97848A60");

            entity.ToTable("Venta_Cabecera");

            entity.Property(e => e.IdVenta).HasColumnName("id_venta");
            entity.Property(e => e.FechaCompra)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fecha_compra");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.TotalVenta)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("total_venta");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.VentaCabeceras)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_venta_cliente");
        });

        modelBuilder.Entity<VentaDetalle>(entity =>
        {
            entity.HasKey(e => e.IdDetalle).HasName("PK__Venta_De__4F1332DE47CD6A5A");

            entity.ToTable("Venta_Detalle");

            entity.Property(e => e.IdDetalle).HasColumnName("id_detalle");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.IdPelicula).HasColumnName("id_pelicula");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.IdVenta).HasColumnName("id_venta");

            entity.HasOne(d => d.IdPeliculaNavigation).WithMany(p => p.VentaDetalles)
                .HasForeignKey(d => d.IdPelicula)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_detalle_pelicula");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.VentaDetalles)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("fk_usuario");

            entity.HasOne(d => d.IdVentaNavigation).WithMany(p => p.VentaDetalles)
                .HasForeignKey(d => d.IdVenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_detalle_venta");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
