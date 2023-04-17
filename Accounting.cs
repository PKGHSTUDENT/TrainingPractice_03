using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TrainingPractice_03
{
    public partial class Accounting : Form
    {
        private readonly string connString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=GasStation;Integrated Security=True";

        public Accounting()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                string query = "SELECT * FROM accounting";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void addButton_Click(object sender, System.EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO accounting (fuel_id, date, volume_start, volume_sales) " +
                    "VALUES (@fuel_id, @date, @volume_start, @volume_sales)", connection);
                command.Parameters.AddWithValue("@fuel_id", int.Parse(fuelIdTextBox.Text));
                command.Parameters.AddWithValue("@date", dateTimePicker.Value);
                command.Parameters.AddWithValue("@volume_start", int.Parse(volumeStartTextBox.Text));
                command.Parameters.AddWithValue("@volume_sales", int.Parse(volumeSalesTextBox.Text));

                command.ExecuteNonQuery();
            }
            LoadData();
        }
    }
}
