using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace FabLabManager {
    public partial class MainWindow : Form {
        public MainWindow() {
            InitializeComponent();
        }



        private void MainWindow_Load(object sender, EventArgs e) {
            FablabDB.startController();
            FablabDB.showSubscriber();
            updateGridSubscribers();
        }

        private void button2_Click(object sender, EventArgs e) {
            FablabDB.deleteAllFile();
        }

        private void updateGridSubscribers() {

            dataGridViewSubscribers.Rows.Clear();
            dataGridViewSubscribers.ColumnCount = 9;
            dataGridViewSubscribers.Columns[0].Name = "Name";
            dataGridViewSubscribers.Columns[1].Name = "Surname";
            dataGridViewSubscribers.Columns[2].Name = "Date Of Birth";
            dataGridViewSubscribers.Columns[3].Name = "Address";
            dataGridViewSubscribers.Columns[4].Name = "City";
            dataGridViewSubscribers.Columns[5].Name = "Country";
            dataGridViewSubscribers.Columns[6].Name = "Postcode";
            dataGridViewSubscribers.Columns[7].Name = "Telephone";
            dataGridViewSubscribers.Columns[8].Name = "Email";

            using (StreamReader inputFile = File.OpenText(FablabDB.directoryData + "/" + FablabDB.fileSubscribers)) {
                string line = "";
                while ((line = inputFile.ReadLine()) != null) {
                    Console.WriteLine(line);
                    String[] substrings = line.Split(FablabDB.separator);
                    dataGridViewSubscribers.Rows.Add(substrings[0], 
                                                     substrings[1],
                                                     substrings[2],
                                                     substrings[3],
                                                     substrings[4],
                                                     substrings[5],
                                                     substrings[6],
                                                     substrings[7],
                                                     substrings[8]);
                }
            }
        }

        private void btnAddSubscriber_Click(object sender, EventArgs e) {
            Subscriber formSubscriber = new Subscriber(-1);
            formSubscriber.ShowDialog();
            updateGridSubscribers();
        }

        private void btnEditSubscriber_Click(object sender, EventArgs e) {         
            Subscriber formSubscriber = new Subscriber(dataGridViewSubscribers.CurrentRow.Index);
            formSubscriber.ShowDialog();
            updateGridSubscribers();
        }
    }
}
            

