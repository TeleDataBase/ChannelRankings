using System;
using System.Data.Entity;
using ChannelRankings.Models.Authorities;
using ChannelRankings.Models;
using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChannelRankings.Data
{
    public class SqlServerDbContext : DbContext
    {
        private static readonly string DbConnectionName = "ChannelRankingsConnection";

        public SqlServerDbContext()
                    : base(DbConnectionName)
        {
        }

        IDbSet<Corporation> Corporations { get; set; }

        IDbSet<Sponsor> Sponsors { get; set; }

        IDbSet<Channel> Channels { get; set; }

        IDbSet<Country> Countries { get; set; }

        IDbSet<Owner> Owners { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            this.OnSponsorModelCreating(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        private void OnSponsorModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sponsor>()
                .HasKey(sponsor => sponsor.Id);

            modelBuilder.Entity<Sponsor>()
                .Property(sponsor => sponsor.Name)
                .IsRequired()
                .HasMaxLength(40)
                .HasColumnAnnotation(
                "Index",
                new IndexAnnotation(
                    new IndexAttribute("IX_Name") { IsUnique = true }
                )
            );

            modelBuilder.Entity<Sponsor>()
                .Property(sponsor => sponsor.About)
                .HasColumnType("ntext");
        }
    }
}
