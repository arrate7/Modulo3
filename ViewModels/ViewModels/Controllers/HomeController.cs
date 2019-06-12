using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModels.Models;

namespace ViewModels.Controllers
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
        public IActionResult Agenda(string tipo, string busqueda)
        {

            Agenda a1 = new Agenda
            {
                Propietario = "Arrate",
                //FechaCreacion = new DateTime(2017,3,12)
                //FechaCreacion = DateTime.Today
                FechaCreacion = Convert.ToDateTime("22/09/2017")
            };

            Contacto c1 = new Contacto
            {
                Nombre = "Arrate",
                Apellido = "Ortiz de Zarate",
                Imagen = "~/img/contact.png",
                Tipo = "Familia",
                Telefono = "8273728282"

            };
            Contacto c2 = new Contacto
            {
                Nombre = "Arrate",
                Apellido = "Ortiz de Zarate",
                Imagen = "~/img/contact.png",
                Tipo = "Familia",
                Telefono = "8273728282"

            };
            Contacto c3 = new Contacto
            {
                Nombre = "Arrate",
                Apellido = "Ortiz de Zarate",
                Imagen = "~/img/contact.png",
                Tipo = "Amigos",
                Telefono = "8273728282"

            };
            Contacto c4 = new Contacto
            {
                Nombre = "Arrate",
                Apellido = "Ortiz de Zarate",
                Imagen = "~/img/contact.png",
                Tipo = "Amigos",
                Telefono = "8273728282"

            };
            Contacto c5 = new Contacto
            {
                Nombre = "Arrate",
                Apellido = "Ortiz de Zarate",
                Imagen = "~/img/contact.png",
                Tipo = "Trabajo",
                Telefono = "8273728282"

            };
            Contacto c6 = new Contacto
            {
                Nombre = "Arrate",
                Apellido = "Ortiz de Zarate",
                Imagen = "~/img/contact.png",
                Tipo = "Trabajo",
                Telefono = "8273728282"

            };
            List<Contacto> contactos = new List<Contacto>()
            {
                c1,c2,c3,c4,c5,c6
            };

            if (tipo == "Familia")
            {
                contactos = contactos.Where(x => x.Tipo == "Familia").ToList();
            }
            else if (tipo == "Amigos")
            {
                contactos = contactos.Where(x => x.Tipo == "Amigos").ToList();
            }
            else if (tipo == "Trabajo")
            {
                contactos = contactos.Where(x => x.Tipo == "Trabajo").ToList();
            }

            AgendaContactoVM ac1 = new AgendaContactoVM
            {
                Agenda = a1,
                Contactos = contactos
            };

            return View(ac1);
        }







        public IActionResult Animales()
        {
            Animal a1 = new Animal
            {
                Nombre = "Perro",
                NombreCientifico = "Canis Canis",
                Imagen = ""
            };
            Animal a2 = new Animal
            {
                Nombre = "Caballo",
                NombreCientifico = "Caballus Maximus",
                Imagen = ""
            };
            Animal a3 = new Animal
            {
                Nombre = "Gato",
                NombreCientifico = "Felix Felix",
                Imagen = ""
            };
            List<Animal> animales = new List<Animal>()
            {
                a1,a2,a3
            };






            Familia f1 = new Familia
            {
                Nombre = "Mamífero"
            };

            FamiliaAnimalViewModel fa1 = new FamiliaAnimalViewModel
            {
                Familia = f1,
                Animales = animales
            };



            return View(fa1);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
