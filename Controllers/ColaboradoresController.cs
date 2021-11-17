using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCrud.Models;

namespace MVCCrud.Controllers
{
    public class ColaboradoresController : Controller
    {
        // GET: Colaboradores
        public ActionResult Index()
        {
            List<ListColaboradoresModel> lst;

            using (Crud_App_EspEntities db = new Crud_App_EspEntities())
            {
                var lst = (from d in db.Colaboradores
                           select new ListColaboradoresModel
                           {
                               ID_Colaborador = d.ID_Colaborador,
                               Nombres = d.Nombres,
                               Apellidos = d.Apellidos,
                               FechaNacimiento = d.FechaNacimiento,
                               EstadoCivil = d.EstadoCivil,
                               GradoAcademico = d.GradoAcademico,
                               Direccion = d.Direccion
                           }).ToList();
            }

            return View(lst);
        }
    }
}