using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TopLiby.Models
{
    public partial class TopicsDbContext : DbContext
    {
        public TopicsDbContext()
        {
        }

        public TopicsDbContext(DbContextOptions<TopicsDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Registration> Registration { get; set; }
        public virtual DbSet<Topic> Topic { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=localhost;database=TopicsDb;trusted_connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registration>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);
            });

            modelBuilder.Entity<Topic>(entity =>
            {
                entity.Property(e => e.CompletionDate).HasColumnType("datetime");

                entity.Property(e => e.InProgress).HasMaxLength(1);

                entity.Property(e => e.SourceOf)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StartLearningDate).HasColumnType("datetime");

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
