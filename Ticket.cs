using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketDeCompra
{
    public class Ticket
    {
        private string color { get; set; }
        private string tamanio { get; set; }
        private int tipo { get; set; }  
        private int cantidad { get; set; }

        public string GetColor() => color;
        public void SetColor(string color) => this.color = color;
        public string GetTamanio() => tamanio;
        public void SetTamanio(string tamanio) => this.tamanio = tamanio;
        public int GetTipe() => tipo;
        public void SetTipe(int tipo) => this.tipo = tipo == 1 || tipo == 2 || tipo == 3 ? tipo : 1;
        public int GetCantidad() => cantidad;
        public void SetCantidad(int cantidad) => this.cantidad = cantidad > 0 ? cantidad : 1;

        public int AveriguarPrecio() 
        {
            var tipo = this.tipo;
            switch (tipo)
            {
                case 1: return 5;
                case 2: return 8;
                case 3: return 10;
                default: return 0;
            }
        }

        public int CalcualarPrecio()
        {
            var precio = AveriguarPrecio();
            return precio * this.cantidad;
        }
    }
}
