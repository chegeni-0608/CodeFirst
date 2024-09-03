using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeFirstSample.ViewModels;
using Dapper;

namespace CodeFirstSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Buttom Event
        string connectionstring = "Data Source=.; Initial Catalog=Categories;  integrated security=True";

        private void btnInsertWithDapper_Click(object sender, EventArgs e)
        {
            {
                using (IDbConnection connection = new SqlConnection(connectionstring))
                {
                    string commandText = "insert Categories(CategoryName,Description) value (@CategoryName,@Description)";
                    var parameters = new DynamicParameters();
                    parameters.Add("CategoryName", "Test123");
                    parameters.Add("Description", "TestABC");
                    connection.Execute(commandText,parameters);
                } 
            }
           #endregion
        }

        private void btnIsertWithdapperSp_Click(object sender, EventArgs e)
        {
            using (IDbConnection connection = new SqlConnection(connectionstring))
            {
                string commandText = "sp_GetCategories_Insert";
                var parameters = new DynamicParameters();
                parameters.Add("CategoryName", "Test123");
                parameters.Add("description", "TestABC");
                //add output parameters
                parameters.Add("categoryId", direction: ParameterDirection.Output, dbType: DbType.Int32);
                connection.Execute(commandText, parameters, commandType: CommandType.StoredProcedure);

                //read output parameter value
                int categoryId = parameters.Get<int>("categoryId");
            }
        }

        private void btnSelectWithDapper_Click(object sender, EventArgs e)
        {
            using (IDbConnection connection = new SqlConnection(connectionstring))
            {
                string command = "Select * from categories";
                var result = connection.Query<CategoryViewModel>(command);
                
                dataGridView1.DataSource = result;
            }
        }

        private void btnSelectWithDapperSP_Click(object sender, EventArgs e)
        {
            using (IDbConnection connection = new SqlConnection(connectionstring))
            {
                string command = "sp_GetCategories_GetAll";
                var parameters = new DynamicParameters();
                parameters.Add("totalItemCount", direction:ParameterDirection.Output, dbType:DbType.Int32);
                var result = connection.Query<CategoryViewModel>(command, parameters, commandType: CommandType.StoredProcedure);

                dataGridView1.DataSource = result;

                int totalRecordCount = parameters.Get<int>("totalItemCount");
            }
        }

        private void btnMultiSelectQueryWithDapper_Click(object sender, EventArgs e)
        {
            using (IDbConnection connection = new SqlConnection(connectionstring))
            {
                string command = "select * from Categories; select * from Products";
                var result = connection.QueryMultiple(command);

                //get categories
                var categories = result.Read<CategoryViewModel>();
                var products = result.Read<ProductViewModel>();


            }
        }
    }
} 

