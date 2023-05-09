using Microsoft.AspNetCore.Mvc;
using TP4.Models;

namespace TP4.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.dicEquiposIndumentaria = Equipos.EquiposIndumentaria;
        return View();
    }

    public IActionResult SelectIndumentaria()
    {
        ViewBag.ListaEquipos = Equipos.ListaEquipos;
        ViewBag.ListaMedias = Equipos.ListaMedias;
        ViewBag.ListaPantalones = Equipos.ListaPantalones;
        ViewBag.ListaRemeras = Equipos.ListaRemeras;
        return View();
    }

    public IActionResult GuardarIndumentaria(int equipo, int media, int pantalon, int remera)
    {
        if (equipo == 0 || media == 0 || pantalon == 0 || remera == 0)
        {
            ViewBag.Error = "Debes seleccionar una opcion de cada lista";
            return View("SelectIndumentaria");
        }
        else
        {
            ViewBag.ListaEquipos = Equipos.ListaEquipos;
            ViewBag.ListaMedias = Equipos.ListaMedias;
            ViewBag.ListaPantalones = Equipos.ListaPantalones;
            ViewBag.ListaRemeras = Equipos.ListaRemeras;
            equipo -= 1;
            media -= 1;
            pantalon -= 1;
            remera -= 1;
            Indumentaria seleccion = new Indumentaria(Equipos.ListaMedias[media], Equipos.ListaPantalones[pantalon], Equipos.ListaRemeras[remera]);
            bool pudoIngresar = Equipos.IngresarIndumentaria(Equipos.ListaEquipos[equipo], seleccion);
            if (pudoIngresar)
            {
                ViewBag.dicEquiposIndumentaria = Equipos.EquiposIndumentaria;
                return View("Index");
            }
            else
            {
                ViewBag.Error = "Ya usaste ese equipo";
                return View("SelectIndumentaria");
            }
        }
    }
}