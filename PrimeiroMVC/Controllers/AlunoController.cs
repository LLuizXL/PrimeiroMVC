using Microsoft.AspNetCore.Mvc;
using PrimeiroMVC.Models;

namespace PrimeiroMVC.Controllers
{
    public class AlunoController : Controller
    {

        public IActionResult Index()
        {
            Aluno a1 = new Aluno(1, "Luiz Guilherme Vieira de Melo", "luiz.mwlo76@gmail.com", 112349);
            Aluno a2 = new Aluno(1, "Walter Hardwell White", "walterwhite@gmail.com", 095471);
            Aluno a3 = new Aluno(1, "Mitch Sorrestein", "muscleman6@gmail.com", 850217);
            Aluno a4 = new Aluno(1, "Paul Diddy", "PDiddy@gmail.com", 766918);
            Aluno a5 = new Aluno(1, "Drake", "champagnepapi@gmail.com", 021735);

            //Criar uma lista de Alunos
            List<Aluno> listaAlunos = new List<Aluno>();
            //Adicionar os Objetos Alunos na Lista Alunos
            listaAlunos.Add(a1);
            listaAlunos.Add(a2);
            listaAlunos.Add(a3);
            listaAlunos.Add(a4);
            listaAlunos.Add(a5);


            //Enviando a lista de Alunos por parametro na View Index
            return View(listaAlunos);
        }
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
