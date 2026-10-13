using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class Form1 : Form
    {
        ContactS contacts;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contacts = new ContactS();

            try
            {
                contacts.ReadContacts();
                for (int index = 0; index < ContactS.NO_OF_CONTACTS; index++)
                {
                    cmbBxNames.Items.Add(contacts.GetLastName(index));
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbBxNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool foundIt = false;
            string name = cmbBxNames.Text;

            for (int index = 0; !foundIt && index < ContactS.NO_OF_CONTACTS; index++)
            {
                if (contacts.GetLastName(index) == name)
                {
                    foundIt = true;

                    Visibility(true);
                    txtBxName.Text = contacts.GetFirstName(index) + " " + contacts.GetLastName(index);
                    txtBxAddress.Text = contacts.GetAddress(index);
                    txtBxCity.Text = contacts.GetCity(index);
                    txtBxState.Text = contacts.GetState(index);
                    txtBxZip.Text = contacts.GetZip(index);
                    txtBxPhone.Text = contacts.GetPhone(index);
                    txtBxEmail.Text = contacts.GetEmail(index);
                }
            }
        }

        public void Visibility(bool visible)
        {
            pctrBxPhone.Visible = !visible;

            lblContactName.Visible = visible;
            lblAddress.Visible = visible;
            lblCity.Visible = visible;
            lblState.Visible = visible;
            lblZip.Visible = visible;
            lblPhone.Visible = visible;
            lblEmail.Visible = visible;

            txtBxName.Visible = visible;
            txtBxAddress.Visible = visible;
            txtBxCity.Visible = visible;
            txtBxState.Visible = visible;
            txtBxZip.Visible = visible;
            txtBxPhone.Visible = visible;
            txtBxEmail.Visible = visible;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmbBxNames.SelectedItem = null;
            Visibility(false);
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string info = "Name:\t\tAisha Kabir" +
                        "\nCourse:\t\tITDEV-115-200" +
                        "\nInstructor:\tJanese Christie" +
                        "\nAssignment:\tAddress Book App" +
                        "\nDate:\t\t5/02/2022";
            MessageBox.Show(info, "Address Book App Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
