using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace toDoList;

public interface IToDoListRepository
{
    Task<List<ToDoListModel>> GetAllAsync();
    Task<ToDoListModel> GetByIdAsync(int id);
    Task<ToDoListModel> CreateAsync(ToDoListModel toDoList);
    Task<ToDoListModel> UpdateAsync(ToDoListModel toDoList, int id);
    Task<bool> DeleteOneAsync(int id);
    Task<bool> DeleteAllAsync();
}
