using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SWII_TP03.Controllers
{
    public class BLController : Controller {
        // GET: BL
        public ActionResult viewBL() {
            DAO.BLDAO dao = new DAO.BLDAO();
            IList<Models.BL> bl = dao.Lista();
            ViewBag.bl = bl;
            return View();
        }

        [HttpPostAttribute]
        public ActionResult Adiciona(Models.BL bl) {
            DAO.BLDAO dao = new DAO.BLDAO();
            dao.Adiciona(bl);
            return RedirectToAction("/viewBl");
        }

        [HttpPostAttribute]
        public ActionResult Editar(Models.BL bl) {
            DAO.BLDAO dao = new DAO.BLDAO();
            dao.Atualiza(bl);
            return RedirectToAction("/viewBl");
        }

        [HttpPostAttribute]
        public ActionResult Deletar(Models.BL bl) {
            DAO.BLDAO dao = new DAO.BLDAO();
            dao.Deletar(bl);
            return RedirectToAction("/viewBl");
        }
    }
}
