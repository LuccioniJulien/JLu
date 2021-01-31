using System;
using System.Collections.Generic;

namespace JLu.Models
{
    public class Experience
    {
        public int Id { get; set; }
        public string Firm { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Begin { get; set; }
        public DateTime Ending { get; set; }
        public List<Tag> Tags { get; set; }
    }
}