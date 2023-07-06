using CapaEntidades;
using CapaPersistencia.Dao;
using CapaPersistencia.Mysql;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaAplicacion
{
    public class ManagmentCliente
    {
        private readonly GestorDaoMysql gestorDaoMysql;
        private readonly ClienteDaoMysql clienteDaoMysql;
        public ManagmentCliente()
        {
            this.gestorDaoMysql = new GestorDaoMysql();
            clienteDaoMysql = new ClienteDaoMysql(gestorDaoMysql);
        }
        public bool ServiceInsertaCliente(Cliente cliente, string tipo)
        {
            try
            {
                gestorDaoMysql.startTransaction();
                bool inserta = clienteDaoMysql.DALInsertarCliente(cliente, tipo);
                if (inserta)
                    gestorDaoMysql.finishTransaction();
                else
                    gestorDaoMysql.cancelTransaction();
                return inserta;
            }
            catch (Exception ex)
            {
                gestorDaoMysql.cancelTransaction();
                throw ex;
            }
        }
        public List<TipoDocumento> ServiceGetDocumentsTypeInCombo()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                var listDocumentsType = clienteDaoMysql.DALGetDocumentTypeInCombo();
                gestorDaoMysql.connectionClose();
                return listDocumentsType;
            }
            catch (Exception ex)
            {
                gestorDaoMysql.connectionClose();
                throw ex;
            }
        } 
        public List<Horario> ServiceGetHorarioEnCombo()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                var horarios = clienteDaoMysql.DALGetHorarioEnCombo();
                gestorDaoMysql.connectionClose();
                return horarios;
            }
            catch (Exception ex)
            {
                gestorDaoMysql.connectionClose();
                throw ex;
            }
        }
    }
}
