using System;
using System.Linq;
using System.Collections.Generic;
using EFHomework.Contexts;
using EFHomework.Models;

namespace EFHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                // get all volumes from database
                List<Volume> volumes = (from p in db.Volumes
                                        select p).ToList();
                foreach (var item in volumes)
                {
                    Console.WriteLine(item);
                    Console.WriteLine("The volume contains such chapters: ");

                    // find all chapters with current volume id
                    List<Chapter> chapters = (from p in db.Chapters
                                             where p.VolumeId == item.Id
                                             select p).ToList();

                    foreach (var chapter in chapters)
                    {
                        Console.WriteLine(chapter);
                    }
                    Console.WriteLine("----------------------------------------------------------------");
                }
            };

            Console.ReadLine();
        }
    }
}
