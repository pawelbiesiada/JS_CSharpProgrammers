namespace WinFormsSample
{
    partial class FrmUserDetails
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
            this.clbCourses = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUserIdLabel = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbAddress1 = new System.Windows.Forms.TextBox();
            this.txbAddress2 = new System.Windows.Forms.TextBox();
            this.txbCity = new System.Windows.Forms.TextBox();
            this.txbState = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clbCourses
            // 
            this.clbCourses.FormattingEnabled = true;
            this.clbCourses.Location = new System.Drawing.Point(6, 19);
            this.clbCourses.Name = "clbCourses";
            this.clbCourses.Size = new System.Drawing.Size(132, 169);
            this.clbCourses.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clbCourses);
            this.groupBox1.Location = new System.Drawing.Point(216, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 202);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Courses";
            // 
            // lblUserIdLabel
            // 
            this.lblUserIdLabel.AutoSize = true;
            this.lblUserIdLabel.Location = new System.Drawing.Point(12, 9);
            this.lblUserIdLabel.Name = "lblUserIdLabel";
            this.lblUserIdLabel.Size = new System.Drawing.Size(38, 13);
            this.lblUserIdLabel.TabIndex = 2;
            this.lblUserIdLabel.Text = "UserId";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.ForeColor = System.Drawing.Color.Red;
            this.lblUserId.Location = new System.Drawing.Point(56, 9);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(16, 17);
            this.lblUserId.TabIndex = 3;
            this.lblUserId.Text = "ID";
            this.lblUserId.UseCompatibleTextRendering = true;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(15, 42);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(51, 13);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "Address1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Address2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "State";
            // 
            // txbAddress1
            // 
            this.txbAddress1.Location = new System.Drawing.Point(72, 39);
            this.txbAddress1.Name = "txbAddress1";
            this.txbAddress1.Size = new System.Drawing.Size(100, 20);
            this.txbAddress1.TabIndex = 8;
            // 
            // txbAddress2
            // 
            this.txbAddress2.Location = new System.Drawing.Point(72, 68);
            this.txbAddress2.Name = "txbAddress2";
            this.txbAddress2.Size = new System.Drawing.Size(100, 20);
            this.txbAddress2.TabIndex = 9;
            // 
            // txbCity
            // 
            this.txbCity.Location = new System.Drawing.Point(72, 99);
            this.txbCity.Name = "txbCity";
            this.txbCity.Size = new System.Drawing.Size(100, 20);
            this.txbCity.TabIndex = 10;
            // 
            // txbState
            // 
            this.txbState.Location = new System.Drawing.Point(72, 126);
            this.txbState.Name = "txbState";
            this.txbState.Size = new System.Drawing.Size(100, 20);
            this.txbState.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(18, 181);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(99, 181);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 226);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbState);
            this.Controls.Add(this.txbCity);
            this.Controls.Add(this.txbAddress2);
            this.Controls.Add(this.txbAddress1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.lblUserIdLabel);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmUserDetails";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmUserDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbCourses;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUserIdLabel;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbAddress1;
        private System.Windows.Forms.TextBox txbAddress2;
        private System.Windows.Forms.TextBox txbCity;
        private System.Windows.Forms.TextBox txbState;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}