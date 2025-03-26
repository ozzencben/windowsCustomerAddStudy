using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsAppControl
{
    public partial class Add_Form_Record_Preview : Form
    {
        public Add_Form_Record_Preview()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int processResult = newCustomerAddMethod(new customer()
            {
                ıd = Guid.NewGuid(),
                name = txtNameForm2.Text,
                surname = txtSurnameForm2.Text,
                email = txtEmailForm2.Text,
                phoneNumber = txtPhoneForm2.Text
            });

            MessageBox.Show("Your customer addition process is successful.", "Add Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Form capturedFormObject = Application.OpenForms["Form1"]; form yakalama yöntemlerinden birisi

            foreach (Form item in Application.OpenForms)
            {
                if(item.Name == "Form1")
                {
                    foreach (Control Formİtem in item.Controls)
                    {
                        if(Formİtem is TextBox)
                        {
                            ((TextBox)Formİtem).Text = string.Empty;
                        }
                    }
                }
            }

            this.Close();
        }

        private int newCustomerAddMethod(customer data)
        {
            database.customers.Add(data);
            return 1;
        }
    }
}
