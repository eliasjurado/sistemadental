using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appSistemaDental
{
    public class clsDetalleBoleta
    {
        private int _IdDetalle;

        public int IdDetalle
        {
            get { return _IdDetalle; }
            set { _IdDetalle = value; }
        }
        
        private String _Tratamiento;

        public String Tratamiento
        {
            get { return _Tratamiento; }
            set { _Tratamiento = value; }
        }
        private int _Cantidad;

        public int Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }
        private string _Piezas;

        public string Piezas
        {
            get { return _Piezas; }
            set { _Piezas = value; }
        }

        private double _PrecioUnitario;

        public double PrecioUnitario
        {
            get { return _PrecioUnitario; }
            set { _PrecioUnitario = value; }
        }
        private double _Subtotal;

        public double Subtotal
        {
            get {
                _Subtotal = Math.Round(_PrecioUnitario * _Cantidad / 1.18, 2);
                
                return _Subtotal; }
            
        }
        private double _Igv;

        public double Igv
        {
            get {
                _Igv = Math.Round((_PrecioUnitario * Cantidad) - Subtotal,2);
                return _Igv; }
            
        }
        private double _Total;

        public double Total
        {
            get {
                _Total = Math.Round(Subtotal + Igv,2);
                return _Total; }
            
        }


        

    }
}
