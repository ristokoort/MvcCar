﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcCar.Data;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace MvcCar.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcCarContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcCarContext>>()))
            {
                if (context.Car.Any())
                {
                    return;  
                }
                context.Car.AddRange(
                  new Car
                  {
                      Name = "Smallcar",
                      Color = "Yellow",
                      Speed = 100,
                      Condition ="Brand New"


                  },
                   new Car
                   {
                       Name = "Bigcar",
                       Color = "Green",
                       Speed = 110,
                       Condition = "Used/refurbished"
                   },
                    new Car
                    {
                        Name = "Truck",
                        Color = "Yellow",
                        Speed = 90,
                        Condition = "used"
                    },
                      new Car
                      {
                          Name = "Clowncar",
                          Color = "Red",
                          Speed = 60,
                          Condition = " Brand New"
                      }


                ) ;
                context.SaveChanges();
                if (context.Car.Any())
                {
                    return;  
                }
            }
        }
    }
}