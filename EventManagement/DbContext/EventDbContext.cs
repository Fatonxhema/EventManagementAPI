using System;
using Microsoft.EntityFrameworkCore;

/// <summary>
/// Summary description for Class1
/// </summary>
public class EventDbContext : DbContext
{
	public EventDbContext(DbContextOptions options):base(options)
	{
	}
	DbSet<Event> Events { get; set; }
}
