namespace Minor_Project_MAS
{
    partial class Settings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.adddb = new System.Windows.Forms.Button();
            this.departments = new System.Windows.Forms.Button();
            this.tt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adddb
            // 
            this.adddb.BackColor = System.Drawing.Color.Transparent;
            this.adddb.BackgroundImage = global::Minor_Project_MAS.Properties.Resources.dbadd;
            this.adddb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adddb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adddb.FlatAppearance.BorderSize = 0;
            this.adddb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adddb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.adddb.ForeColor = System.Drawing.Color.Yellow;
            this.adddb.Location = new System.Drawing.Point(44, 166);
            this.adddb.Name = "adddb";
            this.adddb.Size = new System.Drawing.Size(139, 150);
            this.adddb.TabIndex = 0;
            this.adddb.Text = "ADD DATABASE";
            this.adddb.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.adddb.UseVisualStyleBackColor = false;
            this.adddb.Click += new System.EventHandler(this.adddb_Click);
            // 
            // departments
            // 
            this.departments.BackColor = System.Drawing.Color.Transparent;
            this.departments.BackgroundImage = global::Minor_Project_MAS.Properties.Resources.tableadd;
            this.departments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.departments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.departments.FlatAppearance.BorderSize = 0;
            this.departments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.departments.ForeColor = System.Drawing.Color.Yellow;
            this.departments.Location = new System.Drawing.Point(829, 166);
            this.departments.Name = "departments";
            this.departments.Size = new System.Drawing.Size(161, 149);
            this.departments.TabIndex = 4;
            this.departments.Text = "ADD TABLES names";
            this.departments.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.departments.UseVisualStyleBackColor = false;
            // 
            // tt
            // 
            this.tt.BackColor = System.Drawing.Color.Transparent;
            this.tt.BackgroundImage = global::Minor_Project_MAS.Properties.Resources.folder_4;
            this.tt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tt.FlatAppearance.BorderSize = 0;
            this.tt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt.ForeColor = System.Drawing.Color.Yellow;
            this.tt.Location = new System.Drawing.Point(432, 178);
            this.tt.Name = "tt";
            this.tt.Size = new System.Drawing.Size(138, 138);
            this.tt.TabIndex = 5;
            this.tt.Tag = "Citizen Record";
            this.tt.Text = "ADD NEW FILE";
            this.tt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tt.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(441, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "SETTINGS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Magenta;
            this.label4.Location = new System.Drawing.Point(25, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "SIGN OUT";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "Add Record";
            this.toolTip1.ToolTipTitle = "Add Citizen Record";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(25, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(461, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "<<Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 612);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tt);
            this.Controls.Add(this.departments);
            this.Controls.Add(this.adddb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1076, 645);
            this.Name = "Settings";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.adminPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adddb;
        private System.Windows.Forms.Button departments;
        private System.Windows.Forms.Button tt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}