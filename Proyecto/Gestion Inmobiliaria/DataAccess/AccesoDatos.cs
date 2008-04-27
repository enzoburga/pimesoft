using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Microsoft.ApplicationBlocks.Data;

namespace GI.DA
{
    public class mngConexion
    {
        private static SqlConnection xConn = new SqlConnection(GetConnString);
        private static SqlTransaction trans;
        private static string connString = System.Configuration.ConfigurationSettings.AppSettings["ConnString"].ToString();


        internal static string GetConnString
        {
            get { return connString;}
        }

        internal static SqlConnection GetConn
        {
            get
            {
                if (xConn.State != ConnectionState.Open)
                {
                    xConn.ConnectionString = GetConnString;
                    xConn.Open();
                }
                return xConn;
            }
        }

        internal static void CerrarConexion()
        {
            xConn.Close();
        }

        internal static SqlTransaction GetTrans
        {
            get
            {
                return trans;
            }
        }

        public static void InicializarTransaction()
        {
            if (xConn.State != ConnectionState.Open)
                xConn.Open();

            trans = xConn.BeginTransaction();
        }

        public static void TransCommit()
        {
            trans.Commit();
            trans = null;
            xConn.Close();
        }

        public static void TransRollBack()
        {
            trans.Rollback();
            trans = null;
            xConn.Close();
        }
    }


    public class AccesoDatos
    {

        internal static SqlDataReader RecuperarDatos(string spName, object[] pValores, string[] pNombres)
        {
            try
            {
                return AccesoDatos.ExecuteReader(spName, ArmarParametros(pValores, pNombres));
            }
            catch
            {
                return null;
            }
        }

        internal static int InsertarRegistro(string spName, object[] pValores, string[] pNombres)
        {
            
            try
            {
                return int.Parse(AccesoDatos.ExecuteScalar(spName, AccesoDatos.ArmarParametros(pValores, pNombres)).ToString());
            }
            catch 
            {
                return 0;
            }
        }

        internal static bool ActualizarRegistro(string spName, object[] pValores, string[] pNombres)
        {
            try
            {
                return AccesoDatos.ExecuteNonQuery(spName, AccesoDatos.ArmarParametros(pValores, pNombres)) > 0;
            }
            catch
            {
                return false;
            }
        }

        internal static bool EliminarRegistro(string spName, object[] pValores, string[] pNombres)
        {
            try
            {
                return AccesoDatos.ExecuteNonQuery(spName, AccesoDatos.ArmarParametros(pValores, pNombres)) > 0;
            }
            catch
            {
                return false;
            }
        }

        private static SqlParameter[] ArmarParametros(object[] valores, string[] nombres)
        {
            int cObj = valores.GetLength(0);


            SqlParameter[] parametros = new SqlParameter[cObj];

            for (int i = 0; i < cObj; ++i)
                parametros[i] = new SqlParameter(nombres[i], valores[i]);

            return parametros;
        }

        private static int ExecuteNonQuery(string spName, SqlParameter[] parametros)
        {
            try
            {
                int ret = 0;

                if (mngConexion.GetTrans == null)
                {
                    ret = SqlHelper.ExecuteNonQuery(mngConexion.GetConn, CommandType.StoredProcedure, spName, parametros);
                    mngConexion.CerrarConexion();
                }
                else
                {
                    ret = SqlHelper.ExecuteNonQuery(mngConexion.GetTrans, CommandType.StoredProcedure, spName, parametros);
                }

                return ret;
            }
            catch 
            {
                return 0;
            }
        }

        private static object ExecuteScalar(string spName)
        {
            try
            {
                object ret = null;


                if (mngConexion.GetTrans == null)
                {
                    ret = SqlHelper.ExecuteScalar(mngConexion.GetConn, CommandType.StoredProcedure, spName);
                    mngConexion.CerrarConexion();
                }
                else
                {
                    ret = SqlHelper.ExecuteScalar(mngConexion.GetTrans, CommandType.StoredProcedure, spName);
                }
                return ret;
            }
            catch
            {
                return 0;
            }

        }

        private static object ExecuteScalar(string spName, SqlParameter[] parametros)
        {
            try
            {
                object ret = null;


                if (mngConexion.GetTrans == null)
                {
                    ret = SqlHelper.ExecuteScalar(mngConexion.GetConn, CommandType.StoredProcedure, spName, parametros);
                    mngConexion.CerrarConexion();
                }
                else
                {
                    ret = SqlHelper.ExecuteScalar(mngConexion.GetTrans, CommandType.StoredProcedure, spName, parametros);
                }
                return ret;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }

        private static SqlDataReader ExecuteReader(string spName, SqlParameter[] parametros)
        {
            try
            {
                if (mngConexion.GetTrans == null)
                    return SqlHelper.ExecuteReader(mngConexion.GetConnString, CommandType.StoredProcedure, spName, parametros);
                else
                    return SqlHelper.ExecuteReader(mngConexion.GetTrans, CommandType.StoredProcedure, spName, parametros);

            }
            catch(Exception ex)
            //catch
            {
                return null;
            }
        }

        private static SqlDataReader ExecuteReader(string spName)
        {
            try
            {
                if (mngConexion.GetTrans == null)
                    return SqlHelper.ExecuteReader(mngConexion.GetConnString, CommandType.StoredProcedure, spName);
                else
                    return SqlHelper.ExecuteReader(mngConexion.GetTrans, CommandType.StoredProcedure, spName);

            }
            catch
            {
                return null;
            }
        }

    }
}
