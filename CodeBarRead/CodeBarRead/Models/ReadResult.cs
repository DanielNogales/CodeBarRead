using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBarRead.Models
{
    public class ReadResult
    {
        public DateTime Date { get; set; }
        public string Format { get; set; }
        public string Value { get; set; }
        public string Device { get; set; }
    }
}
