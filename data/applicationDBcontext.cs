using Microsoft.EntityFrameworkCore;
using Studentt_Teacer_Crud.Models;
namespace Studentt_Teacer_Crud.data;
    public class ApplicationDBContext: DbContext {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options){

    }

    public DbSet<Student> Student { get; set; }
    public DbSet<Subject> Subject { get; set; }

    public DbSet<Teacher> Teacher {get; set;}


    }
