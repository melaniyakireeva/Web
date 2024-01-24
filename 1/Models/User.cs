using System;
using System.Collections.Generic;

namespace _1.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Order { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Street { get; set; } = null!;
        public string House { get; set; } = null!;
        public int? Flat { get; set; }
        public int? Entrance { get; set; }
        public int? Intercom { get; set; }
    }
}
