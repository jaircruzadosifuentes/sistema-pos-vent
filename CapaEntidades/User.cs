using System;
using System.Collections.Generic;
using System.Text;

namespace CapaEntidades
{
    public class User
    {
        public int UserId { get; set; }
        public string Names { get; set; }
        public string LastPatern { get; set; }
        public string LastMother { get; set; }
        public string SurNames { get; set; }
        public DateTime BirthDate { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool State { get; set; }
        public int IsAdmi { get; set; }
        public string Cellphone { get; set; }
        public string Dni { get; set; }
        public Rol Rol { get; set; }
        public Arquetipo Arquetipo { get; set; }
        public Caja Caja { get; set; }
        public Sede Sede { get; set; }
        public Pais Pais { get; set; }
        public string Sexo { get; set; }
        public string Direction { get; set; }
        public string EmailAddress { get; set; }
        public string NumeroDoc { get; set; }
        public int TipoDocumentoId { get; set; }
        public bool TieneCorreoBit { get; set; }
        public string InicialesUsuario { get; set; }
        public Horario Horario { get; set; }
        public User AccessVerify(User user, out string message)
        {
            try
            {
                message = "";
                if (user != null)
                {
                    if (!user.State)
                    {
                        message = string.Concat("El usuario está dado de baja. De persistir el error contactárse con el Administrador del Sistema.");
                    }
                    else if(user.Caja.CajaId == 0)
                    {
                        message = "Aún no se le ha asignado CAJA, contáctese con el Administrador del Sistema.";
                    }
                }
                else
                {
                    message = "Usuario o Password no válido";
                }
                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
