﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace DPizza.Models.Data
{
    public partial class User
    {
        public User()
        {
            Purchse = new HashSet<Purchse>();
        }

        public int UserId { get; set; }
        public int? TitleId { get; set; }
        public string UserName { get; set; }
        public string UserLastname { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public string UserAddress { get; set; }

        public virtual Title Title { get; set; }
        public virtual ICollection<Purchse> Purchse { get; set; }
    }
}