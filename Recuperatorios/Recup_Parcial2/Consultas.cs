using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorios.Recup_Parcial2 {
    public class Consultas {
        public static string InsertarPerfume(Perfume perfume) {
            return $"INSERT INTO Perfumes (Nombre, Marca, Precio, Stock) VALUES ('{perfume.Nombre}', '{perfume.Marca}', {perfume.Precio}, {perfume.Stock})";
        }
        public static string ObtenerPerfumes() {
            return "SELECT * FROM Perfumes";
        }
        public static string ObtenerPerfumePorId(int id) {
            return $"SELECT * FROM Perfumes WHERE Id = {id}";
        }
        public static string ActualizarPerfume(Perfume perfume) {
            return $"UPDATE Perfumes SET Nombre = '{perfume.Nombre}', Marca = '{perfume.Marca}', Precio = {perfume.Precio}, Stock = {perfume.Stock} WHERE Id = {perfume.Id}";
        }
        public static string EliminarPerfume(int id) {
            return $"DELETE FROM Perfumes WHERE Id = {id}";
        }
        public static string InsertarVenta(Venta venta) {
            return $"INSERT INTO Ventas (PerfumeId, Nombre, Apellido, Cuit, Cantidad) VALUES ({venta.PerfumeId}, '{venta.Nombre}', '{venta.Apellido}', '{venta.Cuit}', {venta.Cantidad})";
        }
        public static string ObtenerVentas() {
            return "SELECT * FROM Ventas";
        }
    }
}
