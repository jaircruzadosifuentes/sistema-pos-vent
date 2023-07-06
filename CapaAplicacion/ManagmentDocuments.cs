using CapaEntidades;
using CapaPersistencia.Dao;
using CapaPersistencia.Mysql;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaAplicacion
{
    public class ManagmentDocuments
    {
        private readonly GestorDaoMysql gestorDaoMysql;
        private readonly DocumentoDaoMysql documentoDaoMysql;
        public ManagmentDocuments()
        {
            this.gestorDaoMysql = new GestorDaoMysql();
            this.documentoDaoMysql = new DocumentoDaoMysql(gestorDaoMysql);
        }
        public List<Document> ListDouments()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                List<Document> list = documentoDaoMysql.ListDocuments();
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<TipoDocumento> ServiceGetTipoDocumentoEnCombo()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                List<TipoDocumento> list = documentoDaoMysql.DALGetTipoDocumentoEnCombo();
                gestorDaoMysql.connectionClose();
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<DocumentLongitud> GetLongitudDocument()
        {
            try
            {
                gestorDaoMysql.connectionOpen();
                List<DocumentLongitud> list = documentoDaoMysql.GetLongitudDocument();
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
