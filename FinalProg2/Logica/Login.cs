﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Login
    {
        public int ID = 1;
        public string Correo { get; set; }
        public string Clave { get; set; }

    }
    
    public class Cliente
    {
        public string Name { get; set; }
        public string LastN { get; set; }
        public string DNI { get; set; }
        public string Date { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public Int64 Tel { get; set; }
        public Int64 Cel { get; set; }
        public Int64 IdP { get; set; }

        public void Show()
        {
            throw new NotImplementedException();
        }
    }
    public class Prestamo
    {
        public decimal Interes { get; set; }
        public decimal Capital { get; set; }
        public string Tiempo { get; set; }
        public string Fecha { get; set; }
        public int Cuotas { get; set; }
        public decimal Pagos { get; set; }
        public decimal Deudas { get; set; }
    }

    public class Users
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Pass { get; set; }
        public string Mode { get; set; }
        public int Rol { get; set; }
    }
}
