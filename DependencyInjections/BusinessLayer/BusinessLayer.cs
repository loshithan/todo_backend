using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using todo_backend.Models;

namespace todo_backend.DependencyInjections
{
    public class BusinessLayer : IBusinessLayer
    {
        private readonly IDataAccessLayer _dataAccessLayer;
        public BusinessLayer(IDataAccessLayer dataAccessLayer)
        {
            _dataAccessLayer = dataAccessLayer;
        }
        public void AddTodo(Todo todo)
        {
            if(todo == null)
            {
                throw new ArgumentNullException("todo doesn't exist");
            }
            _dataAccessLayer.CreateTodo(todo);

        }

        public void EditTodo(int id, Todo todo)
        {
            if (todo == null || id==null)
            {
                throw new ArgumentNullException("todo or id doesn't exist");
            }
            _dataAccessLayer.UpdateTodo(id, todo);
        }

        public IEnumerable<Todo> GetAllTodo()
        {
            return _dataAccessLayer.GetTodos();
        }

        public void RemoveTodo(int id)
        {
            if (id == null)
            {
                throw new ArgumentNullException("todo or id doesn't exist");
            }
            _dataAccessLayer.DeleteTodo(id);
        }
    }
}