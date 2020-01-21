using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Service {
    public class DatabaseManager {
        private bool connectionState = false;

        private MySqlConnection connection = null;
        public MySqlConnection Connection {
            get { return connection; }
        }

        private DatabaseManager() {
            connectionState = false;
            connection = new MySqlConnection("Server=www.imnorb.com; database=donkom; UID=donkom; password=DonokmEke2020; charset=utf8;");
        }

        private static DatabaseManager _instance = null;
        public static DatabaseManager Instance() {
            if (_instance == null) _instance = new DatabaseManager();
            return _instance;
        }

        public bool Connect() {            
            if (!connectionState) {
                connection.Open();
                connectionState = true;
            }
            return true;
        }

        public MySqlDataReader DataReader(string query) {
            return new MySqlCommand(query, Connection).ExecuteReader();
        }

        public int ExecuteNonQuery(string query) { 
            return new MySqlCommand(query, Connection).ExecuteNonQuery();
        }

        public void Close() {
            if (connectionState) {
                connection.Close();
                connectionState = false;
            }
        }
    }
}