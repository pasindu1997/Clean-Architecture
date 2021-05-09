using Boomerang.Employee.Application.Common.Mappings;
using Boomerang.Employee.Domain.Entities;

namespace Boomerang.Employee.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
