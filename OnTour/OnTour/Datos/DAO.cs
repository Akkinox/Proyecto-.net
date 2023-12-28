using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Text;



namespace OnTour.Datos
{
    class DAO
    {
        
        public DAO(){}

        public static DataTable logear(string usuario, string contraena)
        {

            try
            {
                Conexion conn = new Conexion();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn.Conn;
                cmd.Connection.Open();
                cmd.CommandText = "Select * from usuario where nom_usuario = @user and contrasena = @pass";
                cmd.Parameters.AddWithValue("@user", usuario);
                cmd.Parameters.AddWithValue("@pass", contraena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                return dt;
                

            }
            catch (SqlException i)
            {

                throw i;

            }

        }

        public static DataTable Recuperar(string usuario)
        {

            try
            {
                Conexion conn = new Conexion();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn.Conn;
                cmd.Connection.Open();
                cmd.CommandText = "select * from USUARIO where NOM_USUARIO = @user";
                cmd.Parameters.AddWithValue("@user", usuario);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                return dt;


            }
            catch (SqlException i)
            {

                throw i;

            }

        }

        public static DataTable getClientes()
        {

            try
            {
                Conexion conn = new Conexion();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn.Conn;
                cmd.Connection.Open();
                cmd.CommandText = "select * from cliente";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                return dt;

            }
            catch (SqlException i)
            {
                throw i;

            }

        }
        public static DataTable getPaquetes()
        {

            try
            {
                Conexion conn = new Conexion();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn.Conn;
                cmd.Connection.Open();
                cmd.CommandText = "select * from paquete_turistico";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                return dt;

            }
            catch (SqlException i)
            {
                throw i;

            }

        }
        public static DataTable getEstado()
        {

            try
            {
                Conexion conn = new Conexion();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn.Conn;
                cmd.Connection.Open();
                cmd.CommandText = "select * from estado_contrato";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                return dt;

            }
            catch (SqlException i)
            {
                throw i;

            }

        }
        public static DataTable getModalidad()
        {

            try
            {
                Conexion conn = new Conexion();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn.Conn;
                cmd.Connection.Open();
                cmd.CommandText = "select * from modalidad_pago";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                return dt;

            }
            catch (SqlException i)
            {
                throw i;

            }

        }
        public static DataTable getEjecutivos()
        {

            try
            {
                Conexion conn = new Conexion();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn.Conn;
                cmd.Connection.Open();
                cmd.CommandText = "select * from ejecutivo";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                return dt;

            }
            catch (SqlException i)
            {
                throw i;

            }

        }

    }
}
