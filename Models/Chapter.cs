namespace EFHomework.Models
{
    public class Chapter
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int SerialNumber { get; set; }

        public int NumberOfPages { get; set; }

        public int VolumeId { get; set; }

        public Volume Volume { get; set; }

        public override string ToString()
        {
            return string.Format("[Id = {0}, Name = {1}, Chapter number = {2}, Number of pages = {3}]", 
                Id, Name ?? "none", SerialNumber, NumberOfPages);
        }
    }
}
