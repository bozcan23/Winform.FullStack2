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
using Winform.FullStack2.Defaults;
using Winform.FullStack2.DTO;
using Winform.FullStack2.Entities;

namespace Winform.FullStack2.Forms
{
    public partial class ProductForm : Form
    {
        UserLoginResponseDto responseDto;
        Products selectedProduct;
        string userFullname;
        public ProductForm(string userFullname)
        {
            InitializeComponent();
            this.userFullname = userFullname;
            Reload();
        }


        public void Reload()
        {
            var notes = ListProducts();
            listNote.DataSource = null;
            listNote.DataSource = notes;
            listNote.DisplayMember = "Name";
            listNote.ValueMember = "Id";
            //listNote.Items.Clear();
            //listNote.Items.AddRange(notes.ToArray());
            //listNote.DisplayMember = "Name";
            //listNote.ValueMember = "Id";

        }
        //private void NoteForm_Load(object sender, EventArgs e)
        //{
        //    lblUser.Text = userFullname;
        //}
        private List<Products> ListProducts()
        {
            var productList = new List<Products>();
            SqlConnection connection = new SqlConnection("server=.\\SQLEXPRESS; database =DbTutorial;integrated security=true");
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "select * from Products";



            connection.Open();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var product = new Products();
                product.Id = Convert.ToInt32(reader[0]);
                product.Name = Convert.ToString(reader[1]);
                product.Stock = Convert.ToInt32(reader[2]);
                productList.Add(product);
            }
            reader.Close();
            connection.Close();
            return productList;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            var item = listNote.SelectedItem as Products;
            lblTest.Text = item.Stock.ToString();
            lblUser.Text = userFullname;
        }

        private void ProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void listNote_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listNote.SelectedItem != null)
            {
                selectedProduct = listNote.SelectedItem as Products;
                txtStock.Text = selectedProduct.Stock + "";
                txtProductName.Text = selectedProduct.Name;
                lblTest.Text = selectedProduct.Stock.ToString();
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                if (!string.IsNullOrEmpty(txtStock.Text) && !string.IsNullOrEmpty(txtProductName.Text))

                {
                    UpdateProduct(new Products { Name = txtProductName.Text, Stock = int.Parse(txtStock.Text), Id = selectedProduct.Id });
                    Reload();
                }
            }
            else
            {
                MessageBox.Show(MessageDefaults.PRODUCT_NOT_SELECTED);
            }

        }

        private int UpdateProduct(Products updatedProducts)
        {
            SqlConnection connection = new SqlConnection("server=.\\SQLEXPRESS; database =DbTutorial;integrated security=true");
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = connection;
            command.CommandText = "Update Products set Name=@name , Stock=@stock where Id=@id";
            command.Parameters.AddWithValue("@name", updatedProducts.Name);
            command.Parameters.AddWithValue("@stock", updatedProducts.Stock);
            command.Parameters.AddWithValue("@id", updatedProducts.Id);

            connection.Open();
            int effectedRows = command.ExecuteNonQuery();

            connection.Close();
            return effectedRows;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
            selectedProduct = null;
        }

        private void ClearText()
        {
            txtProductName.Text = string.Empty;
            txtStock.Text = string.Empty;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProductName.Text) && !string.IsNullOrEmpty(txtStock.Text))
            {
                SqlConnection connection = new SqlConnection("server=.\\SQLEXPRESS; database =DbTutorial;integrated security=true");
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = "insert into Products values (@name,@stock)";

                var stock = int.Parse(txtStock.Text);
                command.Parameters.AddWithValue("@name", txtProductName.Text);
                command.Parameters.AddWithValue("@stock", stock);


                connection.Open();
                var effectedRows = command.ExecuteNonQuery();
                command.Parameters.Clear();
                connection.Close();

                if (effectedRows > 0)
                {
                    MessageBox.Show("Ürün eklendi");
                    Reload();
                    ClearText();
                }
            }
            else
            {
                MessageBox.Show("Alanları boş bırakmayınız");
            }


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
            {
                SqlConnection connection = new SqlConnection("server=.\\SQLEXPRESS; database =DbTutorial;integrated security=true");
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = "delete from Products where Id=@id";
                command.Parameters.AddWithValue("@id", selectedProduct.Id);

                connection.Open();
                var effectedRows = command.ExecuteNonQuery();
                command.Parameters.Clear();
                connection.Close();
                Reload();
                ClearText();
            }

            else
            {
                MessageBox.Show(MessageDefaults.PRODUCT_NOT_SELECTED);
            }
        }

        //private void btnBack_Click(object sender, EventArgs e)
        //{
        //    NavigationForm navigationForm = new NavigationForm(responseDto);
        //    navigationForm.Show();
        //    this.Hide();
        //}

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            NavigationForm navigationForm=new NavigationForm(responseDto);
            navigationForm.Show();
            this.Hide();
        }
    }
}
