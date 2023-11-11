using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using todo_backend.Models;

namespace todo_backend.DependencyInjections
{
    //repository to connect database
    public class DataAccessLayer : IDataAccessLayer
    {
        private TodoContext _todoContext;

        public DataAccessLayer(TodoContext todoContext)
        {
            _todoContext = todoContext;

        }

        public void CreateTodo(Todo todo)
        {
            _todoContext.Todos.Add(todo);
            _todoContext.SaveChanges();
        }

        public void DeleteTodo(int id)
        {
            Todo todo = _todoContext.Todos.FirstOrDefault(x => x.Id == id);
            _todoContext.Todos.Remove(todo);
            _todoContext.SaveChanges();
        }

        public IEnumerable<Todo> GetTodos()
        {
            return _todoContext.Todos.ToList();
        }

        public void UpdateTodo(int id, Todo todo)
        {
            Todo foundTodo = _todoContext.Todos.FirstOrDefault(x => x.Id == id);
            foundTodo.IsCompleted = todo.IsCompleted;
            
            _todoContext.SaveChanges();

        }
    }
}