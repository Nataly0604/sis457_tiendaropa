using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CadTiendaropa;
using System.Data.Entity;

namespace ClnTiendaropa
{
    public class UsuarioCln
    {
        public List<Usuario> listar()
        {
            List<Usuario> datos = new List<Usuario>();
            using (var db = new Labsis457tiendaderopaEntities())
            {
                try
                {
                    datos = db.Usuario.ToList();// esto es una consulta a la base de datos



                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return datos;

        }


        public static Usuario obtenertodo()
            { return new Usuario(); 
        }
        // Labsis457tiendaderopaEntities1    

        public static Usuario validar(string usuario, string clave)
        {
            using (var context = new Labsis457tiendaderopaEntities())
            {
                return context.Usuario
                    .Where(x =>  x.usuario1 == usuario && x.clave == clave)
                    .FirstOrDefault();
            }
        }
    }
    }