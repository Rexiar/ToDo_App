using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ToDo_App
{
    public partial class Form1 : Form
    {
        public static string getConnectionString() 
        {
            string basePath = Application.StartupPath;
            int index = basePath.IndexOf("ToDo_App");
            string path = basePath.Substring(0, index + @"ToDo_App\ToDo_App".Length) + @"\Database.mdf";
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="+path+ ";Integrated Security=True;Connect Timeout=30";
            return connectionString;
            //static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Code\C#\ToDo\ToDo_App\ToDo_App\Database.mdf;Integrated Security=True;Connect Timeout=30";

        }
        static string connectionString = getConnectionString();
        public Form1()
        {
            InitializeComponent();
        }


        public void refreshTable()
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from ActivityTracker", dbConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            testCheckBox.Items.Clear();
            foreach (DataTable dt in dataSet.Tables)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    testCheckBox.Items.Add(dr["Aktivitas"].ToString());
                }
            }
            dbConnection.Close();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO ActivityTracker (Aktivitas, Selesai) VALUES ('" + titleTextBox.Text + "','" + 1 + "')", dbConnection);
            cmd.ExecuteNonQuery();
            dbConnection.Close();
            refreshTable();
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM ActivityTracker WHERE Id='"+ testCheckBox.SelectedIndex+ "'", dbConnection);
            Console.Write(testCheckBox.SelectedIndex);
            cmd.ExecuteNonQuery();
            dbConnection.Close();
            refreshTable();
        }
    }
}
