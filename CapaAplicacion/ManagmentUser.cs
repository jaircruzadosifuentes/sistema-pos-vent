using CapaEntidades;
using CapaPersistencia.Dao;
using CapaPersistencia.Mysql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaAplicacion
{
    public class ManagmentUser
    {
        private readonly GestorDaoMysql gestorDaoMysql;
        private readonly UserDaoMysql userDaoMysql;
        public ManagmentUser()
        {
            this.gestorDaoMysql = new GestorDaoMysql();
            this.userDaoMysql = new UserDaoMysql(gestorDaoMysql);
        }
        public DataTable GetAllUser()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = userDaoMysql.GetAllUser();
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }  
        public DataTable ServiceGetClientes()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = userDaoMysql.DALGetClientes();
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetEmpleadosPorApellidos(string apellidos)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = userDaoMysql.GetEmpleadosPorApellidos(apellidos);
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }   
        public DataTable ServiceValidarSiEsAdmiYRecuperaClave(string codigoUsuario)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = userDaoMysql.DALValidarSiEsAdmiYRecuperaClave(codigoUsuario);
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }  
        public DataTable GetEmpleadosPorCodigo(string codigoEmpleado)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = userDaoMysql.GetEmpleadosPorCodigo(codigoEmpleado);
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 
        public DataTable ServiceGetUsuarioPorCodigo(string codigo)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = userDaoMysql.DALGetUsuarioPorCodigo(codigo);
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetEmpleadosPorNombres(string nombres)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = userDaoMysql.GetEmpleadosPorNombres(nombres);
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetEmpleadosPorCargo(string cargo)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = userDaoMysql.GetEmpleadosPorCargo(cargo);
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAllUsersBanned()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable list = userDaoMysql.GetAllUsersBanned();
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetCellphoneNumber(int userId)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                DataTable dataTable = userDaoMysql.GetCellphoneNumber(userId);
                gestorDaoMysql.connectionClose();
                return dataTable;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool ServiceInsertaUser(User user, string tipo)
        {
            try
            {
                gestorDaoMysql.startTransaction();
                bool insert = userDaoMysql.DALInsertaUsuario(user, tipo);
                if (insert)
                    gestorDaoMysql.finishTransaction();
                else
                    gestorDaoMysql.cancelTransaction();
                return insert;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ServiceDarDeBajaTrabajador(int trabajadorId)
        {
            try
            {
                gestorDaoMysql.startTransaction();
                bool banned = userDaoMysql.DALDarDeBajaTrabajador(trabajadorId);
                if (banned)
                    gestorDaoMysql.finishTransaction();
                else
                    gestorDaoMysql.cancelTransaction();
                return banned;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
