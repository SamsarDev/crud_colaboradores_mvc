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
                lst = (from d in db.Colaboradores
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

        public ActionResult Nuevo() 
        {
            return View();
        }

        [HttpPost]
        public ActionResult Nuevo(ColaboradorModel model) 
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (Crud_App_EspEntities db = new Crud_App_EspEntities())
                    {
                        var nColaborador = new Colaboradores();
                        nColaborador.Nombres = model.Nombres;
                        nColaborador.Apellidos = model.Apellidos;
                        nColaborador.FechaNacimiento = model.FechaNacimiento;
                        nColaborador.EstadoCivil = model.EstadoCivil;
                        nColaborador.Direccion = model.Direccion;
                        nColaborador.GradoAcademico = model.GradoAcademico;
                        nColaborador.Fecha_Creacion = DateTime.Now;

                        db.Colaboradores.Add(nColaborador);
                        db.SaveChanges();
                    }


                    return Redirect("~/colaboradores/");
                }

                return View();
            } 
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult Editar(int Id)
        {
            ColaboradorModel model = new ColaboradorModel();
            using (Crud_App_EspEntities db = new Crud_App_EspEntities())
            {
                var oColaborador = db.Colaboradores.Find(Id);
                model.ID_Colaborador = oColaborador.ID_Colaborador;
                model.Nombres = oColaborador.Nombres;
                model.Apellidos = oColaborador.Apellidos;
                model.FechaNacimiento = oColaborador.FechaNacimiento;
                model.EstadoCivil = oColaborador.EstadoCivil;
                model.Direccion = oColaborador.Direccion;
                model.GradoAcademico = oColaborador.GradoAcademico;
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult Editar(ColaboradorModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (Crud_App_EspEntities db = new Crud_App_EspEntities())
                    {
                        var nColaborador = db.Colaboradores.Find(model.ID_Colaborador);
                        nColaborador.Nombres = model.Nombres;
                        nColaborador.Apellidos = model.Apellidos;
                        nColaborador.FechaNacimiento = model.FechaNacimiento;
                        nColaborador.EstadoCivil = model.EstadoCivil;
                        nColaborador.Direccion = model.Direccion;
                        nColaborador.GradoAcademico = model.GradoAcademico;
                        nColaborador.Fecha_Creacion = DateTime.Now;

                        db.Entry(nColaborador).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }


                    return Redirect("~/colaboradores/");
                }

                return View();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        public ActionResult Eliminar(int Id)
        {
            using (Crud_App_EspEntities db = new Crud_App_EspEntities())
            {
                var oColaborador = db.Colaboradores.Find(Id);
                db.Colaboradores.Remove(oColaborador);
                db.SaveChanges();
            }

            return Redirect("~/colaboradores/");
        }
    }
}