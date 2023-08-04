﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SoftwareMajorProject
{
    public partial class diaryViewerPage : Form
    {
        string userNameLoggedIn;
        string selectedDiaryEntry;
        public diaryViewerPage(string userName)
        {
            userNameLoggedIn = userName;
            InitializeComponent();
        }

        private void diaryViewerPage_Load(object sender, EventArgs e)
        {

            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = softwareMajorProjectDatabase.db";

            string cmd = "SELECT * FROM 'NoterSettings'";
            SQLiteDataAdapter settingsDataAdapter = new SQLiteDataAdapter(cmd, sqlConnection);

            var dataGridViewSettings = new DataTable();

            sqlConnection.Open();
            settingsDataAdapter.Fill(dataGridViewSettings);
            sqlConnection.Close();



            foreach (DataRow row in dataGridViewSettings.Rows)
            {
                if (row[0].ToString() == userNameLoggedIn)
                {
                    //Back colour
                    BackColor = Color.FromName(row[1].ToString());

                    //Front colour
                    picBackPlate.BackColor = Color.FromName(row[2].ToString());
                    lblEntryTitle.BackColor = Color.FromName(row[2].ToString());
                    lblEntryContents.BackColor = Color.FromName(row[2].ToString());
                    lblEntryDate.BackColor = Color.FromName(row[2].ToString());
                    DgvDiaryViewer.BackgroundColor = Color.FromName(row[2].ToString());
                    DgvDiaryViewer.CellBorderStyle = DataGridViewCellBorderStyle.Single;


                    //Font type
                    var fontConverter = new FontConverter();
                    DgvDiaryViewer.Font = fontConverter.ConvertFromString(row[3].ToString()) as Font;
                    lblEntryTitle.Font = new Font(fontConverter.ConvertFromString(row[3].ToString()) as Font, FontStyle.Underline);
                    TxtEntryTitle.Font = fontConverter.ConvertFromString(row[3].ToString()) as Font;
                    lblEntryContents.Font = new Font(fontConverter.ConvertFromString(row[3].ToString()) as Font, FontStyle.Underline);
                    TxtEntryContents.Font = fontConverter.ConvertFromString(row[3].ToString()) as Font;
                    lblEntryDate.Font = new Font(fontConverter.ConvertFromString(row[3].ToString()) as Font, FontStyle.Underline);
                    txtEntryDate.Font = fontConverter.ConvertFromString(row[3].ToString()) as Font;
                    btnHome.Font = fontConverter.ConvertFromString(row[3].ToString()) as Font;
                }
            }




            string fillDataGridViewCommand = "SELECT * FROM '" + userNameLoggedIn + "_Diary'";
            SQLiteDataAdapter sqlAdapter = new SQLiteDataAdapter(fillDataGridViewCommand, sqlConnection);

            DataTable diaryDataTable = new DataTable();

            sqlConnection.Open();
            sqlAdapter.Fill(diaryDataTable);
            sqlConnection.Close();
            
            DgvDiaryViewer.DataSource = diaryDataTable;

            DgvDiaryViewer.Columns[0].Width = 100;
            DgvDiaryViewer.Columns[1].Width = 250;
            DgvDiaryViewer.Columns[2].Width = 160;






        }

        private void DgvDiaryViewer_SelectionChanged(object sender, EventArgs e)
        {
            SQLiteConnection sqlConnection = new SQLiteConnection();
            sqlConnection.ConnectionString = "DataSource = softwareMajorProjectDatabase.db";




            if (DgvDiaryViewer.SelectedRows.Count > 0)
            {
                selectedDiaryEntry = DgvDiaryViewer.SelectedRows[0].Cells[1].Value.ToString();


                string fillDataGridViewCommand = "SELECT * FROM '" + userNameLoggedIn + "_Diary' WHERE title='" + selectedDiaryEntry + "'";
                SQLiteDataAdapter sqlAdapter = new SQLiteDataAdapter(fillDataGridViewCommand, sqlConnection);

                DataTable diaryDataTable = new DataTable();

                sqlConnection.Open();
                sqlAdapter.Fill(diaryDataTable);


                TxtEntryTitle.Text = diaryDataTable.Rows[0]["title"].ToString();
                TxtEntryContents.Text = diaryDataTable.Rows[0]["contents"].ToString();
                txtEntryDate.Text = diaryDataTable.Rows[0]["date"].ToString();

                sqlConnection.Close();
            }


        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage HomePage = new HomePage(userNameLoggedIn);
            this.Hide();
            HomePage.Show();
        }
    }
}