using CapaEntidades;
using CapaPersistencia.Mysql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaPersistencia.Dao
{
    public class DocumentoDaoMysql
    {
        private readonly GestorDaoMysql gestorDaoMysql;

        public DocumentoDaoMysql(GestorDaoMysql gestorDaoMysql)
        {
            this.gestorDaoMysql = gestorDaoMysql;
        }

        public List<TipoDocumento> DALGetTipoDocumentoEnCombo()
        {
            List<TipoDocumento> listCaja = new List<TipoDocumento>();
            TipoDocumento tipoDocumento;
            string consultaSQL;
            consultaSQL = "SELECT tipoDocumentoId, abreviatura ";
            consultaSQL += "FROM mnt_tipodocumento ";
            consultaSQL += "WHERE estado = 1";
            try
            {
                MySqlDataReader resultadoMysql = gestorDaoMysql.runQuery(consultaSQL);
                while (resultadoMysql.Read())
                {
                    tipoDocumento = GetParamsTipoDocumentoForCombo(resultadoMysql);
                    listCaja.Add(tipoDocumento);
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return listCaja;
        }

        public TipoDocumento GetParamsTipoDocumentoForCombo(MySqlDataReader resultadoMysql)
        {
            TipoDocumento tipoDocumento = new TipoDocumento();
            tipoDocumento.TipoDocumentoId = Convert.ToInt32(resultadoMysql["tipoDocumentoId"]);
            tipoDocumento.Abreviatura = resultadoMysql["abreviatura"].ToString();
            return tipoDocumento;
        }

        public List<Document> ListDocuments()
        {
            MySqlCommand command = new MySqlCommand("stp_getAllDocuments");
            List<Document> listDocuments = new List<Document>();
            Document document;
            List<MySqlParameter> parameters = new List<MySqlParameter>
            {
            };
            try
            {
                MySqlDataReader result = gestorDaoMysql.runCommandoProcedureSpParamater(command, parameters);
                while (result.Read())
                {
                    document = new Document()
                    {
                        DocumentId = Convert.ToInt32(result["documentId"]),
                        Name = result["nameDocument"].ToString(),
                        State = Convert.ToInt32(result["state"])
                    };
                    listDocuments.Add(document);
                }
                result.Close();
                return listDocuments;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<DocumentLongitud> GetLongitudDocument()
        {
            MySqlCommand command = new MySqlCommand("stp_getLongitudDocument");
            List<DocumentLongitud> list = new List<DocumentLongitud>();
            DocumentLongitud documentLongitud;
            Document document;
            List<MySqlParameter> parameters = new List<MySqlParameter> {};
            try
            {
                MySqlDataReader result = gestorDaoMysql.runCommandoProcedureSpParamater(command, parameters);
                while (result.Read())
                {
                    documentLongitud = new DocumentLongitud()
                    {
                        Serie = Convert.ToInt32(result["serie"]),
                        Number = Convert.ToInt32(result["number"])
                    };
                    document = new Document()
                    {
                        DocumentId = Convert.ToInt32(result["document_id"]),
                        Name = result["nameDocument"].ToString()
                    };
                    documentLongitud.Document = document;
                    list.Add(documentLongitud);
                }
                result.Close();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
