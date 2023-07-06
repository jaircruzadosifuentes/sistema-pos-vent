using CapaPersistencia.Dao;
using CapaPersistencia.Mysql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaAplicacion
{
    public class ManagmentAuth
    {
        private readonly GestorDaoMysql gestorDaoMysql;
        private readonly AuthDaoMysql authDaoMysql;
        public ManagmentAuth()
        {
            this.gestorDaoMysql = new GestorDaoMysql();
            this.authDaoMysql = new AuthDaoMysql(gestorDaoMysql);
        }
        public bool PermisoEspecial(string userName, string code)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                bool permiso = authDaoMysql.PermisoEspecial(userName, code);
                gestorDaoMysql.connectionClose();
                return permiso;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        } 
        public bool ServiceInsertPermisoOperacion(string codeOperation, string userName)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                bool permiso = authDaoMysql.DALInsertPermisoOperacion(codeOperation, userName);
                gestorDaoMysql.connectionClose();
                return permiso;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool ServiceQuitarPermisos(string codeOperation, string userName)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                bool permiso = authDaoMysql.DALQuitarPermisos(codeOperation, userName);
                gestorDaoMysql.connectionClose();
                return permiso;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public DataTable DALVerificaOperacionesExistentes(string codeOperation, string userCode)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                var list = authDaoMysql.DALVerificaOperacionesExistentes(codeOperation, userCode);
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
