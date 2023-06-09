using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class InterviewsDbContext: DbContext
{
    public InterviewsDbContext(DbContextOptions<InterviewsDbContext> options) : base(options)
    {
        
    }

    public DbSet<Interviewer> Interviewers { get; set; }
    public DbSet<Interview> Interviews { get; set; }
    public DbSet<InterviewTypeLookUp> InterviewTypeLookUps { get; set; }
}