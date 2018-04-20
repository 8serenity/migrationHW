using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efCodeFirst
{
    public class Car
    {
        public int Id { get; set; }
        public string RegistrationNumber { get; set; }
        [ForeignKey("Owner")]
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
        public string Color { get; set; }
    }
}
