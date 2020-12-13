using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace SBD_TO_Project.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string Alias { get; set; }
        [ForeignKey("Person")]
        public int IdPerson { get; set; }
    }
}
