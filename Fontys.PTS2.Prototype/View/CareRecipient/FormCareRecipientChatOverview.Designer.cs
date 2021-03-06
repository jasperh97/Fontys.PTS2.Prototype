﻿namespace Fontys.PTS2.Prototype.View.CareRecipient
{
    partial class FormCareRecipientChatOverview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvChats = new System.Windows.Forms.ListView();
            this.nameVolunteer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Subject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChatID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReceiverID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuestionID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnOpenChat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvChats
            // 
            this.lvChats.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameVolunteer,
            this.Subject,
            this.Time,
            this.ChatID,
            this.ReceiverID,
            this.QuestionID});
            this.lvChats.Location = new System.Drawing.Point(81, 66);
            this.lvChats.Margin = new System.Windows.Forms.Padding(2);
            this.lvChats.Name = "lvChats";
            this.lvChats.Size = new System.Drawing.Size(646, 243);
            this.lvChats.TabIndex = 6;
            this.lvChats.UseCompatibleStateImageBehavior = false;
            this.lvChats.View = System.Windows.Forms.View.Details;
            // 
            // nameVolunteer
            // 
            this.nameVolunteer.Text = "Naam vrijwilliger";
            this.nameVolunteer.Width = 134;
            // 
            // Subject
            // 
            this.Subject.Text = "Onderwerp";
            this.Subject.Width = 284;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 133;
            // 
            // ChatID
            // 
            this.ChatID.Width = 0;
            // 
            // ReceiverID
            // 
            this.ReceiverID.Text = "Receiver ID";
            this.ReceiverID.Width = 0;
            // 
            // QuestionID
            // 
            this.QuestionID.Text = "Question ID";
            this.QuestionID.Width = 91;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Uw chats";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(81, 375);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 58);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Ga terug";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // btnOpenChat
            // 
            this.btnOpenChat.Location = new System.Drawing.Point(81, 313);
            this.btnOpenChat.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenChat.Name = "btnOpenChat";
            this.btnOpenChat.Size = new System.Drawing.Size(118, 58);
            this.btnOpenChat.TabIndex = 7;
            this.btnOpenChat.Text = "Open chat";
            this.btnOpenChat.UseVisualStyleBackColor = true;
            this.btnOpenChat.Click += new System.EventHandler(this.btnOpenChat_Click_1);
            // 
            // FormCareRecipientChatOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvChats);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOpenChat);
            this.Name = "FormCareRecipientChatOverview";
            this.Text = "FormCareRecipientChatOverview";
            this.Load += new System.EventHandler(this.FormCareRecipientChatOverview_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvChats;
        private System.Windows.Forms.ColumnHeader nameVolunteer;
        private System.Windows.Forms.ColumnHeader Subject;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader ChatID;
        private System.Windows.Forms.ColumnHeader ReceiverID;
        private System.Windows.Forms.ColumnHeader QuestionID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnOpenChat;
    }
}