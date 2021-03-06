﻿using Libs.Domain;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domains.Entity;
using TodoApp.Domains.Repository;
using TodoApp.Domains.Factory;

namespace TodoApp.Apps.Service.Impl
{
    public class TodoServiceImpl : ITodoService
    {
        private TodoRepository repository = new TodoRepository();
        private TodoFactory factory = new TodoFactory();

        public TodoModel Create(string title)
        {
            return factory.Create(title);
        }

        public void Delete(TodoModel todo)
        {
            repository.Delete(todo);
        }

        public TodoList GetAll()
        {
            return repository.AsEntitiesList();
        }

        public void Store(TodoModel todo)
        {
            repository.Store(todo);
        }
    }
}
