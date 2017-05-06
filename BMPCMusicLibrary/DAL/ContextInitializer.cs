using BMPCMusicLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BMPCMusicLibrary.DAL
{
    public class ContextInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MusicContext>
    {
        protected override void Seed(MusicContext context)
        {
            var pieces = new List<Piece>
            {
                new Piece{Title="Upon this Rock",Composer="Choplin"},
                new Piece{Title="Twelve Gates",Composer="Shackley"},
                new Piece{Title="Total Praise",Composer="Anon"},
                new Piece{Title="To the Cross Lord",Composer="Anon"},
                new Piece{Title="There is a Green Hill",Composer="Martin"},
                new Piece{Title="Waiting for the Light",Composer="Besig"},
                new Piece{Title="Valleys of Grace",Composer="Hamlin"},
                new Piece{Title="A Voice Cries Out",Composer="Larson"}
            };

            pieces.ForEach(s => context.Pieces.Add(s));
            context.SaveChanges();

            var performances = new List<Performance>
            {
                new Performance{PieceID=1,PerformanceDate=DateTime.Parse("2005-09-01")},
                new Performance{PieceID=2,PerformanceDate=DateTime.Parse("2002-09-01"),ThemeOrOccasion="Easter Sunday"},
                new Performance{PieceID=3,PerformanceDate=DateTime.Parse("2003-09-01")},
                new Performance{PieceID=2,PerformanceDate=DateTime.Parse("2002-09-01"),ThemeOrOccasion="Maundy Thursday"},
                new Performance{PieceID=4,PerformanceDate=DateTime.Parse("2002-09-01"),ThemeOrOccasion="Christmas Eve"},
                new Performance{PieceID=3,PerformanceDate=DateTime.Parse("2001-09-01")},
                new Performance{PieceID=1,PerformanceDate=DateTime.Parse("2003-09-01")}
            };

            performances.ForEach(s => context.Performances.Add(s));
            context.SaveChanges();

            var recordings = new List<Recording>
            {
                new Recording{PieceID=1,Rating=5,Url="www.youtube.com",Artist="Bel Canto"},
                new Recording{PieceID=1,Rating=2,Url="www.youtube.com",Artist="BMPC"},
                new Recording{PieceID=1,Rating=4,Url="www.youtube.com",Artist="BMPC"},
                new Recording{PieceID=2,Rating=4,Url="www.youtube.com",Artist="Five Blind Boys"},
                new Recording{PieceID=2,Rating=4,Url="www.youtube.com",Artist="Bel Canto"},
                new Recording{PieceID=2,Rating=2,Url="www.youtube.com",Artist="The Limestones"},
                new Recording{PieceID=3,Rating=5,Url="www.youtube.com"},
                new Recording{PieceID=4,Rating=5,Url="www.youtube.com"},
                new Recording{PieceID=4,Rating=2,Url="www.youtube.com",Artist="BMPC"},
                new Recording{PieceID=5,Rating=4,Url="www.youtube.com",Artist="Blind Melon"},
                new Recording{PieceID=6,Rating=4,Url="www.youtube.com"},
                new Recording{PieceID=7,Rating=4,Url="www.youtube.com",Artist="The Temptations"},
            };

            recordings.ForEach(s => context.Recordings.Add(s));
            context.SaveChanges();
        }
    }
}