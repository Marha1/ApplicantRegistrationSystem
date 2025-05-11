using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ApplicantRegistrationSystem.DataBase
{
    public class AbiturientContextFactory
    {
        public AbiturientContext CreateDbContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AbiturientContext>();
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // Указываем путь к папке проекта
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            string connectionString = configuration.GetConnectionString("DefaultConnection");

            optionsBuilder.UseNpgsql(connectionString);
            return new AbiturientContext(optionsBuilder.Options);
        }
    }
}
