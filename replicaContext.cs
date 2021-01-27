using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TodoApi.Models;

namespace TodoApi
{
	public partial class replicaContext : DbContext
	{
		public virtual DbSet<Category> Category { get; set; }

		public replicaContext(DbContextOptions<replicaContext> options) : base(options)
		{ }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
		}
	}
}
