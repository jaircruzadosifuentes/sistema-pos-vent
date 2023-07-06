using CapaEntidades;
using CapaPersistencia.Dao;
using CapaPersistencia.Mysql;
using System;
using System.Collections.Generic;
using System.Data;

namespace CapaAplicacion
{
    public class ManagmentOperations
    {
        private readonly OperationDaoMysql _operationDaoMysql;
        private readonly GestorDaoMysql _gestorDaoMysql;

        public ManagmentOperations()
        {
            _gestorDaoMysql = new GestorDaoMysql();
            _operationDaoMysql = new OperationDaoMysql(_gestorDaoMysql);
        }
        public DataTable ServiceGetAllOperationsForPermiss(string userCode)
        {
            try
            {
                _gestorDaoMysql.connectionOpen();
                var dtOperations = _operationDaoMysql.DALGetAllOperationsForPermiss(userCode);
                _gestorDaoMysql.connectionClose();
                return dtOperations;
            }
            catch (Exception ex)
            {
                _gestorDaoMysql.connectionClose();
                throw ex;
            }
        }  
        public DataTable ServiceGetOperationForCodUser(string userCode)
        {
            try
            {
                _gestorDaoMysql.connectionOpen();
                var dtOperations = _operationDaoMysql.DALGetOperationForCodUser(userCode);
                _gestorDaoMysql.connectionClose();
                return dtOperations;
            }
            catch (Exception ex)
            {
                _gestorDaoMysql.connectionClose();
                throw ex;
            }
        } 
        public DataTable ServiceGetAllOperationsForCode(string codeOperation)
        {
            try
            {
                _gestorDaoMysql.connectionOpen();
                var dtOperations = _operationDaoMysql.DALGetAllOperationsForCode(codeOperation);
                _gestorDaoMysql.connectionClose();
                return dtOperations;
            }
            catch (Exception ex)
            {
                _gestorDaoMysql.connectionClose();
                throw ex;
            }
        }
        public List<Operation> ListOperations(string userName, int tipoTreeView)
        {
            try
            {
                _gestorDaoMysql.connectionOpen();
                List<Operation> listOperations = _operationDaoMysql.ListOperations(userName, tipoTreeView);
                _gestorDaoMysql.connectionClose();
                return listOperations;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
