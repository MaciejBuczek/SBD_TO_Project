using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SBD_TO_Project.Models
{
    public class ScheduleEntry
    {
        [Key]
        public int Id { get; set; }
        public DateTime Time { get; set; }
        
        public int? IdMovie { get; set; }
        [ForeignKey("IdMovie")]
        public virtual Movie Movie { get; set; }
        
        public int? IdSchedule { get; set; }
        [ForeignKey("IdSchedule")]
        public virtual Schedule Schedule { get; set; }
        
        public int? IdScreeningRoom { get; set; }
        [ForeignKey("IdScreeningRoom")]
        public virtual ScreeningRoom ScreeningRoom { get; set; }
    }
}
