﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fontys.PTS2.Prototype.Classes;
using Fontys.PTS2.Prototype.Data;
using Fontys.PTS2.Prototype.View.Login;

namespace Fontys.PTS2.Prototype.View
{

    public partial class LoginPrototype : Form
    {
        public static int CurrentUserId { get; set; }
        
        private List<string> userNames;
        
        public LoginPrototype()
        {
            InitializeComponent();
        }

        private void LoginPrototype_Load(object sender, EventArgs e)
        {
            userNames = UserContextSQL.GetAllUsers();
            foreach (string FirstName in userNames)
            {
                //cboxUsers.Items.Add(FirstName);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedUser = tboxEmail.Text;
                string password = tbPassword.Text;
//                if (QueryUsers.CheckValidityUser(selectedUser, password))
//                {
//                    CurrentUserId = QueryUsers.GetUserId(selectedUser);
//                    ((MainForm)this.Parent.Parent).ReplaceForm(new FormQuestionOverviewCareRecipient());
//                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Er is geen gebruiker ingevoerd");
                return;
            }
        }

        private void linklblNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ((MainForm)this.Parent.Parent).ReplaceForm(new NewUser());
        }
    }
}
