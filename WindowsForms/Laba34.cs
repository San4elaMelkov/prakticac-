using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Models;

namespace WindowsForms
{
    public partial class Laba34 : LayoutForm
    {
        private SqlConnection connection;
        private DataContext db = null;

        MainForm parent;

        private Model konf;

        private Model user;

        public Laba34(MainForm parent) : base()
        {
            this.parent = parent;
            InitializeComponent();
        }

        public Laba34()
        {

        }

        private void Laba34_FormClosed(object sender, FormClosedEventArgs e)
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
            Console.WriteLine(dataGrid);
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

        private void Laba34_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Laba34"].ConnectionString);

            db = new DataContext(ConfigurationManager.ConnectionStrings["Laba34"].ConnectionString);

            user = new Model();

            dataGridUsers = this.SelectFromDB(user, dataGridUsers, connection, "SELECT * FROM [Users]");

            konf = new Model();


            //Konf konf1 = new Konf();
            //User user1 = new User();

            dataGridKonf = this.SelectFromDB(konf, dataGridKonf, connection, "SELECT * FROM [Konf]");
            dataGridPriglos.Columns.Add("Id", "Id");
            dataGridPriglos.Columns.Add("Name", "Name");
            dataGridPriglos.Columns.Add("Email", "Email");
            dataGridPriglos.Columns.Add("Stupen", "Stupen");
            dataGridPriglos.Columns.Add("Zvanie", "Zvanie");
            dataGridPriglos.Columns.Add("Rabota", "Rabota");
            var priglos = from konf1 in db.GetTable<Konf>()
                          where konf1.isGost == 1
                          join user1 in db.GetTable<User>()
                          on konf1.UserId equals user1.Id
                          select user1;
            int counter = 0;
            foreach (User item in priglos)
            {
                dataGridPriglos.Rows.Add();
                dataGridPriglos.Rows[counter].Cells[0].Value = item.Id;
                dataGridPriglos.Rows[counter].Cells[1].Value = item.Name;
                dataGridPriglos.Rows[counter].Cells[2].Value = item.Email;
                dataGridPriglos.Rows[counter].Cells[3].Value = item.Stupen;
                dataGridPriglos.Rows[counter].Cells[4].Value = item.Zvanie;
                dataGridPriglos.Rows[counter].Cells[5].Value = item.Rabota;

                dataGridPriglos.AutoResizeColumns();
                counter++;
            }
            dataGridVznos.Columns.Add("Id", "Id");
            dataGridVznos.Columns.Add("Name", "Name");
            dataGridVznos.Columns.Add("Email", "Email");
            dataGridVznos.Columns.Add("Stupen", "Stupen");
            dataGridVznos.Columns.Add("Zvanie", "Zvanie");
            dataGridVznos.Columns.Add("Rabota", "Rabota");

            var vznos = from konf1 in db.GetTable<Konf>()
                          where konf1.Vznos > 1 && konf1.Vznos < 100000
                          join user1 in db.GetTable<User>()
                          on konf1.UserId equals user1.Id
                          select user1;
            counter = 0;
            foreach (User item in vznos)
            {
                dataGridVznos.Rows.Add();
                dataGridVznos.Rows[counter].Cells[0].Value = item.Id;
                dataGridVznos.Rows[counter].Cells[1].Value = item.Name;
                dataGridVznos.Rows[counter].Cells[2].Value = item.Email;
                dataGridVznos.Rows[counter].Cells[3].Value = item.Stupen;
                dataGridVznos.Rows[counter].Cells[4].Value = item.Zvanie;
                dataGridVznos.Rows[counter].Cells[5].Value = item.Rabota;

                dataGridVznos.AutoResizeColumns();
                counter++;
            }


        }

        private void addUsers_Click(object sender, EventArgs e)
        {
            user = this.AddRow(user);
        }

        private void addLogAuctions_Click(object sender, EventArgs e)
        {
            konf = this.AddRow(konf);
        }

        private void deleteLogAuctions_Click(object sender, EventArgs e)
        {
            dataGridKonf = this.DeleteRows(dataGridKonf);
        }

        private void deleteUsers_Click(object sender, EventArgs e)
        {
            dataGridUsers = this.DeleteRows(dataGridUsers);

        }

        private void updateUsers_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(user.adapter);
            user.adapter.InsertCommand = new SqlCommand("INSERT INTO [Users] (Name, Email, Stupen, Zvanie, Rabota)" +
                " VALUES(@Name, @Email, @Stupen, @Zvanie, @Rabota)", connection);
            user.adapter.InsertCommand.CommandType = CommandType.Text;
            user.adapter.InsertCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar, 255, "Name"));
            user.adapter.InsertCommand.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 255, "Email"));
            user.adapter.InsertCommand.Parameters.Add(new SqlParameter("@Stupen", SqlDbType.VarChar, 255, "Stupen"));
            user.adapter.InsertCommand.Parameters.Add(new SqlParameter("@Zvanie", SqlDbType.VarChar, 255, "Zvanie"));
            user.adapter.InsertCommand.Parameters.Add(new SqlParameter("@Rabota", SqlDbType.VarChar, 255, "Rabota"));

            SqlParameter parameter = user.adapter.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
            parameter.Direction = ParameterDirection.Output;

            user.adapter.Update(user.dataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void updateLogAuctions_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(konf.adapter);
            konf.adapter.InsertCommand = new SqlCommand("INSERT INTO [Konf] (UserId, Tema, Data1, Otmetka, Vznos, isGost)" +
                " VALUES(@UserId, @Tema, @Data1, @Otmetka, @Vznos, @isGost)", connection);
            konf.adapter.InsertCommand.CommandType = CommandType.Text;
            konf.adapter.InsertCommand.Parameters.Add(new SqlParameter("@UserId", SqlDbType.VarChar, 255, "UserId"));
            konf.adapter.InsertCommand.Parameters.Add(new SqlParameter("@Tema", SqlDbType.VarChar, 255, "Tema"));
            konf.adapter.InsertCommand.Parameters.Add(new SqlParameter("@Data1", SqlDbType.DateTime, 255, "Data1"));
            konf.adapter.InsertCommand.Parameters.Add(new SqlParameter("@Otmetka", SqlDbType.Int, 0, "Otmetka"));
            konf.adapter.InsertCommand.Parameters.Add(new SqlParameter("@Vznos", SqlDbType.Int, 0, "Vznos"));
            konf.adapter.InsertCommand.Parameters.Add(new SqlParameter("@isGost", SqlDbType.Int, 0, "isGost"));


            SqlParameter parameter = konf.adapter.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
            parameter.Direction = ParameterDirection.Output;

            konf.adapter.Update(konf.dataSet);
        }
    }
}
