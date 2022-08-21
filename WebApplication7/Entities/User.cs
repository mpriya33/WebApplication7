using System;
using System.Collections.Generic;

namespace WebApplication7.Entities
{
    public partial class User
    {
        public string Accno { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public sbyte? Length { get; set; }
        public string? Active { get; set; }
        public string? Password { get; set; }
        public string? Readermode { get; set; }
        public string? Sendermode { get; set; }
        public string? Email { get; set; }
        public string? Branch { get; set; }
    }
}
