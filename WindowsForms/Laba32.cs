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

        private Model auction;
        private Model spetific;

        private Model thing;
        private Model Users;
        private Model LogAuctions;

        public Laba32(MainForm parent) :base()
        {
            this.parent = parent;
            InitializeComponent();
        }

        public Laba32()
        {
           
        }

        private void Laba32_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConfigDB"].ConnectionString);
            connection.Open();

            auction = new Model();
            spetific = new Model();
            thing = new Model();
            Users = new Model();
            LogAuctions = new Model();


            dataGridSpec = this.SelectFromDB(spetific, dataGridSpec, connection, "SELECT * FROM [Spetifications]");
            dataGridAuction = this.SelectFromDB(auction, dataGridAuction, connection, "SELECT * FROM [Auctions]");
            dataGridThing = this.SelectFromDB(thing, dataGridThing, connection, "SELECT * FROM [Things]");
            dataGridUsers = this.SelectFromDB(Users, dataGridUsers, connection, "SELECT * FROM [Users]");
            dataGridLogAuctions = this.SelectFromDB(LogAuctions, dataGridLogAuctions, connection, "SELECT * FROM [LogAuctions]");

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
            dataGrid.Columns["Id"].ReadOnly = true;
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

        

        private void add_ac_Click(object sender, EventArgs e)
        {
            auction = this.AddRow(auction);
        }

        private void update_ac_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(auction.adapter);
            auction.adapter.InsertCommand = new SqlCommand("INSERT INTO [Auctions] (DateTime, Place, SpecificationId)" +
                "VALUES(@DateTime, @Place, @SpecificationId)", connection);
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

        private void update_spec_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(spetific.adapter);
            spetific.adapter.InsertCommand = new SqlCommand("INSERT INTO [Spetifications] (Title)" +
                " VALUES(@Title)", connection);
            spetific.adapter.InsertCommand.CommandType = CommandType.Text;
            spetific.adapter.InsertCommand.Parameters.Add(new SqlParameter("@Title", SqlDbType.VarChar, 255, "Title"));

            SqlParameter parameter = spetific.adapter.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
            parameter.Direction = ParameterDirection.Output;

            spetific.adapter.Update(spetific.dataSet);
        }

        private void add_spec_Click(object sender, EventArgs e)
        {
            spetific = this.AddRow(spetific);
        }

        private void delete_spec_Click(object sender, EventArgs e)
        {
            dataGridSpec = this.DeleteRows(dataGridSpec);
        }

        private void update_think_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(thing.adapter);
            thing.adapter.InsertCommand = new SqlCommand("INSERT INTO [Things] (Name, Price, OwnerId, Lot, AuctionId, Description, SpecificationId)" +
                " VALUES(@Name, @Price, @OwnerId, @Lot, @AuctionId, @Description, @SpecificationId)", connection);
            thing.adapter.InsertCommand.CommandType = CommandType.Text;
            thing.adapter.InsertCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar, 255, "Name"));
            thing.adapter.InsertCommand.Parameters.Add(new SqlParameter("@Price", SqlDbType.Int, 0, "Price"));
            thing.adapter.InsertCommand.Parameters.Add(new SqlParameter("@OwnerId", SqlDbType.Int, 0, "OwnerId"));
            thing.adapter.InsertCommand.Parameters.Add(new SqlParameter("@Lot", SqlDbType.Int, 0, "Lot"));
            thing.adapter.InsertCommand.Parameters.Add(new SqlParameter("@AuctionId", SqlDbType.Int, 0, "AuctionId"));
            thing.adapter.InsertCommand.Parameters.Add(new SqlParameter("@Description", SqlDbType.Text, 0, "Description"));
            thing.adapter.InsertCommand.Parameters.Add(new SqlParameter("@SpecificationId", SqlDbType.Int, 0, "SpecificationId"));


            SqlParameter parameter = thing.adapter.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
            parameter.Direction = ParameterDirection.Output;

            thing.adapter.Update(thing.dataSet);
        }

        private void add_think_Click(object sender, EventArgs e)
        {
            thing = this.AddRow(thing);
        }

        private void delete_think_Click(object sender, EventArgs e)
        {
            dataGridThing = this.DeleteRows(dataGridThing);
        }

        private void addUsers_Click(object sender, EventArgs e)
        {
            Users = this.AddRow(Users);
        }

        private void deleteUsers_Click(object sender, EventArgs e)
        {
            dataGridUsers = this.DeleteRows(dataGridUsers);
        }

        private void updateUsers_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(Users.adapter);
            Users.adapter.InsertCommand = new SqlCommand("INSERT INTO [Users] (Name, Money)" +
                " VALUES(@Name, @Money)", connection);
            Users.adapter.InsertCommand.CommandType = CommandType.Text;
            Users.adapter.InsertCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar, 255, "Name"));
            Users.adapter.InsertCommand.Parameters.Add(new SqlParameter("@Money", SqlDbType.Int, 0, "Money"));


            SqlParameter parameter = Users.adapter.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
            parameter.Direction = ParameterDirection.Output;

            Users.adapter.Update(Users.dataSet);
        }

        private void add_Outfit_Click(object sender, EventArgs e)
        {
            LogAuctions = this.AddRow(LogAuctions);

        }

        private void deleteOutfit_Click(object sender, EventArgs e)
        {
            dataGridLogAuctions = this.DeleteRows(dataGridLogAuctions);

        }

        private void updateOutfit_Click(object sender, EventArgs e)
        {

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(LogAuctions.adapter);
            LogAuctions.adapter.InsertCommand = new SqlCommand("INSERT INTO [LogAuctions] (AuctionId, ThinkId)" +
                 " VALUES(@AuctionId, @ThinkId)", connection);
            LogAuctions.adapter.InsertCommand.CommandType = CommandType.Text;
            LogAuctions.adapter.InsertCommand.Parameters.Add(new SqlParameter("@AuctionId", SqlDbType.Int, 0, "AuctionId"));
            LogAuctions.adapter.InsertCommand.Parameters.Add(new SqlParameter("@ThinkId", SqlDbType.Int, 0, "ThinkId"));


            SqlParameter parameter = LogAuctions.adapter.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
            parameter.Direction = ParameterDirection.Output;

            LogAuctions.adapter.Update(LogAuctions.dataSet);
            
        }
    }
}
