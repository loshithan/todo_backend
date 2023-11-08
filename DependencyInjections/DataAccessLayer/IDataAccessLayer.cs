using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using todo_backend.Models;

namespace todo_backend.DependencyInjections
{
    public interface IDataAccessLayer
    {
         IEnumerable<Todo> GetTodos();

        void CreateTodo(Todo todo);

        void UpdateTodo(int id,Todo todo);

        void DeleteTodo(int id);
    }
}
