﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_PracticeExam2020
{
    public class Phone
    {
        [Key]
        public string Name { get; set; }

        public string OperatingSystem { get; set; }
        public string OSImage { get; set; }
        public string PhoneImage { get; set; }
        public double Price { get; set; }

        public void IncreasedPrice(double PriceUp = 0.2)
        {


           // if(Name != null)
            //{
           //     PriceUp = Price * PriceUp;
          //      Price = Price + PriceUp;
          //  }

        }
        public class PhoneData : DbContext
        {
            public PhoneData() : base("MyPhoneData") { }

            public DbSet<Phone> Name { get; set; }
            public DbSet<Phone> OperatingSystem { get; set; }
            public DbSet<Phone> OSImage { get; set; }
            public DbSet<Phone> PhoneImage { get; set; }
            public DbSet<Phone> Price { get; set; }
        }
    }
}
