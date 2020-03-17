using _2ParciaRegistroConDetallel_Aplicada1_1_2020.DAL;
using _2ParciaRegistroConDetallel_Aplicada1_1_2020.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace _2ParciaRegistroConDetallel_Aplicada1_1_2020.BLL
{
   public  class LLamadasBLL
    {
        public static bool Guardar(Llamadas llamadas)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Llamadas.Add(llamadas) != null)
                    paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;

        }

        public static bool Modificar(Llamadas llamadas)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Database.ExecuteSqlRaw($"Delete FROM LlamadaDetalle Where LlamadasId = {llamadas.LlamadasId}");

                    foreach(var item in llamadas.LlamadaDetalle)
                {
                    db.Entry(item).State = EntityState.Modified;
                }
                db.Entry(llamadas).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool pase = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.Llamadas.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return pase;
        }

        public static Llamadas Buscar(int id)
        {
            Llamadas llamadas = new Llamadas();
            Contexto db = new Contexto();
            try
            {
                llamadas = db.Llamadas.Include(o => o.LlamadaDetalle).Where(o => o.LlamadasId == id). SingleOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return llamadas;

        }
        public static List<Llamadas> GetList(Expression<Func<Llamadas, bool>> llamadas)
        {
            List<Llamadas> lista = new List<Llamadas>();
            Contexto db = new Contexto();

            try
            {
                lista = db.Llamadas.Where(llamadas).ToList();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return lista;
        }



       
    }
}
