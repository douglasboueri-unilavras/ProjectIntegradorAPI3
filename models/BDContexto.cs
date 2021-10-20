using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Cadastro___Produtos.Models
{
    public partial class BDContexto : DbContext
    {
        public BDContexto()
        {
        }

        public BDContexto(DbContextOptions<BDContexto> options)
            : base(options)
        {
        }

        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Colaborador> Colaborador { get; set; }
        public virtual DbSet<Pizza> Pizza { get; set; }
        public virtual DbSet<Produtocat> Produtocat { get; set; }
        public virtual DbSet<Produtotip> Produtotip { get; set; }
        public virtual DbSet<Tipo> Tipo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=Goku1234;database=APSproject");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.ToTable("categoria");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Colaborador>(entity =>
            {
                entity.HasKey(e => e.Nome)
                    .HasName("PRIMARY");

                entity.ToTable("colaborador");

                entity.Property(e => e.Nome).HasMaxLength(40);

                entity.Property(e => e.Categoria).HasColumnName("categoria");
            });

            modelBuilder.Entity<Pizza>(entity =>
            {
                entity.HasKey(e => e.Nome)
                    .HasName("PRIMARY");

                entity.ToTable("pizza");

                entity.Property(e => e.Nome).HasMaxLength(40);

                entity.Property(e => e.NumeroDeFatias).HasColumnName("Numero_de_fatias");
            });

            modelBuilder.Entity<Produtocat>(entity =>
            {
                entity.ToTable("produtocat");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Produtotip>(entity =>
            {
                entity.HasKey(e => e.Nome)
                    .HasName("PRIMARY");

                entity.ToTable("produtotip");

                entity.Property(e => e.Nome).HasMaxLength(40);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Tipo>(entity =>
            {
                entity.ToTable("tipo");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
