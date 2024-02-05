using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01, "Arthur A.Ferreira", "857.032.950-41", "arthur.antunes@sp.senai.br", "Madruga");
        Cliente cliente2 = new Cliente(02, "William", "123.456.123-11", "111@sp.senai.br", "Jorge");
        Cliente cliente3 = new Cliente(03, "Ada", "111.111.222-33", "222@sp.senai.br", "1234");
        Cliente cliente4 = new Cliente(04, "Byron", "555.444.444-44", "333@sp.senai.br", "Felas");
        Cliente cliente5 = new Cliente(05, "Grace", "666.666.777-77", "444@sp.senai.br", "Vult");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A", "14.182.102/0001-80", "c.sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "111", "33.222.111/0001-80", "444@pet.org");
        Fornecedor fornecedor3 = new Fornecedor(03, "222", "44.182.102/0001-80", "333@pet.org");
        Fornecedor fornecedor4 = new Fornecedor(04, "333A", "14.555.666/0001-80", "222@pet.org");
        Fornecedor fornecedor5 = new Fornecedor(05, "C4444/A", "33.777.102/666-80", "111@pet.org");


        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);
        
        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
