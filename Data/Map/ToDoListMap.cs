using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace toDoList;

public class ToDoListMap : IEntityTypeConfiguration<ToDoListModel>
{
    public void Configure(EntityTypeBuilder<ToDoListModel> builder)
    {
        builder.HasKey(x => x.id);
        builder.Property(x => x.taskName).IsRequired().HasMaxLength(255);
        builder.Property(x => x.status).IsRequired();
    }
}
