using CapaEntidades;
using CapaPersistencia.Mysql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaPersistencia.Dao
{
    public class ClienteDaoMysql
    {
        private readonly GestorDaoMysql gestorDaoMysql;

        public ClienteDaoMysql(GestorDaoMysql gestorDaoMysql)
        {
            this.gestorDaoMysql = gestorDaoMysql;
        }

        public bool DALInsertarCliente(Cliente cliente, string tipo)
        {
            MySqlCommand command = new MySqlCommand("stp_inserta_modifica_cliente");

            try
            {
                command = gestorDaoMysql.getCommandProcedure(command);
                command.Parameters.AddWithValue("prmNombres", cliente.Nombres);
                command.Parameters.AddWithValue("prmApellidos", cliente.Apellidos);
                command.Parameters.AddWithValue("prmTipoDocumentoId", cliente.TipoDocumento.TipoDocumentoId);
                command.Parameters.AddWithValue("prmNroDocumento", cliente.NroDocumento);
                command.Parameters.AddWithValue("prmTieneCorreo", cliente.TieneCorreo);
                command.Parameters.AddWithValue("prmEmail", cliente.Email);
                command.Parameters.AddWithValue("prmSexo", cliente.Sexo);
                command.Parameters.AddWithValue("prmDireccionFiscal", cliente.DireccionFiscal);
                command.Parameters.AddWithValue("prmTipo", tipo);
            
                int index = command.ExecuteNonQuery();
                return index > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<TipoDocumento> DALGetDocumentTypeInCombo()
        {
            List<TipoDocumento> listDocumentsType = new List<TipoDocumento>();
            TipoDocumento typeDocument;
            string consultaSQL;
            consultaSQL = "SELECT t.tipoDocumentoId, t.abreviatura ";
            consultaSQL += "FROM mnt_tipodocumento t ";
            consultaSQL += "WHERE t.estado = 1 ";
            try
            {
                MySqlDataReader resultadoMysql = gestorDaoMysql.runQuery(consultaSQL);
                while (resultadoMysql.Read())
                {
                    typeDocument = GetParametersDocumentType(resultadoMysql);
                    listDocumentsType.Add(typeDocument);
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return listDocumentsType;
        }
        public TipoDocumento GetParametersDocumentType(MySqlDataReader resultadoMysql)
        {
            TipoDocumento typeDocument = new TipoDocumento();
            typeDocument.TipoDocumentoId = Convert.ToInt32(resultadoMysql["tipoDocumentoId"]);
            typeDocument.Abreviatura = resultadoMysql["abreviatura"].ToString();
            return typeDocument;
        }

        public List<Horario> DALGetHorarioEnCombo()
        {
            List<Horario> horarios = new List<Horario>();
            Horario horario;
            string consultaSQL;
            consultaSQL = "SELECT t.idhorario_trabajo, UPPER(t.nombre) AS nombre ";
            consultaSQL += "FROM horario_trabajo t ";
            consultaSQL += "WHERE t.estado = 1 ";
            try
            {
                MySqlDataReader resultadoMysql = gestorDaoMysql.runQuery(consultaSQL);
                while (resultadoMysql.Read())
                {
                    horario = GetParametersHorario(resultadoMysql);
                    horarios.Add(horario);
                }
            }
            catch (Exception err)
            {
                throw err;
            }
            return horarios;
        }
        public Horario GetParametersHorario(MySqlDataReader resultadoMysql)
        {
            Horario horario = new Horario();
            horario.HorarioId = Convert.ToInt32(resultadoMysql["idhorario_trabajo"]);
            horario.Nombre = resultadoMysql["nombre"].ToString();
            return horario;
        }
    }
}
