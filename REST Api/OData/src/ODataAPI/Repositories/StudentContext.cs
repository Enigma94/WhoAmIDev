using Microsoft.EntityFrameworkCore;
using ODataAPI.Models;

namespace ODataAPI.Infrastructure
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}
