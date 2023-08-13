using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform.FullStack2.DTO;

namespace Winform.FullStack2.Forms
{
    public partial class NavigationForm : Form
    {
        UserLoginResponseDto responseDto;
        public NavigationForm(UserLoginResponseDto responseDto)
        {
            InitializeComponent();
            this.responseDto = responseDto;

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm(responseDto.FullName);
            form.Show();
            this.Hide();
        }

        private void btnNote_Click(object sender, EventArgs e)
        {
            NotesForm form = new NotesForm(responseDto);
            form.Show();
            this.Hide();
        }

        private void NavigationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserLoginForm.
        }
    }
}
