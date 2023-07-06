using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaAplicacion.Interfaces
{
    public interface IManagmentSystemConfig
    {
        List<SystemConfig> GetAllSystemConfig();
    }
}
