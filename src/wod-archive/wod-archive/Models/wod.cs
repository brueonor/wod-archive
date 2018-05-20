using System;
using System.Collections.Generic;

namespace wod_archive.Models
{
    public class Wod
    {
        public Guid Id { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public List<string> Score { get; set; } = new List<string>();

    }
}