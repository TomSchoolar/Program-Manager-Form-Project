namespace Program_Manager
{
    partial class Program_Manager_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Program_Manager_Form));
            this.Edit_Programs_Button = new System.Windows.Forms.Button();
            this.Edit_Services_Button = new System.Windows.Forms.Button();
            this.Program_List = new System.Windows.Forms.ListBox();
            this.Title = new System.Windows.Forms.Label();
            this.Add_Program_Button = new System.Windows.Forms.Button();
            this.Remove_Program_Button = new System.Windows.Forms.Button();
            this.Back_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Show_Name_Text_Box = new System.Windows.Forms.TextBox();
            this.Monday_RB = new System.Windows.Forms.RadioButton();
            this.Tuesday_RB = new System.Windows.Forms.RadioButton();
            this.Wednesday_RB = new System.Windows.Forms.RadioButton();
            this.Thursday_RB = new System.Windows.Forms.RadioButton();
            this.Friday_RB = new System.Windows.Forms.RadioButton();
            this.Saturday_RB = new System.Windows.Forms.RadioButton();
            this.Sunday_RB = new System.Windows.Forms.RadioButton();
            this.Hour_NUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Min_NUD = new System.Windows.Forms.NumericUpDown();
            this.Services_List_Box = new System.Windows.Forms.ListBox();
            this.Seen_Button = new System.Windows.Forms.Button();
            this.Service_Text_Box = new System.Windows.Forms.TextBox();
            this.Add_Service_Button = new System.Windows.Forms.Button();
            this.Remove_Service_Button = new System.Windows.Forms.Button();
            this.Info_on_Services = new System.Windows.Forms.TextBox();
            this.Everyday_RB = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Version_label = new System.Windows.Forms.Label();
            this.Help_Button = new System.Windows.Forms.Button();
            this.Help_Text_Box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Hour_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min_NUD)).BeginInit();
            this.SuspendLayout();
            // 
            // Edit_Programs_Button
            // 
            this.Edit_Programs_Button.Location = new System.Drawing.Point(16, 56);
            this.Edit_Programs_Button.Margin = new System.Windows.Forms.Padding(7);
            this.Edit_Programs_Button.Name = "Edit_Programs_Button";
            this.Edit_Programs_Button.Size = new System.Drawing.Size(235, 53);
            this.Edit_Programs_Button.TabIndex = 1;
            this.Edit_Programs_Button.Text = "Edit Programs";
            this.Edit_Programs_Button.UseVisualStyleBackColor = true;
            this.Edit_Programs_Button.Click += new System.EventHandler(this.Edit_Programs_Button_Click);
            // 
            // Edit_Services_Button
            // 
            this.Edit_Services_Button.Location = new System.Drawing.Point(280, 56);
            this.Edit_Services_Button.Margin = new System.Windows.Forms.Padding(7);
            this.Edit_Services_Button.Name = "Edit_Services_Button";
            this.Edit_Services_Button.Size = new System.Drawing.Size(235, 53);
            this.Edit_Services_Button.TabIndex = 2;
            this.Edit_Services_Button.Text = "Edit Services";
            this.Edit_Services_Button.UseVisualStyleBackColor = true;
            this.Edit_Services_Button.Click += new System.EventHandler(this.Edit_Services_Button_Click);
            // 
            // Program_List
            // 
            this.Program_List.FormattingEnabled = true;
            this.Program_List.ItemHeight = 29;
            this.Program_List.Location = new System.Drawing.Point(16, 158);
            this.Program_List.Name = "Program_List";
            this.Program_List.Size = new System.Drawing.Size(498, 381);
            this.Program_List.TabIndex = 3;
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(143, 16);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(249, 33);
            this.Title.TabIndex = 4;
            this.Title.Text = "Program Manager";
            // 
            // Add_Program_Button
            // 
            this.Add_Program_Button.Location = new System.Drawing.Point(16, 56);
            this.Add_Program_Button.Margin = new System.Windows.Forms.Padding(7);
            this.Add_Program_Button.Name = "Add_Program_Button";
            this.Add_Program_Button.Size = new System.Drawing.Size(235, 53);
            this.Add_Program_Button.TabIndex = 5;
            this.Add_Program_Button.Text = "Add Program";
            this.Add_Program_Button.UseVisualStyleBackColor = true;
            this.Add_Program_Button.Click += new System.EventHandler(this.Add_Program_Button_Click);
            // 
            // Remove_Program_Button
            // 
            this.Remove_Program_Button.Location = new System.Drawing.Point(280, 56);
            this.Remove_Program_Button.Margin = new System.Windows.Forms.Padding(7);
            this.Remove_Program_Button.Name = "Remove_Program_Button";
            this.Remove_Program_Button.Size = new System.Drawing.Size(235, 53);
            this.Remove_Program_Button.TabIndex = 6;
            this.Remove_Program_Button.Text = "Remove Program";
            this.Remove_Program_Button.UseVisualStyleBackColor = true;
            this.Remove_Program_Button.Click += new System.EventHandler(this.Remove_Program_Button_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(280, 549);
            this.Back_Button.Margin = new System.Windows.Forms.Padding(7);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(235, 53);
            this.Back_Button.TabIndex = 7;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "WatchList";
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(149, 56);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(235, 53);
            this.Add_Button.TabIndex = 9;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "TV SHOW NAME:";
            // 
            // Show_Name_Text_Box
            // 
            this.Show_Name_Text_Box.Location = new System.Drawing.Point(16, 158);
            this.Show_Name_Text_Box.Name = "Show_Name_Text_Box";
            this.Show_Name_Text_Box.Size = new System.Drawing.Size(497, 35);
            this.Show_Name_Text_Box.TabIndex = 11;
            // 
            // Monday_RB
            // 
            this.Monday_RB.AutoSize = true;
            this.Monday_RB.Location = new System.Drawing.Point(30, 199);
            this.Monday_RB.Name = "Monday_RB";
            this.Monday_RB.Size = new System.Drawing.Size(116, 33);
            this.Monday_RB.TabIndex = 12;
            this.Monday_RB.TabStop = true;
            this.Monday_RB.Text = "Monday";
            this.Monday_RB.UseVisualStyleBackColor = true;
            // 
            // Tuesday_RB
            // 
            this.Tuesday_RB.AutoSize = true;
            this.Tuesday_RB.Location = new System.Drawing.Point(149, 199);
            this.Tuesday_RB.Name = "Tuesday_RB";
            this.Tuesday_RB.Size = new System.Drawing.Size(124, 33);
            this.Tuesday_RB.TabIndex = 13;
            this.Tuesday_RB.TabStop = true;
            this.Tuesday_RB.Text = "Tuesday";
            this.Tuesday_RB.UseVisualStyleBackColor = true;
            // 
            // Wednesday_RB
            // 
            this.Wednesday_RB.AutoSize = true;
            this.Wednesday_RB.Location = new System.Drawing.Point(279, 199);
            this.Wednesday_RB.Name = "Wednesday_RB";
            this.Wednesday_RB.Size = new System.Drawing.Size(158, 33);
            this.Wednesday_RB.TabIndex = 14;
            this.Wednesday_RB.TabStop = true;
            this.Wednesday_RB.Text = "Wednesday";
            this.Wednesday_RB.UseVisualStyleBackColor = true;
            // 
            // Thursday_RB
            // 
            this.Thursday_RB.AutoSize = true;
            this.Thursday_RB.Location = new System.Drawing.Point(30, 238);
            this.Thursday_RB.Name = "Thursday_RB";
            this.Thursday_RB.Size = new System.Drawing.Size(131, 33);
            this.Thursday_RB.TabIndex = 15;
            this.Thursday_RB.TabStop = true;
            this.Thursday_RB.Text = "Thursday";
            this.Thursday_RB.UseVisualStyleBackColor = true;
            // 
            // Friday_RB
            // 
            this.Friday_RB.AutoSize = true;
            this.Friday_RB.Location = new System.Drawing.Point(167, 238);
            this.Friday_RB.Name = "Friday_RB";
            this.Friday_RB.Size = new System.Drawing.Size(98, 33);
            this.Friday_RB.TabIndex = 16;
            this.Friday_RB.TabStop = true;
            this.Friday_RB.Text = "Friday";
            this.Friday_RB.UseVisualStyleBackColor = true;
            // 
            // Saturday_RB
            // 
            this.Saturday_RB.AutoSize = true;
            this.Saturday_RB.Location = new System.Drawing.Point(271, 238);
            this.Saturday_RB.Name = "Saturday_RB";
            this.Saturday_RB.Size = new System.Drawing.Size(125, 33);
            this.Saturday_RB.TabIndex = 17;
            this.Saturday_RB.TabStop = true;
            this.Saturday_RB.Text = "Saturday";
            this.Saturday_RB.UseVisualStyleBackColor = true;
            // 
            // Sunday_RB
            // 
            this.Sunday_RB.AutoSize = true;
            this.Sunday_RB.Location = new System.Drawing.Point(402, 238);
            this.Sunday_RB.Name = "Sunday_RB";
            this.Sunday_RB.Size = new System.Drawing.Size(111, 33);
            this.Sunday_RB.TabIndex = 18;
            this.Sunday_RB.TabStop = true;
            this.Sunday_RB.Text = "Sunday";
            this.Sunday_RB.UseVisualStyleBackColor = true;
            // 
            // Hour_NUD
            // 
            this.Hour_NUD.BackColor = System.Drawing.Color.White;
            this.Hour_NUD.Location = new System.Drawing.Point(234, 279);
            this.Hour_NUD.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.Hour_NUD.Name = "Hour_NUD";
            this.Hour_NUD.ReadOnly = true;
            this.Hour_NUD.Size = new System.Drawing.Size(73, 35);
            this.Hour_NUD.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = ":               (24 hour)";
            // 
            // Min_NUD
            // 
            this.Min_NUD.BackColor = System.Drawing.Color.White;
            this.Min_NUD.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Min_NUD.Location = new System.Drawing.Point(332, 279);
            this.Min_NUD.Maximum = new decimal(new int[] {
            55,
            0,
            0,
            0});
            this.Min_NUD.Name = "Min_NUD";
            this.Min_NUD.ReadOnly = true;
            this.Min_NUD.Size = new System.Drawing.Size(73, 35);
            this.Min_NUD.TabIndex = 23;
            // 
            // Services_List_Box
            // 
            this.Services_List_Box.BackColor = System.Drawing.SystemColors.Window;
            this.Services_List_Box.FormattingEnabled = true;
            this.Services_List_Box.ItemHeight = 29;
            this.Services_List_Box.Location = new System.Drawing.Point(17, 332);
            this.Services_List_Box.Name = "Services_List_Box";
            this.Services_List_Box.Size = new System.Drawing.Size(497, 207);
            this.Services_List_Box.TabIndex = 24;
            // 
            // Seen_Button
            // 
            this.Seen_Button.Location = new System.Drawing.Point(18, 549);
            this.Seen_Button.Margin = new System.Windows.Forms.Padding(7);
            this.Seen_Button.Name = "Seen_Button";
            this.Seen_Button.Size = new System.Drawing.Size(235, 53);
            this.Seen_Button.TabIndex = 25;
            this.Seen_Button.Text = "Mark as Seen";
            this.Seen_Button.UseVisualStyleBackColor = true;
            this.Seen_Button.Click += new System.EventHandler(this.Seen_Button_Click);
            // 
            // Service_Text_Box
            // 
            this.Service_Text_Box.Location = new System.Drawing.Point(16, 255);
            this.Service_Text_Box.Name = "Service_Text_Box";
            this.Service_Text_Box.Size = new System.Drawing.Size(497, 35);
            this.Service_Text_Box.TabIndex = 26;
            // 
            // Add_Service_Button
            // 
            this.Add_Service_Button.Location = new System.Drawing.Point(16, 158);
            this.Add_Service_Button.Name = "Add_Service_Button";
            this.Add_Service_Button.Size = new System.Drawing.Size(235, 53);
            this.Add_Service_Button.TabIndex = 27;
            this.Add_Service_Button.Text = "Add Service";
            this.Add_Service_Button.UseVisualStyleBackColor = true;
            this.Add_Service_Button.Click += new System.EventHandler(this.Add_Service_Button_Click);
            // 
            // Remove_Service_Button
            // 
            this.Remove_Service_Button.Location = new System.Drawing.Point(280, 158);
            this.Remove_Service_Button.Name = "Remove_Service_Button";
            this.Remove_Service_Button.Size = new System.Drawing.Size(235, 53);
            this.Remove_Service_Button.TabIndex = 28;
            this.Remove_Service_Button.Text = "Remove Service";
            this.Remove_Service_Button.UseVisualStyleBackColor = true;
            this.Remove_Service_Button.Click += new System.EventHandler(this.Remove_Service_Button_Click);
            // 
            // Info_on_Services
            // 
            this.Info_on_Services.ForeColor = System.Drawing.Color.White;
            this.Info_on_Services.Location = new System.Drawing.Point(18, 56);
            this.Info_on_Services.Multiline = true;
            this.Info_on_Services.Name = "Info_on_Services";
            this.Info_on_Services.ReadOnly = true;
            this.Info_on_Services.Size = new System.Drawing.Size(498, 72);
            this.Info_on_Services.TabIndex = 29;
            this.Info_on_Services.Text = "A \"Service\" is a company that you pay to watch programs from for example Netflix " +
    "or Sky.";
            this.Info_on_Services.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Everyday_RB
            // 
            this.Everyday_RB.AutoSize = true;
            this.Everyday_RB.Location = new System.Drawing.Point(30, 277);
            this.Everyday_RB.Name = "Everyday_RB";
            this.Everyday_RB.Size = new System.Drawing.Size(129, 33);
            this.Everyday_RB.TabIndex = 30;
            this.Everyday_RB.TabStop = true;
            this.Everyday_RB.Text = "Everyday";
            this.Everyday_RB.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 29);
            this.label4.TabIndex = 31;
            this.label4.Text = "Service Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 29);
            this.label5.TabIndex = 32;
            this.label5.Text = "Services:";
            // 
            // Version_label
            // 
            this.Version_label.AutoSize = true;
            this.Version_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Version_label.Location = new System.Drawing.Point(482, 0);
            this.Version_label.Name = "Version_label";
            this.Version_label.Size = new System.Drawing.Size(50, 24);
            this.Version_label.TabIndex = 33;
            this.Version_label.Text = "1.2.2";
            // 
            // Help_Button
            // 
            this.Help_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help_Button.Location = new System.Drawing.Point(488, 22);
            this.Help_Button.Name = "Help_Button";
            this.Help_Button.Size = new System.Drawing.Size(39, 31);
            this.Help_Button.TabIndex = 34;
            this.Help_Button.Text = "i";
            this.Help_Button.UseVisualStyleBackColor = true;
            this.Help_Button.Click += new System.EventHandler(this.Help_Button_Click);
            // 
            // Help_Text_Box
            // 
            this.Help_Text_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help_Text_Box.ForeColor = System.Drawing.Color.White;
            this.Help_Text_Box.Location = new System.Drawing.Point(18, 73);
            this.Help_Text_Box.Multiline = true;
            this.Help_Text_Box.Name = "Help_Text_Box";
            this.Help_Text_Box.ReadOnly = true;
            this.Help_Text_Box.Size = new System.Drawing.Size(495, 466);
            this.Help_Text_Box.TabIndex = 35;
            this.Help_Text_Box.Text = resources.GetString("Help_Text_Box.Text");
            this.Help_Text_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Program_Manager_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 610);
            this.Controls.Add(this.Help_Text_Box);
            this.Controls.Add(this.Help_Button);
            this.Controls.Add(this.Version_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Everyday_RB);
            this.Controls.Add(this.Info_on_Services);
            this.Controls.Add(this.Remove_Service_Button);
            this.Controls.Add(this.Add_Service_Button);
            this.Controls.Add(this.Service_Text_Box);
            this.Controls.Add(this.Seen_Button);
            this.Controls.Add(this.Services_List_Box);
            this.Controls.Add(this.Min_NUD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Hour_NUD);
            this.Controls.Add(this.Sunday_RB);
            this.Controls.Add(this.Saturday_RB);
            this.Controls.Add(this.Friday_RB);
            this.Controls.Add(this.Thursday_RB);
            this.Controls.Add(this.Wednesday_RB);
            this.Controls.Add(this.Tuesday_RB);
            this.Controls.Add(this.Monday_RB);
            this.Controls.Add(this.Show_Name_Text_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back_Button);
            this.Controls.Add(this.Remove_Program_Button);
            this.Controls.Add(this.Add_Program_Button);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Program_List);
            this.Controls.Add(this.Edit_Services_Button);
            this.Controls.Add(this.Edit_Programs_Button);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "Program_Manager_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Program_Manager_Form_FormClosing);
            this.Load += new System.EventHandler(this.Program_Manager_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Hour_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Min_NUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Edit_Programs_Button;
        private System.Windows.Forms.Button Edit_Services_Button;
        private System.Windows.Forms.ListBox Program_List;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Add_Program_Button;
        private System.Windows.Forms.Button Remove_Program_Button;
        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Show_Name_Text_Box;
        private System.Windows.Forms.RadioButton Monday_RB;
        private System.Windows.Forms.RadioButton Tuesday_RB;
        private System.Windows.Forms.RadioButton Wednesday_RB;
        private System.Windows.Forms.RadioButton Thursday_RB;
        private System.Windows.Forms.RadioButton Friday_RB;
        private System.Windows.Forms.RadioButton Saturday_RB;
        private System.Windows.Forms.RadioButton Sunday_RB;
        private System.Windows.Forms.NumericUpDown Hour_NUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Min_NUD;
        private System.Windows.Forms.ListBox Services_List_Box;
        private System.Windows.Forms.Button Seen_Button;
        private System.Windows.Forms.TextBox Service_Text_Box;
        private System.Windows.Forms.Button Add_Service_Button;
        private System.Windows.Forms.Button Remove_Service_Button;
        private System.Windows.Forms.TextBox Info_on_Services;
        private System.Windows.Forms.RadioButton Everyday_RB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Version_label;
        private System.Windows.Forms.Button Help_Button;
        private System.Windows.Forms.TextBox Help_Text_Box;
    }
}

