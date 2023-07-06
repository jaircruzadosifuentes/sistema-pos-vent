using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidades;
using CapaPersistencia;
using CapaPersistencia.Dao;
using CapaPersistencia.Mysql;

namespace CapaAplicacion
{
    public class ManagmentLogin
    {
        private readonly GestorDaoMysql gestorDaoMysql;
        private readonly UserDaoMysql userDaoMysql;
        //private readonly User userContrato;

        public ManagmentLogin()
        {
            this.gestorDaoMysql = new GestorDaoMysql();
            this.userDaoMysql = new UserDaoMysql(gestorDaoMysql);
        }

        public User AccessVerify(string userName, string password, out string message)
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                User verifyUser = userDaoMysql.AccessToTheSystem(userName, password);
                gestorDaoMysql.connectionClose();
                return new User().AccessVerify(verifyUser, out message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
