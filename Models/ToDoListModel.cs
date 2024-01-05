using System;
using System.ComponentModel.DataAnnotations;

namespace toDoList;

public class ToDoListModel
{
    public int id { get; set; }
    [Required]
    public string taskName { get; set; }
    public bool status { get; set; }
}
