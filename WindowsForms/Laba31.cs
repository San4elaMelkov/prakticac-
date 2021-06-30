using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using WindowsForms.Models;

namespace WindowsForms
{
    public partial class Laba31 : WindowsForms.LayoutForm
    {
        private MainForm parent;

        private SqlConnection connection = null;

        private Owner owner;

        private Car car;

        public Laba31(MainForm parent) :base()
        {
            this.parent = parent;
            InitializeComponent();
            
        }

        public Laba31()
        {

        }

        private void Laba31_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConfigDB"].ConnectionString);

            connection.Open();
            //автомобили
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            car = new Car();
            car.adapter = new SqlDataAdapter("SELECT * FROM [Cars]", connection);
            car.dataSet = new DataSet();
            car.adapter.Fill(car.dataSet);

            dataGridView1.DataSource = car.dataSet.Tables[0];
            // делаем недоступным столбец id для изменения
            dataGridView1.Columns["Id"].ReadOnly = true;

            //владельцы
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.AllowUserToAddRows = false;
            owner = new Owner();
            owner.adapter = new SqlDataAdapter("SELECT * FROM [Owners]", connection);
            owner.dataSet = new DataSet();
            owner.adapter.Fill(owner.dataSet);

            dataGridView2.DataSource = owner.dataSet.Tables[0];
            // делаем недоступным столбец id для изменения
            dataGridView2.Columns["Id"].ReadOnly = true;
        }


        private void update_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                dataGridView2.Rows.Remove(row);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataRow row = owner.dataSet.Tables[0].NewRow(); // добавляем новую строку в DataTable
            owner.dataSet.Tables[0].Rows.Add(row);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(owner.adapter);
            owner.adapter.InsertCommand = new SqlCommand("INSERT INTO [Owners] (Name, Phone, Age)" +
                " VALUES(@Name, @Phone, @Age)", connection);
            owner.adapter.InsertCommand.CommandType = CommandType.Text;
            owner.adapter.InsertCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar, 50, "Name"));
            owner.adapter.InsertCommand.Parameters.Add(new SqlParameter("@Phone", SqlDbType.VarChar, 50, "Phone"));
            owner.adapter.InsertCommand.Parameters.Add(new SqlParameter("@Age", SqlDbType.Int, 0, "Age"));

            SqlParameter parameter = owner.adapter.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
            parameter.Direction = ParameterDirection.Output;

            owner.adapter.Update(owner.dataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow row = car.dataSet.Tables[0].NewRow(); // добавляем новую строку в DataTable
            car.dataSet.Tables[0].Rows.Add(row);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void update_Click_1(object sender, EventArgs e)
        {
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(car.adapter);
            car.adapter.InsertCommand = new SqlCommand("INSERT INTO [Cars] (Name, Model, Price, Power)" +
                " VALUES(@Name, @Model, @Price, @Power)", connection);
            car.adapter.InsertCommand.CommandType = CommandType.Text;
            car.adapter.InsertCommand.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar, 50, "Name"));
            car.adapter.InsertCommand.Parameters.Add(new SqlParameter("@Model", SqlDbType.VarChar, 50, "Model"));
            car.adapter.InsertCommand.Parameters.Add(new SqlParameter("@Price", SqlDbType.Int, 0, "Price"));
            car.adapter.InsertCommand.Parameters.Add(new SqlParameter("@Power", SqlDbType.Int, 0, "Power"));

            SqlParameter parameter = car.adapter.InsertCommand.Parameters.Add("@Id", SqlDbType.Int, 0, "Id");
            parameter.Direction = ParameterDirection.Output;

            car.adapter.Update(car.dataSet);
        }
    }
}
