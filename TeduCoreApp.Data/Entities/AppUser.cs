﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TeduCoreApp.Data.Enums;
using TeduCoreApp.Data.Interfaces;

namespace TeduCoreApp.Data.Entities
{
    [Table("AppUsers")]
    public class AppUser : IdentityUser<Guid>, IDateTracking, ISwitchable
    {
        public string FullName { get; set; }
        public DateTime? Birthday { get; set; }
        public decimal Balance { get; set; }
        public string Avatar { get; set; }
        public Status Status {get;set;}
        public DateTime DateCreated {get;set;}
        public DateTime DateModified {get;set;}
    }
}
