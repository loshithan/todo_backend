using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using todo_backend.Models;

namespace todo_backend.DependencyInjections
{
    public interface IBusinessLayer
    {
        void AddTodo(Todo todo);
        void RemoveTodo(int id);

        void EditTodo(int id,Todo todo);

        IEnumerable<Todo> GetAllTodo();
    }
}
