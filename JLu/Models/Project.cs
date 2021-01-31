using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace JLu.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string GithubLink { get; set; }
        public string AppLink { get; set; }
        public List<Tag> Tags { get; set; }
    }
}