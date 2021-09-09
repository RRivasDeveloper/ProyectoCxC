﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa.Logica.Clases
{
    public class CrudClientes
    {
        #region insertar Clientes
        public string InsertarCliente(string PrimerNombre,
           string SegundoNombre,
           string PrimerApellido,
           string SegundoApellido,
           string Identificacion,
           DateTime FechaNacimiento,
           string Telefono,
           string Departamento,
           string Municipio,
           string Direccion,
           string NIT)//se ingresan lo datos que se guardaran en la bd
        {
            try
            {//se utiliza la entidad de base de datos
                using (Entidades.ClientesEntities objEntidad = new Entidades.ClientesEntities())
                {//se utiliza una tabla de la base de datos "PER_PERSONA"
                    Entidades.PER_PERSONA obtPersona = new Entidades.PER_PERSONA
                    {
                        PER_PrimerNombre = PrimerNombre,
                        PER_SegundoNombre = SegundoNombre,
                        PER_PrimerApellido = PrimerApellido,
                        PER_SegundoApellido = SegundoApellido,
                        PER_Identificacion = Identificacion,
                        PER_FechaNacimiento = FechaNacimiento,
                        PER_Telefono = Telefono,
                        PER_Departamento = Departamento,
                        PER_Municipio = Municipio,
                        PER_Direccion = Direccion,
                        PER_NIT = NIT
                        //Se insertan en el objeto obtpersona
                    };
                    objEntidad.PER_PERSONA.Add(obtPersona);//se agrega el registro a la tabla
                    objEntidad.SaveChanges();//se guardan los cambios
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return "Se insertó Proceso con Exito";
        }
        #endregion
        #region Modificar Clientes
        public string modificarCliente(string PrimerNombre,
          string SegundoNombre,
          string PrimerApellido,
          string SegundoApellido,
          string Identificacion,
          DateTime FechaNacimiento,
          string Telefono,
          string Departamento,
          string Municipio,
          string Direccion,
          string NIT)//se ingresan lo datos que se guardaran en la bd
        {
            try
            {//se utiliza la entidad de base de datos
                using (Entidades.ClientesEntities objEntidad = new Entidades.ClientesEntities())
                {
                    Entidades.PER_PERSONA obtPersona = (from q in objEntidad.PER_PERSONA
                                                        where q.PER_Identificacion == Identificacion
                                                        select q).First();

                    obtPersona.PER_PrimerNombre = PrimerNombre;
                    obtPersona.PER_SegundoNombre = SegundoNombre;
                    obtPersona.PER_PrimerApellido = PrimerApellido;
                    obtPersona.PER_SegundoApellido = SegundoApellido;
                    obtPersona.PER_Identificacion = Identificacion;
                    obtPersona.PER_FechaNacimiento = FechaNacimiento;
                    obtPersona.PER_Telefono = Telefono;
                    obtPersona.PER_Departamento = Departamento;
                    obtPersona.PER_Municipio = Municipio;
                    obtPersona.PER_Direccion = Direccion;
                    obtPersona.PER_NIT = NIT;
                   
                    objEntidad.SaveChanges();//solo se guardan los cambios porque ya existe
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return "Se Modifico con Exito";
        }
        #endregion
        #region Eliminar Clientes
        public string eliminarCliente(string Identificacion)
        {
            try
            {
                using (Entidades.ClientesEntities objEntidad = new Entidades.ClientesEntities())
                {
                    Entidades.PER_PERSONA obtPersona = (from q in objEntidad.PER_PERSONA
                                                        where q.PER_Identificacion == Identificacion
                                                        select q).First();
                    objEntidad.PER_PERSONA.Remove(obtPersona);
                    objEntidad.SaveChanges();
                };
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return "Se Elimino con Exito";
        }
        #endregion
        #region Consulta Clientes
        public List<Interfaces.clientesInterface> consultarClientes()
        {
            try
            {
                using (Entidades.ClientesEntities objEntidad = new Entidades.ClientesEntities())
                {
                    List<Interfaces.clientesInterface> objConsulta = (from q in objEntidad.PER_PERSONA
                                                                      //where q.PER_Persona1=="parametro"
                                                                      select new Interfaces.clientesInterface
                                                                      {
                                                                          PrimerNombre = q.PER_PrimerNombre,
                                                                          SegundoNombre = q.PER_SegundoApellido,
                                                                          PrimerApellido = q.PER_PrimerApellido,
                                                                          SegundoApellido = q.PER_SegundoApellido,
                                                                          Identificacion = q.PER_Identificacion,
                                                                          FechaNacimiento = (DateTime)q.PER_FechaNacimiento,
                                                                          Telefono = q.PER_Telefono,
                                                                          Departamento = q.PER_Departamento,
                                                                          Municipio = q.PER_Municipio,
                                                                          Direccion = q.PER_Direccion,
                                                                          NIT = q.PER_NIT

                                                                      }).ToList();
                    return objConsulta;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion
        #region Consultar uno
        public List<Interfaces.clientesInterface> consultarUnCliente(string id)
        {
            try
            {
                using (Entidades.ClientesEntities objEntidad = new Entidades.ClientesEntities())
                {
                    List<Interfaces.clientesInterface> objConsulta = (from q in objEntidad.PER_PERSONA
                                                                          where q.PER_Identificacion==id
                                                                      select new Interfaces.clientesInterface
                                                                      {
                                                                          PrimerNombre = q.PER_PrimerNombre,
                                                                          SegundoNombre = q.PER_SegundoApellido,
                                                                          PrimerApellido = q.PER_PrimerApellido,
                                                                          SegundoApellido = q.PER_SegundoApellido,
                                                                          Identificacion = q.PER_Identificacion,
                                                                          FechaNacimiento = (DateTime)q.PER_FechaNacimiento,
                                                                          Telefono = q.PER_Telefono,
                                                                          Departamento = q.PER_Departamento,
                                                                          Municipio = q.PER_Municipio,
                                                                          Direccion = q.PER_Direccion,
                                                                          NIT = q.PER_NIT

                                                                      }).ToList();
                    return objConsulta;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion
        #region sp_Consulta
        public List<Entidades.spConsulta_Result> Consultar_spDatosPrincipales()
        {
            try
            {
                using (Entidades.ClientesEntities objEntidad= new Entidades.ClientesEntities())
                {

                    List<Entidades.spConsulta_Result> respuesta = objEntidad.spConsulta().ToList();  
                    //objEntidad.spDatosPrincipales().ToList();
                    //List<Interfaces.clientesInterface> objConsulta = (List)objEntidad.Database.SqlQuery<objConsulta>("spDatosPrincipales").ToList();
                    //List<Interfaces.clientesInterface> ).ToList();
                    //return objEntidad.Database.SqlQuery<consultar_spDatosPrincipales>("spDatosPrincipales").ToList();
                    return respuesta;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion
        #region Consultar uno
        public List<Entidades.spConsultaUno_Result> ConsultarUno(string dato)
        {
            try
            {
                using (Entidades.ClientesEntities objEntidad = new Entidades.ClientesEntities())
                {
                    List<Entidades.spConsultaUno_Result> respuesta = objEntidad.spConsultaUno(dato).ToList();
                    return respuesta;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion
    }
}