﻿namespace Fontys.PTS2.Prototype.View.Volunteer
{
    partial class FormVolunteerChat
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
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.lbChat = new System.Windows.Forms.ListBox();
            this.lbChatReceiver = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(282, 246);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(29, 28);
            this.btnSendMessage.TabIndex = 1;
            this.btnSendMessage.Text = ">";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(12, 251);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(264, 20);
            this.tbMessage.TabIndex = 2;
            // 
            // lbChat
            // 
            this.lbChat.FormattingEnabled = true;
            this.lbChat.Location = new System.Drawing.Point(12, 33);
            this.lbChat.Name = "lbChat";
            this.lbChat.Size = new System.Drawing.Size(264, 212);
            this.lbChat.TabIndex = 3;
            // 
            // lbChatReceiver
            // 
            this.lbChatReceiver.AutoSize = true;
            this.lbChatReceiver.Location = new System.Drawing.Point(12, 13);
            this.lbChatReceiver.Name = "lbChatReceiver";
            this.lbChatReceiver.Size = new System.Drawing.Size(35, 13);
            this.lbChatReceiver.TabIndex = 4;
            this.lbChatReceiver.Text = "label1";
            // 
            // FormVolunteerChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbChatReceiver);
            this.Controls.Add(this.lbChat);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.btnSendMessage);
            this.Name = "FormVolunteerChat";
            this.Text = "FormVolunteerChat";
            this.Load += new System.EventHandler(this.FormVolunteerChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.ListBox lbChat;
        private System.Windows.Forms.Label lbChatReceiver;
    }
}