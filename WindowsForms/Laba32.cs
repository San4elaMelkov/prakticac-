using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsForms.Models;

namespace WindowsForms
{
    public partial class Laba32 : LayoutForm
    {
        MainForm parent;
        private SqlConnection connection = null;

        Model auction;

        public Laba32(MainForm parent) :base()
        {
            this.parent = parent;
            InitializeComponent();
        }

        public Laba32()
        {
           
        }

        private void Laba32_FormClosed(object sender, FormClosedEventArgs e)
        {
            parent.Show();
        }

        private DataGridView SelectFromDB(Model model, DataGridView dataGrid, SqlConnection connection, string query)
        {
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.AllowUserToAddRows = false;
            model.adapter = new SqlDataAdapter(query, connection);
            model.dataSet = new DataSet();
            model.adapter.Fill(model.dataSet);
            dataGrid.DataSource = model.dataSet.Tables[0];
            return dataGrid;
        }

        private DataGridView DeleteRows(DataGridView dataGrid)
        {
            foreach (DataGridViewRow row in dataGrid.SelectedRows)
            {
                dataGrid.Rows.Remove(row);
            }
            return dataGrid;
        }

        private Model AddRow(Model model)
        {
            DataRow row = model.dataSet.Tables[0].NewRow();
            model.dataSet.Tables[0].Rows.Add(row);
            return model;
        }

        private void Laba32_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConfigDB"].ConnectionString);
            connection.Open();
            auction = new Model();

            dataGridAuction = this.SelectFromDB(auction, dataGridAuction, connection, "SELECT * FROM [Auctions]");

        }

        private void add_ac_Click(object sender, EventArgs e)
        {
            auction = this.AddRow(auction);
        }

        private void update_ac_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(auction.adapter);
            auction.adapter.InsertCommand = new SqlCommand("INSERT INTO [Mechanics] (DateTime, Place, SpecificationId)" +
                " VALUES(@DateTime, @Place, @SpecificationId)", connection);
            auction.adapter.InsertCommand.CommandType = CommandType.Text;
            auction.adapter.InsertCommand.Parameters.Add(new SqlParameter("@DateTime", SqlDbType.DateTime, 0, "DateTime"));
            auction.adapter.InsertCommand.Parameters.Add(new SqlParameter("@Place", SqlDbType.VarChar, 255, "Place"));
            auction.adapter.InsertCommand.Parameters.Add(new SqlParameter("@SpecificationId", SqlDbType.Int, 0, "SpecificationId"));

            SqlParameter parameter = auction.adapter.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
            parameter.Direction = ParameterDirection.Output;

            auction.adapter.Update(auction.dataSet);
        }

        private void delete_ac_Click(object sender, EventArgs e)
        {
            dataGridAuction = this.DeleteRows(dataGridAuction);
        }
    }
}
