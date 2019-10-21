using System.Data.Entity;
using System.Data.SqlClient;
using EFHomework.Models;

namespace EFHomework.Contexts
{
    public class ApplicationContextInitializer : DropCreateDatabaseAlways<ApplicationContext>
    {
        protected override void Seed(ApplicationContext db)
        {
            Volume volume1 = new Volume { SerialNumber = 1, Name = "Shingeki no Kyojin" };
            Volume volume2 = new Volume { SerialNumber = 2, Name = "Shingeki no Kyojin" };
            db.Volumes.Add(volume1);
            db.Volumes.Add(volume2);

            db.Chapters.Add(new Chapter { NumberOfPages = 15, SerialNumber = 1, Volume = volume1, Name = "To you in 2000 years" });
            db.Chapters.Add(new Chapter { NumberOfPages = 18, SerialNumber = 2, Volume = volume1, Name = "On that day" });
            db.Chapters.Add(new Chapter { NumberOfPages = 12, SerialNumber = 3, Volume = volume1, Name = "The night of the disbanding" });
            db.Chapters.Add(new Chapter { NumberOfPages = 20, SerialNumber = 4, Volume = volume1, Name = "Their first battle" });
            db.Chapters.Add(new Chapter { NumberOfPages = 22, SerialNumber = 5, Volume = volume1, Name = "Short blade" });

            db.Chapters.Add(new Chapter { NumberOfPages = 32, SerialNumber = 1, Volume = volume2 });
            db.Chapters.Add(new Chapter { NumberOfPages = 19, SerialNumber = 2, Volume = volume2 });
            db.Chapters.Add(new Chapter { NumberOfPages = 20, SerialNumber = 3, Volume = volume2 });
            db.Chapters.Add(new Chapter { NumberOfPages = 17, SerialNumber = 4, Volume = volume2 });

            Volume volume3 = new Volume { SerialNumber = 1, Name = "Shigatsu no Lion" };
            db.Volumes.Add(volume3);

            db.Chapters.Add(new Chapter { NumberOfPages = 35, SerialNumber = 1, Volume = volume3 });
            db.Chapters.Add(new Chapter { NumberOfPages = 18, SerialNumber = 2, Volume = volume3 });
            db.Chapters.Add(new Chapter { NumberOfPages = 22, SerialNumber = 3, Volume = volume3 });
            db.Chapters.Add(new Chapter { NumberOfPages = 23, SerialNumber = 4, Volume = volume3 });
            db.Chapters.Add(new Chapter { NumberOfPages = 23, SerialNumber = 5, Volume = volume3 });
            db.Chapters.Add(new Chapter { NumberOfPages = 7, SerialNumber = 6, Volume = volume3 });

            db.SaveChanges();
        }
    }
}
