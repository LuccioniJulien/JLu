using System.Collections.Generic;

namespace JLu.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<Project> Projects { get; set; }
    }
}