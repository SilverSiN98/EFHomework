using System.Collections.Generic;

namespace EFHomework.Models
{
    public class Volume
    {
        public int Id { get; set; }

        public int SerialNumber { get; set; }

        public string Name { get; set; }

        // One volume contains many chapters
        public ICollection<Chapter> Chapters { get; set; }

        public Volume()
        {
            Chapters = new List<Chapter>();
        }

        public override string ToString()
        {
            return string.Format("The volume {0} with title \"{1}\" has ID = {2}.", SerialNumber, Name, Id);
        }
    }
}
