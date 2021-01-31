using System;
using System.Collections.Generic;

namespace JLu.Models
{
    public class Study
    {
        public int Id { get; set; }
        public string School { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Begin { get; set; }
        public DateTime Ending { get; set; }
    }
}