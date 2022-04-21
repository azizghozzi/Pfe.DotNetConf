using Ardalis.Specification;
using Pfe.DotNetConf.Core.ProjectAggregate;

namespace Pfe.DotNetConf.Core.ProjectAggregate.Specifications;

public class ProjectByIdWithItemsSpec : Specification<Project>, ISingleResultSpecification
{
  public ProjectByIdWithItemsSpec(int projectId)
  {
    Query
        .Where(project => project.Id == projectId)
        .Include(project => project.Items);
  }
}
