using Microsoft.EntityFrameworkCore;

namespace toDoList
{
    public class ApplicationDb : DbContext
    {
        public ApplicationDb(DbContextOptions<ApplicationDb> options) : base(options)
        {

        }

        public DbSet<ToDoListModel> ToDoListData { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ToDoListMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
