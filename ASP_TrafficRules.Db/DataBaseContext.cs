using ASP_TrafficRules.Db.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASP_TrafficRules.Db
{
	public class DataBaseContext : DbContext
	{
		// Доступ к таблицам

		public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionOptions> QuestionOptions { get; set; }


        public DataBaseContext(DbContextOptions<DataBaseContext> options)
			:base(options)
		{
			Database.EnsureCreated(); // создаем базу данных при перовм обращении
		}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Настройка связи между Question и Option
            modelBuilder.Entity<Question>()
                .HasMany(q => q.Options)
                .WithOne(o => o.Question)
                .HasForeignKey(o => o.QuestionId);
        }
    }
}
