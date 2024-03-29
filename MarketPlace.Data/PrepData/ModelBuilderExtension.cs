﻿using MarketPlace.Data.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Data.PrepData
{
    public class ModelBuilderExtension
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<State>().HasData(

                //new State { Id =1, CountryId = 166, Name = "Not Available", StateCode = "N/A", CreatedDate = DateTime.Now, CreatedBy = "Atlas", ModifiedBy = null, LastModified = null, },
                new State { Id = 1, Name = "Akwa Ibom", StateCode = "01", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 2, Name = "Anambra", StateCode = "02", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 3, Name = "Bauchi", StateCode = "03", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 4, Name = "Adamawa", StateCode = "04", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 5, Name = "Benue", StateCode = "05", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 6, Name = "Borno", StateCode = "06", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 7, Name = "Cross River", StateCode = "07", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 8, Name = "FCT", StateCode = "08", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 9, Name = "Delta", StateCode = "09", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 10, Name = "Imo", StateCode = "10", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 11, Name = "Kaduna", StateCode = "11", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 12, Name = "Kano", StateCode = "12", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 13, Name = "Katsina", StateCode = "13", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 14, Name = "Kwara", StateCode = "14", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 15, Name = "Lagos", StateCode = "15", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 16, Name = "Niger", StateCode = "16", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 17, Name = "Ogun", StateCode = "17", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 18, Name = "Ondo", StateCode = "18", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 19, Name = "Oyo", StateCode = "19", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 20, Name = "Plateau", StateCode = "20", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 21, Name = "Rivers", StateCode = "21", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 22, Name = "Sokoto", StateCode = "22", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 23, Name = "Abia", StateCode = "23", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 24, Name = "Edo", StateCode = "24", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 25, Name = "Enugu", StateCode = "25", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 26, Name = "Jigawa", StateCode = "26", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 27, Name = "Kebbi", StateCode = "27", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 28, Name = "Kogi", StateCode = "28", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 29, Name = "Osun", StateCode = "29", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 30, Name = "Taraba", StateCode = "30", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 31, Name = "Yobe", StateCode = "31", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 32, Name = "Bayelsa", StateCode = "32", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 33, Name = "Ebonyi", StateCode = "33", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 34, Name = "Ekiti", StateCode = "34", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 35, Name = "Gombe", StateCode = "35", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 36, Name = "Nassarawa", StateCode = "36", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new State { Id = 37, Name = "Zamfara", StateCode = "37", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, }
            );


            modelBuilder.Entity<ProductType>().HasData(

                new ProductType { Id = 1, Name = "Vehicles", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new ProductType { Id = 2, Name = "Properties", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new ProductType { Id = 3, Name = "Mobile Gadgets", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new ProductType { Id = 4, Name = "Electronics", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new ProductType { Id = 5, Name = "Home Appliances",  CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new ProductType { Id = 6, Name = "Cosmetics/Beauty",  CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new ProductType { Id = 7, Name = "Fashion", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new ProductType { Id = 8, Name = "Sports",  CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new ProductType { Id = 9, Name = "Outdoor Equipment",  CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new ProductType { Id = 10, Name = "Jobs", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new ProductType { Id = 11, Name = "Babies/Toys",  CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new ProductType { Id = 12, Name = "Pets", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new ProductType { Id = 13, Name = "Agriculture",  CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new ProductType { Id = 14, Name = "Workman",  CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, }
            );


            modelBuilder.Entity<ProductCondition>().HasData(

                new ProductCondition { Id = 1, Name = "Brand New", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new ProductCondition { Id = 2, Name = "Foreign Use", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new ProductCondition { Id = 3, Name = "Fairly Used", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new ProductCondition { Id = 4, Name = "Really Used", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, }
                );

            modelBuilder.Entity<ProductCategory>().HasData(

                new ProductCategory { Id = 1, Name = "Edible", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new ProductCategory { Id = 2, Name = "Mechanical", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new ProductCategory { Id = 3, Name = "Electrical", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new ProductCategory { Id = 4, Name = "Wooden", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, },
                new ProductCategory { Id = 5, Name = "Ceramic", CreatedDate = DateTime.Now, CreatedBy = "System", ModifiedBy = null, LastModified = null, }

                );
        }
    }
}
