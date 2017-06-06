using System;
using System.Data.Entity;
using ChannelRankings.Models.Authorities;
using ChannelRankings.Models;
using System.Data.Entity.Infrastructure.Annotations;
using System.ComponentModel.DataAnnotations.Schema;
using ChannelRankins.Contracts.Data;
using System.Data.Entity.Infrastructure;

namespace ChannelRankings.Data
{
    public class SqlServerDbContext : DbContext, IDbContext
    {
        private static readonly string DbConnectionName = "ChannelRankingsConnection";

        public SqlServerDbContext()
                    : base(DbConnectionName)
        {
        }

        public IDbSet<Corporation> Corporations { get; set; }

        public IDbSet<Sponsor> Sponsors { get; set; }

        public IDbSet<Channel> Channels { get; set; }

        public IDbSet<Country> Countries { get; set; }

        public IDbSet<Owner> Owners { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            this.OnCountryModelCreating(modelBuilder);
            this.OnCorporationModelCreating(modelBuilder);
            this.OnSponsorModelCreating(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        private void OnCorporationModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Corporation>()
                .HasKey(corp => corp.Id);

            modelBuilder.Entity<Corporation>()
                .Property(corp => corp.Name)
                .IsRequired()
                .HasMaxLength(40);

            modelBuilder.Entity<Corporation>()
                .HasRequired<Owner>(corp => corp.Owner);

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

        private void OnCountryModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                .HasKey(country => country.Id);

            modelBuilder.Entity<Country>()
                .Property(country => country.Name)
                .HasMaxLength(20)
                .IsRequired();
        }

        DbEntityEntry IDbContext.Entry<T>(T entity)
        {
            return base.Entry<T>(entity);
        }

        IDbSet<T> IDbContext.Set<T>()
        {
            return base.Set<T>();
        }
    }
}
