using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiClass.Model.Entities;

namespace WebApiClass.Api.Configurations
{
    public class DatabaseSeeder
    {
        public static void Seed(WebApiContext context)
        {
            context.Database.Migrate();
        }
    }
}
