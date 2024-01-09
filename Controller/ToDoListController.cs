using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace toDoList
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListController : ControllerBase
    {
        private readonly IToDoListRepository _toDoListRepository;

        public ToDoListController(IToDoListRepository toDoListRepository)
        {
            _toDoListRepository = toDoListRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<ToDoListModel>>> GetTaskAsync()
        {
            List<ToDoListModel> tasks = await _toDoListRepository.GetAllAsync();
            return Ok(tasks);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ToDoListModel>> GetByIdAsync(int id)
        {
            ToDoListModel task = await _toDoListRepository.GetByIdAsync(id);
            return Ok(task);
        }

        [HttpPost]
        public async Task<ActionResult<ToDoListModel>> Create([FromBody] ToDoListModel task)
        {
            ToDoListModel taskCreate = await _toDoListRepository.CreateAsync(task);
            return Ok(taskCreate);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<ToDoListModel>> Update([FromBody] ToDoListModel task, [FromRoute] int id)
        {
            ToDoListModel taskUpdate = await _toDoListRepository.UpdateAsync(task, id);
            return Ok(taskUpdate);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<ToDoListModel>> Delete([FromRoute] int id)
        {
            bool result = await _toDoListRepository.DeleteOneAsync(id);
            return Ok(result);
        }
    }
}

