using System;
using System.Data;
using System.Data.OleDb;

namespace ConsumerGuide
{
    class ManagerOleDB
    {
        public static int row { get; set; }

        string connection = "Provider=Microsoft.Ace.OLEDB.12.0; Data Source=" +
            AppDomain.CurrentDomain.BaseDirectory + "\\DataBase.accdb";
        OleDbConnection connect;
        DataTable dataTable;
        string value;

        public DataView BindGrid(string selectSQL)
        {
            connect = new OleDbConnection(connection);
            if (connect.State == ConnectionState.Open)
                connect.Open();

            OleDbCommand command = new OleDbCommand(selectSQL, connect);

            OleDbDataAdapter da = new OleDbDataAdapter(command);

            dataTable = new DataTable();
            da.Fill(dataTable);

            connect.Close();

            return dataTable.AsDataView();
        }

        public OleDbDataReader ReaderDB(string selectSQL)
        {
            connect = new OleDbConnection(connection);
            connect.Open();

            OleDbCommand command = new OleDbCommand(selectSQL, connect);

            OleDbDataReader reader = command.ExecuteReader();
            return reader;
        }

        public string DataBaseTable(string selectSQL,int i)
        {
            connect = new OleDbConnection(connection);
            if (connect.State != ConnectionState.Open)
                connect.Open();

            OleDbCommand command = new OleDbCommand(selectSQL, connect);

            OleDbDataAdapter da = new OleDbDataAdapter(command);

            dataTable = new DataTable();
            da.Fill(dataTable);

            value = dataTable.Rows[row][i].ToString();
            return value;
        }
    }
}
