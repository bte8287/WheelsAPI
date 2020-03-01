using System;
using WheelsAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WheelsAPI.Data
{
	public class WheelsDBContext : DbContext
	{
		public WheelsDBContext(DbContextOptions<WheelsDBContext> options) : base(options)
		{
		}
		public DbSet<Vehicle> Vehicles { get; set; }
	}
}
