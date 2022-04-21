using Ardalis.Result;
using Pfe.DotNetConf.Core.ProjectAggregate;

namespace Pfe.DotNetConf.Core.Interfaces;

public interface IToDoItemSearchService
{
  Task<Result<ToDoItem>> GetNextIncompleteItemAsync(int projectId);
  Task<Result<List<ToDoItem>>> GetAllIncompleteItemsAsync(int projectId, string searchString);
}
