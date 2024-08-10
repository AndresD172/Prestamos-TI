using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BLDepartamento
    {
        public static Respuesta RegistrarDepartamento(EntidadDepartamento departamento)
        {
            DALDepartamento daldepartamento = new DALDepartamento();

            return daldepartamento.RegistrarDepartamento(departamento);

        }
        public static Respuesta ListarDepartamento(string cTexto)
        {
            DALDepartamento daldepartamento = new DALDepartamento();

            return daldepartamento.ListarDepartamento(cTexto);

        }
        public static Respuesta EliminarDepartamento(int IdDepartamento)
        {
            DALDepartamento daldepartamento = new DALDepartamento();

            return daldepartamento.EliminarDepartamento(IdDepartamento);

        }
        public static Respuesta ActualizarDepartamento(EntidadDepartamento departamento)
        {
            DALDepartamento daldepartamento = new DALDepartamento();

            return daldepartamento.ActualizarDepartamento(departamento);

        }
    }
}
