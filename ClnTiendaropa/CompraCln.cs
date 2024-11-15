using CadTiendaropa;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnTiendaropa
{
    public class CompraCln
    {
        /// <summary>
        /// Lista todas las compras activas.
        /// </summary>
        /// <returns>Lista de compras</returns>
        public List<Compra> listar()
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                return db.Compra
                         .Include(c => c.Proveedor)
                         .Include(c => c.Usuario)
                         .Where(c => c.estado == 1) // Solo compras activas
                         .ToList();
            }
        }

        /// <summary>
        /// Obtiene una compra específica por su ID.
        /// </summary>
        /// <param name="id">ID de la compra</param>
        /// <returns>Objeto Compra</returns>
        public Compra obtenerPorId(int id)
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                return db.Compra
                         .Include(c => c.DetalleCompra.Select(d => d.Producto))
                         .Include(c => c.Proveedor)
                         .Include(c => c.Usuario)
                         .FirstOrDefault(c => c.id == id);
            }
        }

        /// <summary>
        /// Crea una nueva compra y sus detalles.
        /// </summary>
        /// <param name="compra">Objeto Compra</param>
        /// <param name="detalles">Lista de detalles de compra</param>
        public void crear(Compra compra, List<DetalleCompra> detalles)
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        // Registrar compra
                        db.Compra.Add(compra);
                        db.SaveChanges();

                        // Registrar detalles
                        foreach (var detalle in detalles)
                        {
                            detalle.idCompra = compra.id; // Relacionar con la compra creada
                            db.DetalleCompra.Add(detalle);

                            // Actualizar stock del producto
                            var producto = db.Producto.Find(detalle.idProducto);
                            if (producto != null)
                            {
                                producto.stock += detalle.cantidad;
                                db.Entry(producto).State = EntityState.Modified;
                            }
                        }

                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Error al crear la compra: " + ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Actualiza una compra existente y sus detalles.
        /// </summary>
        /// <param name="compra">Objeto Compra</param>
        /// <param name="detalles">Lista de detalles de compra</param>
        public void actualizar(Compra compra, List<DetalleCompra> detalles)
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        // Actualizar compra
                        var compraExistente = db.Compra.Find(compra.id);
                        if (compraExistente == null)
                        {
                            throw new Exception("Compra no encontrada.");
                        }

                        compraExistente.tipoDocumento = compra.tipoDocumento;
                        compraExistente.numeroDocumento = compra.numeroDocumento;
                        compraExistente.montoTotal = compra.montoTotal;
                        compraExistente.idProveedor = compra.idProveedor;
                        compraExistente.estado = compra.estado;

                        db.Entry(compraExistente).State = EntityState.Modified;

                        // Eliminar detalles existentes
                        var detallesExistentes = db.DetalleCompra.Where(d => d.idCompra == compra.id).ToList();
                        foreach (var detalle in detallesExistentes)
                        {
                            // Reducir el stock de los productos
                            var producto = db.Producto.Find(detalle.idProducto);
                            if (producto != null)
                            {
                                producto.stock -= detalle.cantidad;
                                db.Entry(producto).State = EntityState.Modified;
                            }
                            db.DetalleCompra.Remove(detalle);
                        }

                        // Agregar nuevos detalles
                        foreach (var detalle in detalles)
                        {
                            detalle.idCompra = compra.id;
                            db.DetalleCompra.Add(detalle);

                            // Actualizar stock del producto
                            var producto = db.Producto.Find(detalle.idProducto);
                            if (producto != null)
                            {
                                producto.stock += detalle.cantidad;
                                db.Entry(producto).State = EntityState.Modified;
                            }
                        }

                        db.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("Error al actualizar la compra: " + ex.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Elimina lógicamente una compra por su ID.
        /// </summary>
        /// <param name="id">ID de la compra</param>
        public void eliminar(int id)
        {
            using (var db = new Labsis457tiendaderopaEntities())
            {
                var compraExistente = db.Compra.Find(id);
                if (compraExistente != null)
                {
                    compraExistente.estado = 0; // Marcar como inactivo
                    db.Entry(compraExistente).State = EntityState.Modified;

                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("Compra no encontrada.");
                }
            }
        }
    }
}