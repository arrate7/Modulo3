using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrimeraApp.Models;

namespace PrimeraApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
         
            return View();
        }

        public IActionResult Contacto()
        {
            Animal a1 = new Animal
            {
                Especie = "Cannis Lupus",
                Genero = "Cannis",
                Familia = "Cánido",
                Imagen = "~/imagenes/fotos-de-canis-lupus.jpg"
            };

            return View(a1);
        }
        public IActionResult Animales()
        {
            Animal a1 = new Animal
            {
                Especie = "Cannis Lupus",
                Genero = "Cannis",
                Familia = "Cánido",
                Imagen = "~/imagenes/fotos-de-canis-lupus.jpg"
            };
            Animal a2 = new Animal
            {
                Especie = "Felix Felix",
                Genero = "Felix",
                Familia = "Gato",
                Imagen = "https://www.purina.es/gato/purina-one/sites/g/files/mcldtz1856/files/2018-06/Mi_gato_no_come%20%282%29.jpg"
            };
            Animal a3 = new Animal
            {
                Especie = "Loxodonta Africana",
                Genero = "Elefas",
                Familia = "Elefantidae",
                Imagen = "https://ichef.bbci.co.uk/news/660/cpsprodpb/AACD/production/_102952734_elefante.jpg"
            };

            List<Animal> animales = new List<Animal>()
            {
                a1,a2,a3
            };

            return View(animales);
        }
        public IActionResult About()
        {
            ViewData["nombre"] = "Arrate";
            ViewData["edad"] = 25;

            List<string> compras = new List<string>()
            {
                "huevos","peras","pasta","pechuga","yogures"
            };

            ViewData["compras"] = compras;


            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
