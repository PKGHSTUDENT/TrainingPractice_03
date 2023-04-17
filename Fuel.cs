using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace TrainingPractice_03
{
    public partial class Fuel : Form
    {
        private readonly string connString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=GasStation;Integrated Security=True";
        public Fuel()
        {
            InitializeComponent();
            FillDGV();
        }

        private void FillDGV(string filter = "")
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                string query = "SELECT * FROM fuel" + filter;
                SqlCommand command = new SqlCommand(query, connection);

                if (!string.IsNullOrEmpty(filter))
                {
                    command.Parameters.AddWithValue("@filterPrice", double.Parse(filterPriceTextBox.Text));
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void showFuelByFilter_Click(object sender, System.EventArgs e)
        {
            if (filterPriceTextBox.Text.Length != 0)
            {
                string filterOperator;
                if (moreRadioButton.Checked) filterOperator = ">";
                else filterOperator = "<";
                FillDGV($" WHERE price {filterOperator} @filterPrice");
            }
            else FillDGV();
        }

        private void addFuelButton_Click(object sender, System.EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO fuel (fuel_name, price, provider_id) " +
                    "VALUES (@fuel_name, @price, @provider_id)", connection);
                command.Parameters.AddWithValue("@fuel_name", fuelNameTextBox.Text);
                command.Parameters.AddWithValue("@price", double.Parse(priceTextBox.Text));
                command.Parameters.AddWithValue("@provider_id", int.Parse(providerIdTextBox.Text));
                command.ExecuteNonQuery();
            }
        }
    }
}
