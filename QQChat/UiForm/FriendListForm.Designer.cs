﻿namespace QQChat.UiForm
{
    partial class FriendListForm
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
            this.friendListBox = new Widget.ChatListBox();
            this.SuspendLayout();
            // 
            // friendListBox
            // 
            this.friendListBox.BackColor = System.Drawing.Color.White;
            this.friendListBox.ForeColor = System.Drawing.Color.DarkOrange;
            this.friendListBox.Location = new System.Drawing.Point(3, 3);
            this.friendListBox.Name = "friendListBox";
            this.friendListBox.Size = new System.Drawing.Size(235, 406);
            this.friendListBox.TabIndex = 0;
            this.friendListBox.Text = "friendListBox";
            this.friendListBox.DoubleClickSubItem += new Widget.ChatListBox.ChatListEventHandler(this.friendListBox_DoubleClickSubItem);
            this.friendListBox.MouseEnterHead += new Widget.ChatListBox.ChatListEventHandler(this.friendListBox_MouseEnterHead);
            // 
            // FriendListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 412);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Controls.Add(this.friendListBox);
            this.Name = "FriendListForm";
            this.Text = "FriendListForm";
            this.Load += new System.EventHandler(this.FriendListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Widget.ChatListBox friendListBox;
    }
}