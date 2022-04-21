using Pfe.DotNetConf.Core.ProjectAggregate;
using Pfe.DotNetConf.SharedKernel;

namespace Pfe.DotNetConf.Core.ProjectAggregate.Events;

public class ToDoItemCompletedEvent : BaseDomainEvent
{
  public ToDoItem CompletedItem { get; set; }

  public ToDoItemCompletedEvent(ToDoItem completedItem)
  {
    CompletedItem = completedItem;
  }
}
