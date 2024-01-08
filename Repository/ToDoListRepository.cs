using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace toDoList;

public class ToDoListRepository : IToDoListRepository
{

    private readonly ApplicationDb _dbContext;

    public ToDoListRepository(ApplicationDb applicationDb)
    {
        _dbContext = applicationDb;
    }

    public async Task<ToDoListModel> CreateAsync(ToDoListModel toDoList)
    {
        await _dbContext.ToDoListData.AddAsync(toDoList);
        await _dbContext.SaveChangesAsync();
        return toDoList;
    }

    public async Task<bool> DeleteAllAsync()
    {
        List<ToDoListModel> tasks = await GetAllAsync();
        if (tasks.Count == 0)
        {
            return false;
        }
        _dbContext.ToDoListData.RemoveRange(tasks);
        await _dbContext.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteOneAsync(int id)
    {
        ToDoListModel taskId = await GetByIdAsync(id);
        if (taskId == null)
        {
            throw new Exception("Tarefa nao encontrada");
        }
        _dbContext.ToDoListData.Remove(taskId);
        await _dbContext.SaveChangesAsync();

        return true;
    }

    public async Task<List<ToDoListModel>> GetAllAsync()
    {
        return await _dbContext.ToDoListData.ToListAsync();
    }

    public async Task<ToDoListModel> GetByIdAsync(int id)
    {
        return await _dbContext.ToDoListData.FirstOrDefaultAsync(x => x.id == id);
    }

    public async Task<ToDoListModel> UpdateAsync(ToDoListModel toDoList, int id)
    {
        ToDoListModel taskId = await GetByIdAsync(id);
        if (taskId == null)
        {
            throw new Exception("Tarefa nao encontrado");
        }
        taskId.taskName = toDoList.taskName;
        taskId.status = toDoList.status;
        _dbContext.ToDoListData.Update(taskId);
        await _dbContext.SaveChangesAsync();
        return taskId;
    }
}
