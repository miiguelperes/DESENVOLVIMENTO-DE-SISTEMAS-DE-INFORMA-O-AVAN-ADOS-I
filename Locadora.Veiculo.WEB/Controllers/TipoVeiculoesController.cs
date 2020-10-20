using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Locadora.Veiculos.Dados.Entity.Context;
using Locadora.Veiculos.Dominio;
using Projeto.AtelierVera.WEB.ViewModels.TiposVeiculos;

namespace Locadora.Veiculo.WEB.Controllers
{
    public class TipoVeiculoesController : Controller
    {
        private VeiculoDbContext db = new VeiculoDbContext();

        // GET: TipoVeiculoes
        public ActionResult Index()
        {
            return View(Mapper.Map<List<TipoVeiculo>, List<TipoVeiculoIndexViewModels>>(db.TiposVeiculos.ToList()));
        }

        // GET: TipoVeiculoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoVeiculo tipoVeiculo = db.TiposVeiculos.Find(id);
            if (tipoVeiculo == null)
            {
                return HttpNotFound();
            }
            return View(tipoVeiculo);
        }

        // GET: TipoVeiculoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoVeiculoes/Create
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nome,Categoria,Situacao,Ano,Descricao")] TipoVeiculo tipoVeiculo)
        {
            if (ModelState.IsValid)
            {
                db.TiposVeiculos.Add(tipoVeiculo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoVeiculo);
        }

        // GET: TipoVeiculoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoVeiculo tipoVeiculo = db.TiposVeiculos.Find(id);
            if (tipoVeiculo == null)
            {
                return HttpNotFound();
            }
            return View(tipoVeiculo);
        }

        // POST: TipoVeiculoes/Edit/5
        // Para proteger-se contra ataques de excesso de postagem, ative as propriedades específicas às quais deseja se associar. 
        // Para obter mais detalhes, confira https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Categoria,Situacao,Ano,Descricao")] TipoVeiculo tipoVeiculo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoVeiculo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoVeiculo);
        }

        // GET: TipoVeiculoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoVeiculo tipoVeiculo = db.TiposVeiculos.Find(id);
            if (tipoVeiculo == null)
            {
                return HttpNotFound();
            }
            return View(tipoVeiculo);
        }

        // POST: TipoVeiculoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoVeiculo tipoVeiculo = db.TiposVeiculos.Find(id);
            db.TiposVeiculos.Remove(tipoVeiculo);
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
