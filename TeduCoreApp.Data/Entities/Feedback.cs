using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TeduCoreApp.Infrastructure.SharedKernel;
using TeduCoreApp.Data.Interfaces;
using TeduCoreApp.Data.Enums;

namespace TeduCoreApp.Data.Entities
{
    [Table("Feedbacks")]
    public class Feedback : DomainEntity<int>, ISwitchable, IDateTracking
    {
        [StringLength(250)]
        [Required]
        public string Name { set; get; }

        [StringLength(250)]
        public string Email { set; get; }

        [StringLength(500)]
        public string Message { set; get; }

        public DateTime DateCreated {get;set;}
        public DateTime DateModified {get;set;}
        public Status Status {get;set;}
    }
}
