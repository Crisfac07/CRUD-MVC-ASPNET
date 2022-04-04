using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDCORE.Datos;
using CRUDCORE.Models;

namespace CRUDCORE.Controllers
{
    public class mantenedorController : Controller
    {
        ContactoDatos _ContactoDatos = new ContactoDatos();
        public IActionResult Listar()
        {
            //La VISTA MOSTRARÁ UNA LISTA DE CONTACTOS
            var oLista = _ContactoDatos.Listar();
            return View(oLista);
        }

        public IActionResult Guardar()
        {
            //MÉTODO SOLO DEVUELVE LA VISTA
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(ContactoModel oContacto)
        {
            if (!ModelState.IsValid)
                return View();
            //METODO RECIBE EL OBJETO PARA GUARDARLO EN BD
            var respuesta = _ContactoDatos.Guardar(oContacto);
            if (respuesta)
               return RedirectToAction("Listar");
            else
                return View();
        }


        public IActionResult Editar(int idContacto)
        {
            //MÉTODO SOLO DEVUELVE LA VISTA
            var contacto = _ContactoDatos.Obtener(idContacto);
            return View(contacto);
        }

        [HttpPost]
        public IActionResult Editar(ContactoModel oContacto)
        {
            if (!ModelState.IsValid)
                return View();
            //METODO RECIBE EL OBJETO PARA GUARDARLO EN BD
            var respuesta = _ContactoDatos.Editar(oContacto);
            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }

        public IActionResult Eliminar(int idContacto) {
            var contacto = _ContactoDatos.Obtener(idContacto);
            return View(contacto);
        }

        [HttpPost]
        public IActionResult Eliminar(ContactoModel oContacto)
        {
            var respuesta = _ContactoDatos.Eliminar(oContacto.IdContacto);
            if (respuesta)
                return RedirectToAction("Listar");
            else
                return View();
        }

    }
}
