using Npgsql; 
using System;
using System.Data;
using System.Windows.Forms;

namespace Project10_PostgreSQLToDoListApp
{
    public partial class FrmToDoListApp : Form
    {
        public FrmToDoListApp()
        {
            InitializeComponent();
        }

        private void FrmToDoListApp_Load(object sender, EventArgs e)
        {
            try
            {
                
                string connectionString = "Server=localHost; port=5432; Database=DbProject10ToDoApp; user ID=postgres; Password=1234";
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    
                    string query = "SELECT * FROM \"ToDoLists\"";

                    
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
                    DataTable dataSet = new DataTable();
                    adapter.Fill(dataSet);

                    
                    dataGridView1.AutoGenerateColumns = true; 
                    dataGridView1.DataSource = dataSet;

                    
                    dataGridView1.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
