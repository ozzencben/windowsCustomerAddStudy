using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to clear the form field?", "Clear Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                //ClearForm();
                formElementİndexClear();
            }
            else
            {

            }
        }

        private void ClearForm()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    TextBox T = (TextBox)item;
                    T.Text = string.Empty;
                }
            }
        }

        private void formElementİndexClear()
        {
            ((TextBox)this.Controls["txtName"]).Text = string.Empty;
            ((TextBox)this.Controls["txtSurname"]).Text = string.Empty;
            ((TextBox)this.Controls["txtEmail"]).Text = string.Empty;
            ((TextBox)this.Controls["txtPhone"]).Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int processResult = newCustomerAddMethod(new customer()
            {
                ıd = Guid.NewGuid(),
                name = txtName.Text,
                surname = txtSurname.Text,
                email = txtEmail.Text,
                phoneNumber = txtPhone.Text
            });

            MessageBox.Show("Your customer addition process is successful.", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            formElementİndexClear();
        }

        private int newCustomerAddMethod(customer data)
        {
            database.customers.Add(data);
            return 1;
        }

        private void btnRecordPreview_Click(object sender, EventArgs e)
        {
            Add_Form_Record_Preview addFormRecordPreview = new Add_Form_Record_Preview();
            
            ((TextBox)addFormRecordPreview.Controls["txtNameForm2"]).Text = txtName.Text;
            ((TextBox)addFormRecordPreview.Controls["txtSurnameForm2"]).Text = txtSurname.Text;
            ((TextBox)addFormRecordPreview.Controls["txtEmailForm2"]).Text = txtEmail.Text;
            ((TextBox)addFormRecordPreview.Controls["txtPhoneForm2"]).Text = txtPhone.Text;
            
            addFormRecordPreview.ShowDialog();
            
        }
    }
}
