using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidades;

namespace CapaPersistencia.Interfaces
{
    public interface IUserDaoMysql
    {
        User AccessToTheSystem(string userName, string password);
        List<User> GetAllUser();
    }
}
