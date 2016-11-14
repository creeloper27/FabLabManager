using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FabLabManager {
    public partial class Subscriber : Form {

        public int id_subscriber;

        public Subscriber(int id_subscriber_send) {
            id_subscriber = id_subscriber_send;
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e) {
            Close();
        }

        private void txtName_MouseHover(object sender, EventArgs e) {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(txtName, "Enter name.");
        }

        private void txtSurname_MouseHover(object sender, EventArgs e) {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(txtSurname, "Enter subname.");
        }

        private void txtDateOfBirth_MouseHover(object sender, EventArgs e) {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(txtDateOfBirth, "Enter date of birth.");
        }

        private void txtAddress_MouseHover(object sender, EventArgs e) {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(txtAddress, "Enter address.");
        }

        private void txtCity_MouseHover(object sender, EventArgs e) {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(txtCity, "Enter city.");
        }

        private void txtCountry_MouseHover(object sender, EventArgs e) {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(txtCountry, "Enter country.");
        }

        private void txtPostcode_MouseHover(object sender, EventArgs e) {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(txtPostcode, "Enter postcode.");
        }

        private void txtTelephone_MouseHover(object sender, EventArgs e) {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(txtTelephone, "Enter telephone number.");
        }

        private void txtEmail_MouseHover(object sender, EventArgs e) {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(txtEmail, "Enter email");
        }

        private void btnAddSubscribers_Click(object sender, EventArgs e) {
            FablabDB.addNewSubscriber(txtName.Text, 
                                      txtSurname.Text, 
                                      txtDateOfBirth.Text, 
                                      txtAddress.Text, 
                                      txtCity.Text,
                                      txtCountry.Text,
                                      txtPostcode.Text, 
                                      txtTelephone.Text, 
                                      txtEmail.Text);
            Close();
        }

        private void Subscriber_Load(object sender, EventArgs e) {
            if(id_subscriber != -1) 
                btnAddSubscribers.Text = "Edit";    
            
              
        }
    }
}
