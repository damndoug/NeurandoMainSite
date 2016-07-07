using System.Collections.Generic;
using Neurando.ViewModels;

namespace Neurando.Repositories
{
    public static class ProjectListData
    {
        public static List<ProjectViewModel> ProjectData { get; }
        
        static ProjectListData()
        {
            ProjectData = new List<ProjectViewModel>();

            ProjectData.Add(new ProjectViewModel 
            {
                ProjectName = "ipsic",
                ProjectTitle = "iPsic - Encontre um psicólogo a qualquer hora",
                ProjectCompany = "Neurando",
                ProjectUrl = "http://www.ipsic.com.br",
                ProjectBrief = "iPsic is a psychologists network that aims to reduce the gap between patients and therapists. This project is entirely built using new techs like asp net core. The project has a lot of useful tools either for professional or patients.",
                ProjectTechnologies = new List<string>
                {
                    "C#",
                    "Asp Net Core RC2",
                    "Microservices Structure",
                    "Angular JS",
                    "Vanilla JS",
                    "Bootstrap",
                    "Postgres",
                    "Ubuntu 14.04",
                    "Nginx",
                    "Digital Ocean",
                    "Visual Studio Code",
                    "OSX",
                    "Bash Script",
                    "SendGrid"
                },
                ProjectDuration = "7 months",
                ProjectTags = new List<string>
                {
                    "asp net core",
                    "postgres",
                    "c#",
                    "angular js"
                },
                ProjectImageUrl = "\"http://res.cloudinary.com/devneurando/image/upload/v1467832192/Neurando's%20Site/ipsic-full.png\"",
                ProjectYearRelease = 2016
            });

            ProjectData.Add(new ProjectViewModel
            {
                ProjectName = "kallos",
                ProjectTitle = "Kallos - Encontre um profissional de estética em sua região",
                ProjectCompany = "Neurando",
                ProjectUrl = "http://kallos.azurewebsites.net/",
                ProjectBrief = "Kallos is a non-functional professional aesthetics network that aims to reduce the gap between patients and aesthetics professionals. The project concept is entirely built using new techs like asp net core. The project has a lot of useful tools either for professional or clients.",
                ProjectTechnologies = new List<string>
                {
                    "C#",
                    "Asp Net Core RC2",
                    "Microservices Structure",
                    "Angular JS",
                    "Vanilla JS",
                    "Bootstrap",
                    "MySQL",
                    "Ubuntu 14.04",
                    "Nginx",
                    "Digital Ocean",
                    "Visual Studio Code",
                    "OSX",
                    "Bash Script",
                    "SendGrid"
                },
                ProjectDuration = "3 months",
                ProjectTags = new List<string>
                {
                    "asp net core",
                    "MySQL",
                    "c#",
                    "angular js"
                },
                ProjectImageUrl = "\"http://res.cloudinary.com/devneurando/image/upload/v1467832192/Neurando's%20Site/kallos-full.png\"",
                ProjectYearRelease = 2015
            });

            ProjectData.Add(new ProjectViewModel
            {
                ProjectName = "sanvalentino",
                ProjectTitle = "San Valentin - Bakery",
                ProjectCompany = "San Valentin",
                ProjectUrl = "http://sanvalentino.com.au/",
                ProjectBrief = "Neurando is responsible in transform the designer initial layout on client's needs, delivering just what San Valentin had expected from the project.",
                ProjectTechnologies = new List<string>
                {
                    "PHP",
                    "MVC Architecture",
                    "HTML",
                    "Vanilla JS",
                    "Bootstrap",
                    "MySQL",
                    "Ubuntu 14.04",
                    "Nginx",
                    "OSX",
                    "Sublime"
                },
                ProjectDuration = "3 months",
                ProjectTags = new List<string>
                {
                    "mysql",
                    "php",
                    "mvc"
                },
                ProjectImageUrl = "\"http://res.cloudinary.com/devneurando/image/upload/v1467832228/Neurando's%20Site/sanvalentino-full.png\"",
                ProjectYearRelease = 2016
            });

            ProjectData.Add(new ProjectViewModel
            {
                ProjectName = "austin-site",
                ProjectTitle = "Austin Felipe - Personal Portfolio",
                ProjectCompany = "Austin Felipe",
                ProjectUrl = "http://austinfelipe.com/",
                ProjectBrief = "",
                ProjectTechnologies = new List<string>
                {
                    "C#",
                    "Asp Net Core RC2",
                    "Microservices Structure",
                    "Angular JS",
                    "Vanilla JS",
                    "Bootstrap",
                    "MySQL",
                    "Ubuntu 14.04",
                    "Nginx",
                    "Digital Ocean",
                    "Visual Studio Code",
                    "OSX",
                    "Bash Script",
                    "SendGrid"
                },
                ProjectDuration = "3 months",
                ProjectTags = new List<string>
                {
                    "asp net core",
                    "MySQL",
                    "c#",
                    "angular js"
                },
                ProjectImageUrl = "\"http://res.cloudinary.com/devneurando/image/upload/v1467832191/Neurando's%20Site/austins-full.png\"",
                ProjectYearRelease = 2016
            });
            
            ProjectData.Add(new ProjectViewModel
            {
                ProjectName = "douglas-site",
                ProjectTitle = "Douglas Pires - Personal Portfolio",
                ProjectCompany = "Douglas Pires",
                ProjectUrl = "http://douglaspires.com/",
                ProjectBrief = "",
                ProjectTechnologies = new List<string>
                {
                    "C#",
                    "Asp Net Core RC2",
                    "Microservices Structure",
                    "Angular JS",
                    "Vanilla JS",
                    "Bootstrap",
                    "MySQL",
                    "Ubuntu 14.04",
                    "Nginx",
                    "Digital Ocean",
                    "Visual Studio Code",
                    "OSX",
                    "Bash Script",
                    "SendGrid"
                },
                ProjectDuration = "3 months",
                ProjectTags = new List<string>
                {
                    "asp net core",
                    "MySQL",
                    "c#",
                    "angular js"
                },
                ProjectImageUrl = "\"http://res.cloudinary.com/devneurando/image/upload/v1467832191/Neurando's%20Site/dougs-full.png\"",
                ProjectYearRelease = 2016
            });
            
            ProjectData.Add(new ProjectViewModel
            {
                ProjectName = "hot-product-finder",
                ProjectTitle = "Hot Product Finder",
                ProjectCompany = "Global 7",
                ProjectUrl = "http://hotproductfinder.com/",
                ProjectBrief = "Hot Product Finder is a ultimate all-in-one auction research software that uses e-Bay API to search for the best prices inside a category. You can also search for products in worldwide e-Bay domains.",
                ProjectTechnologies = new List<string>
                {
                    "Node Js",
                    "MVC 5",
                    "Angular JS",
                    "Bootstrap",
                    "SQL Server",
                    "Windows Server",
                    "Visual Studio 2013",
                },
                ProjectDuration = "2 months",
                ProjectTags = new List<string>
                {
                    "sql server",
                    "node js",
                    "angular js"
                },
                ProjectImageUrl = "\"http://res.cloudinary.com/devneurando/image/upload/v1467848766/Neurando's%20Site/HPF_Search.png\"",
                ProjectYearRelease = 2014
            });


        }
    }
}