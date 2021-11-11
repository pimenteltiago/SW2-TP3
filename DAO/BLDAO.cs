using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWII_TP03.DAO {
    public class BLDAO {
        public void Adiciona(Models.BL bl) {
            using (var context = new Context()) {
                context.BL.Add(bl);
                context.SaveChanges();
            }
        }

        public IList<Models.BL> Lista() {
            using (var contexto = new Context()) {
                return contexto.BL.ToList();
            }
        }

        public void Atualiza(Models.BL bl) {
            using (var contexto = new Context()) {
                contexto.Entry(bl).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Deletar(Models.BL bl) {
            using (var contexto = new Context()) {
                contexto.BL.Remove(bl);
                contexto.SaveChanges();
            }
        }
    }
}