using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToDo.Model;
namespace ToDo.Repository
{
    public interface IToDoRepository
    {

       IEnumerable<Model.ToDo> GetAll();

       Model.ToDo Get(int Id);

       Task<bool> Put(Model.ToDo todo);

       Task<bool> Push(Model.ToDo todo);
    }

    public class ToDoRepository:IToDoRepository
    {
        private static List<Model.ToDo> ToDoCollection;
        public ToDoRepository()
        {
            ToDoCollection = new List<Model.ToDo>();
            ToDoCollection.Add(new Model.ToDo { Id = 1, Name = "Task 1", Status = true });
            ToDoCollection.Add(new Model.ToDo { Id = 1, Name = "Task 2", Status = true });
        }

        Model.ToDo IToDoRepository.Get(int Id)
        {
            var obj = ToDoCollection.Find(l => l.Id == Id);
            return obj;
        }

       IEnumerable<Model.ToDo> IToDoRepository.GetAll()
        {
            return ToDoCollection;
        }

        Task<bool> IToDoRepository.Push(Model.ToDo todo)
        {
            throw new NotImplementedException();
        }

        Task<bool> IToDoRepository.Put(Model.ToDo todo)
        {
            throw new NotImplementedException();
        }
    }
}
