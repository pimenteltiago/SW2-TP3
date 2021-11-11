using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SWII_TP03.DAO {
    public class ContainerDAO {

        public void Adiciona(Models.Container container) {
            using (var context = new Context()) {
                context.Container.Add(container);
                context.SaveChanges();
            }
        }

        public IList<Models.Container> Lista() {
            using (var contexto = new Context()) {
                return contexto.Container.ToList();
            }
        }

        public void Atualiza(Models.Container container) {
            using (var contexto = new Context()) {
                contexto.Entry(container).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Deletar(Models.Container container) {
            using (var contexto = new Context()) {
                contexto.Container.Remove(container);
                contexto.SaveChanges();
            }
        }
    }
}