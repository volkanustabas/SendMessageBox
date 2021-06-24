
namespace SendMessageBox
{
    partial class FrmMain
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
            this.tb_computerName = new System.Windows.Forms.TextBox();
            this.lbl_computerName = new System.Windows.Forms.Label();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.lbl_message = new System.Windows.Forms.Label();
            this.rtb_message = new System.Windows.Forms.RichTextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_computerName
            // 
            this.tb_computerName.Location = new System.Drawing.Point(15, 35);
            this.tb_computerName.Name = "tb_computerName";
            this.tb_computerName.Size = new System.Drawing.Size(162, 20);
            this.tb_computerName.TabIndex = 0;
            // 
            // lbl_computerName
            // 
            this.lbl_computerName.AutoSize = true;
            this.lbl_computerName.Location = new System.Drawing.Point(15, 15);
            this.lbl_computerName.Name = "lbl_computerName";
            this.lbl_computerName.Size = new System.Drawing.Size(83, 13);
            this.lbl_computerName.TabIndex = 1;
            this.lbl_computerName.Text = "Computer Name";
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Location = new System.Drawing.Point(15, 75);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(55, 13);
            this.lbl_userName.TabIndex = 3;
            this.lbl_userName.Text = "Username";
            // 
            // tb_userName
            // 
            this.tb_userName.Location = new System.Drawing.Point(15, 95);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(162, 20);
            this.tb_userName.TabIndex = 2;
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(180, 15);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(50, 13);
            this.lbl_message.TabIndex = 5;
            this.lbl_message.Text = "Message";
            // 
            // rtb_message
            // 
            this.rtb_message.Location = new System.Drawing.Point(183, 35);
            this.rtb_message.Name = "rtb_message";
            this.rtb_message.Size = new System.Drawing.Size(177, 80);
            this.rtb_message.TabIndex = 6;
            this.rtb_message.Text = "";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(183, 130);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(177, 37);
            this.btn_send.TabIndex = 7;
            this.btn_send.Text = "Send Message";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 179);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.rtb_message);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.lbl_userName);
            this.Controls.Add(this.tb_userName);
            this.Controls.Add(this.lbl_computerName);
            this.Controls.Add(this.tb_computerName);
            this.Name = "FrmMain";
            this.Text = "SendMessageBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_computerName;
        private System.Windows.Forms.Label lbl_computerName;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.TextBox tb_userName;
        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.RichTextBox rtb_message;
        private System.Windows.Forms.Button btn_send;
    }
}

