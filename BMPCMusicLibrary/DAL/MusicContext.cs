using BMPCMusicLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace BMPCMusicLibrary.DAL
{
    public class MusicContext : DbContext
    {
        public MusicContext(): base("MusicContext")
        {
        }

        public DbSet<Piece> Pieces { get; set; }
        public DbSet<Recording> Recordings { get; set; }
        public DbSet<Performance> Performances { get; set; }
        public DbSet<Feature> Features { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}