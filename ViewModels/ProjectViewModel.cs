using System.Collections.Generic;

namespace Neurando.ViewModels
{
    public class ProjectViewModel
    {
        public string ProjectName { get; set; }
        public string ProjectTitle { get; set; }
        public string ProjectCompany { get; set; }
        public string ProjectUrl { get; set; }
        public string ProjectBrief { get; set; }
        public List<string> ProjectTechnologies { get; set; }
        public string ProjectDuration { get; set; }
        public List<string> ProjectTags { get; set; }
        public string ProjectImageUrl { get; set; }
        public int ProjectYearRelease { get; set; }
    }
}