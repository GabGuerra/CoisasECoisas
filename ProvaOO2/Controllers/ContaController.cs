using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProvaOO.Models;

namespace ProvaOO2.Controllers
{
    public class ContaController : Controller
    {
        private Context db = new Context();
        private string strSessionConta = "Conta";
        // GET: Conta

        public ActionResult Cadastrar(Conta model)
        {
            Conta conta = new Conta();
            if (ModelState.IsValid)
            {
                conta.nome = model.nome;
                conta.login = model.login;
                conta.senha = model.senha;
                conta.cpf = model.cpf;
                conta.email = model.email;

                db.conta.Add(conta);
                db.SaveChanges();
                return RedirectToAction("Details", "Conta", new { id = conta.contaId });


            }
            return View(model);
        }
        public ActionResult Logar(string login, string senha)
        {
            Conta conta = new Conta();
            using (db)
            {
                conta = db.conta.Where(c => c.login == login && c.senha == senha).First();
                Session[strSessionConta] = conta;
            }
            return RedirectToAction($"Details/{conta.contaId}");
        }

        public ActionResult Index()
        {

            var conta = db.conta.ToList();
            return View(conta);
        }

        // GET: Conta/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Conta conta = db.conta.Find(id);
            if (conta == null)
            {
                return HttpNotFound();
            }
            return View(conta);
        }

        // GET: Conta/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Conta/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "contaId,login,senha")] Conta conta)
        {
            if (ModelState.IsValid)
            {
                db.conta.Add(conta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(conta);
        }

        // GET: Conta/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Conta conta = db.conta.Find(id);
            if (conta == null)
            {
                return HttpNotFound();
            }
            return View(conta);
        }

        // POST: Conta/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "contaId,login,senha")] Conta conta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(conta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(conta);
        }

        // GET: Conta/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Conta conta = db.conta.Find(id);
            if (conta == null)
            {
                return HttpNotFound();
            }
            return View(conta);
        }

        // POST: Conta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Conta conta = db.conta.Find(id);
            db.conta.Remove(conta);
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
