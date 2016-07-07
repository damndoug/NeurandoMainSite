using Microsoft.AspNetCore.Mvc;
using Neurando.Repository;

namespace Neurando.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Detail(string projectName) 
        {
            // cria um novo rep de projetos
            var projectRepository = new ProjectRepository();
            // 1 - Dentro do rep tem uma função chamada GetProject que recebe como param o nome do projeto
            // 2 - Carrega as informações do projeto (Busca dentro de uma lista de projetos. Ex: List<Projeto>)
            // 2.1 - var project = listaDeProjetos.Where(t => t.ProjectName == projectName).FirstOrDefault();
            // 3 - Retorna o ViewModel do projeto com as informações preenchidas
            var project = projectRepository.GetProject(projectName);

            return View(project);
        }
    }
}