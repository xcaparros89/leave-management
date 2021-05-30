using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Models
{
    //Pots tenir diferents models de la mateixa taula per utilitzar a diferents views pero tots necesiten la primary key
    //public class DetailsLeaveTypeVM
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    [Display(Name = "Date Created")]
    //    public DateTime DateCreated { get; set; }
    //}
    //public class CreateLeaveTypeVM
    //{
    //    public int Id { get; set; }
    //    [Required]
    //    public string Name { get; set; }
    //}
    public class LeaveTypeVM
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "Date Created")]
        public DateTime? DateCreated { get; set; }
    }
}
