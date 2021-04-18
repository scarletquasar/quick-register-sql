using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUICKREGISTERSQL
{
    public partial class Main_ : Form
    {
        private string ConnectionString;
        private string ClearAllCommand = "DELETE FROM People;";
        private SqlConnection Conn;
        public Main_()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter Adapter = new SqlDataAdapter();
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();
                Adapter.InsertCommand = new SqlCommand("USE Teste;", Conn);
                Adapter.InsertCommand = new SqlCommand("INSERT INTO People (PersonName, PersonAge) VALUES ('" + pName.Text + "', '"
                + Age.Text + "');", Conn);
                Adapter.InsertCommand.ExecuteNonQuery();
                Conn.Close();
            }
            catch(Exception re) { MessageBox.Show(re + ""); ; }
        }

        private void ClearRegisterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter Adapter = new SqlDataAdapter();
                Conn = new SqlConnection(ConnectionString);
                Conn.Open();
                Adapter.InsertCommand = new SqlCommand("USE Teste;", Conn);
                Adapter.InsertCommand = new SqlCommand(ClearAllCommand, Conn);
                Adapter.InsertCommand.ExecuteNonQuery();
                Conn.Close();
            }
            catch (Exception re) { MessageBox.Show(re + ""); }
        }

        private void ConnString_TextChanged(object sender, EventArgs e)
        {
            ConnectionString = String.Join("", ConnString.Text);
        }
    }
}
