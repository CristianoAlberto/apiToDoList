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
            base.OnModelCreating(modelBuilder);

            // Adicione aqui eventuais configurações adicionais do modelo
        }
    }
}
