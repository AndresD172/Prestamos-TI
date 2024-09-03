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
            DALDepartamento DalDepartamento = new DALDepartamento();

            return DalDepartamento.RegistrarDepartamento(departamento);

        }
        public static Respuesta ListarDepartamento(string cTexto)
        {
            DALDepartamento DalDepartamento = new DALDepartamento();

            return DalDepartamento.ListarDepartamento(cTexto);

        }
        public static Respuesta EliminarDepartamento(int IdDepartamento)
        {
            DALDepartamento DalDepartamento = new DALDepartamento();

            return DalDepartamento.EliminarDepartamento(IdDepartamento);

        }
        public static Respuesta ActualizarDepartamento(EntidadDepartamento departamento)
        {
            DALDepartamento DalDepartamento = new DALDepartamento();

            return DalDepartamento.ActualizarDepartamento(departamento);

        }
    }
}
