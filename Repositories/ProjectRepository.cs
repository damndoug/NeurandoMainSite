using System.Linq;
using Neurando.Repositories;
using Neurando.ViewModels;

namespace Neurando.Repository
{
    public class ProjectRepository
    {
        public ProjectViewModel GetProject(string projectName)
        {
            var project = ProjectListData
                .ProjectData
                .Where(t => t.ProjectName == projectName)
                .FirstOrDefault();
            
            return project;
        }
    }
}