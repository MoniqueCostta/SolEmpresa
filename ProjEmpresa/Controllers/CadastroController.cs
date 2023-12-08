using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ContosoUniversity.DAL;
using ProjEmpresa.Models;

namespace ProjEmpresa.Controllers
{
    public class CadastroController : Controller
    {
        private EmpresaContexto db = new EmpresaContexto();

        // GET: Cadastro
        public ActionResult Index()
        {
            var cadastros = db.Cadastros.Include(c => c.Departamento).Include(c => c.Funcionario);
            return View(cadastros.ToList());
        }

        // GET: Cadastro/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cadastro cadastro = db.Cadastros.Find(id);
            if (cadastro == null)
            {
                return HttpNotFound();
            }
            return View(cadastro);
        }

        // GET: Cadastro/Create
        public ActionResult Create()
        {
            ViewBag.DepartamentoID = new SelectList(db.Departamentos, "DepartamentoID", "NomeArea");
            ViewBag.FuncionarioID = new SelectList(db.Funcionarios, "ID", "Nome");
            return View();
        }

        // POST: Cadastro/Create
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CadastroID,DepartamentoID,FuncionarioID,Grade")] Cadastro cadastro)
        {
            if (ModelState.IsValid)
            {
                db.Cadastros.Add(cadastro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DepartamentoID = new SelectList(db.Departamentos, "DepartamentoID", "NomeArea", cadastro.DepartamentoID);
            ViewBag.FuncionarioID = new SelectList(db.Funcionarios, "ID", "Nome", cadastro.FuncionarioID);
            return View(cadastro);
        }

        // GET: Cadastro/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cadastro cadastro = db.Cadastros.Find(id);
            if (cadastro == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartamentoID = new SelectList(db.Departamentos, "DepartamentoID", "NomeArea", cadastro.DepartamentoID);
            ViewBag.FuncionarioID = new SelectList(db.Funcionarios, "ID", "Nome", cadastro.FuncionarioID);
            return View(cadastro);
        }

        // POST: Cadastro/Edit/5
        // Para se proteger de mais ataques, habilite as propriedades específicas às quais você quer se associar. Para 
        // obter mais detalhes, veja https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CadastroID,DepartamentoID,FuncionarioID,Grade")] Cadastro cadastro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cadastro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartamentoID = new SelectList(db.Departamentos, "DepartamentoID", "NomeArea", cadastro.DepartamentoID);
            ViewBag.FuncionarioID = new SelectList(db.Funcionarios, "ID", "Nome", cadastro.FuncionarioID);
            return View(cadastro);
        }

        // GET: Cadastro/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cadastro cadastro = db.Cadastros.Find(id);
            if (cadastro == null)
            {
                return HttpNotFound();
            }
            return View(cadastro);
        }

        // POST: Cadastro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cadastro cadastro = db.Cadastros.Find(id);
            db.Cadastros.Remove(cadastro);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
