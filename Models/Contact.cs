using System;
using System.Collections.Generic;

namespace TestCoreEF.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public DateTime Birth { get; set; }
        public Genre Genre { get; set; }
        public bool Active { get; set; }
        public List<Address> Addresses { get; set; }
        
    }
}