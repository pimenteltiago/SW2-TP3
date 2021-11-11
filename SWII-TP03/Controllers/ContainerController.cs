using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SWII_TP03.Controllers
{
    public class ContainerController : Controller
    {
        // GET: Container
        public ActionResult viewContainer()
        {
            DAO.ContainerDAO dao = new DAO.ContainerDAO();
            IList<Models.Container> containers = dao.Lista();
            ViewBag.containers = containers;
            return View();
        }


        [HttpPostAttribute]
        public ActionResult Adiciona(Models.Container container) {
            DAO.ContainerDAO dao = new DAO.ContainerDAO();
            dao.Adiciona(container);
            return RedirectToAction("/viewContainer");
        }

        [HttpPostAttribute]
        public ActionResult Editar(Models.Container container) {
            DAO.ContainerDAO dao = new DAO.ContainerDAO();
            dao.Atualiza(container);
            return RedirectToAction("/viewContainer");
        }

        [HttpPostAttribute]
        public ActionResult Deletar(Models.Container container) {
            DAO.ContainerDAO dao = new DAO.ContainerDAO();
            dao.Deletar(container);
            return RedirectToAction("/viewContainer");
        }

    }
}
