using System;

namespace employeetime.Common.Models
{
    internal class RegisterTime
    {
        public int Employee { get; set; }

        public DateTime Date { get; set; }

        public int Type { get; set; }

        public bool Consolidated { get; set; }

    }
}
