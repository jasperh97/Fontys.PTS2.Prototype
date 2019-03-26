﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fontys.PTS2.Prototype.Data;

namespace Fontys.PTS2.Prototype.View
{
    public partial class FormQuestionOverviewCareRecipient : Form
    {
        public FormQuestionOverviewCareRecipient()
        {
            InitializeComponent();
            LoadQuestionsToList();
        }

        public void LoadQuestionsToList()
        {
            Database db = new Database();
            DataTable dt = new DataTable();

            dt = db.GetAllOpenQuestions();

            //Adding each row into listview with foreach + for loop
            foreach (DataRow row in dt.Rows)
            {
                //Standard adding item, only add the primary key as main item
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    //each item that follow the primary key will be added as sub item
                    item.SubItems.Add(row[i].ToString());
                }
                lvOpenQuestions.Items.Add(item);
            }
        }

        private void btnEditQuestion_Click(object sender, EventArgs e)
        {
            if (lvOpenQuestions.SelectedItems.Count == 1)
            {
                int selectedRow = lvOpenQuestions.SelectedItems[0].Index;
                int selectedId = Convert.ToInt32(lvOpenQuestions.Items[selectedRow].SubItems[5].Text);
                ((MainForm)this.Parent.Parent).ReplaceForm(new EditQuestion(selectedId));
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnAskQuestion_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).ReplaceForm(new Form1());

        }

        private void btnLogOff_Click(object sender, EventArgs e)
        {
            ((MainForm)this.Parent.Parent).ReplaceForm(new LoginPrototype());
        }
    }
}