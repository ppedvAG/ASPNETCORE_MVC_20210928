using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace GuestBookApp.Models
{
    public class GuestBookEntry
    {
        public int Id { get; set; }

        [DisplayName("Geästebucheinträge")]
        public string Text { get; set; }
    }
}
