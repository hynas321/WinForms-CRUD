
namespace CRUDXmlFile
{
    partial class Form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Governor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinimumWage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeZone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GovernorTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AreaTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MinimumWageTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.group_info = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TimeZoneTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ChooseXMLButton = new System.Windows.Forms.Button();
            this.FileTextBox = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.group_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name,
            this.Governor,
            this.Area,
            this.MinimumWage,
            this.TimeZone});
            this.dataGridView1.Location = new System.Drawing.Point(12, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(640, 384);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.MaxInputLength = 2;
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 40;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "name";
            this.Name.HeaderText = "Name";
            this.Name.MaxInputLength = 25;
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 140;
            // 
            // Governor
            // 
            this.Governor.DataPropertyName = "governor";
            this.Governor.HeaderText = "Governor";
            this.Governor.MaxInputLength = 30;
            this.Governor.MinimumWidth = 6;
            this.Governor.Name = "Governor";
            this.Governor.Width = 140;
            // 
            // Area
            // 
            this.Area.DataPropertyName = "area";
            this.Area.HeaderText = "Area";
            this.Area.MaxInputLength = 10;
            this.Area.MinimumWidth = 6;
            this.Area.Name = "Area";
            // 
            // MinimumWage
            // 
            this.MinimumWage.DataPropertyName = "minimumwage";
            this.MinimumWage.HeaderText = "MinimumWage";
            this.MinimumWage.MaxInputLength = 6;
            this.MinimumWage.MinimumWidth = 6;
            this.MinimumWage.Name = "MinimumWage";
            this.MinimumWage.Width = 90;
            // 
            // TimeZone
            // 
            this.TimeZone.DataPropertyName = "timezone";
            this.TimeZone.HeaderText = "TimeZone";
            this.TimeZone.MaxInputLength = 2;
            this.TimeZone.MinimumWidth = 6;
            this.TimeZone.Name = "TimeZone";
            this.TimeZone.Width = 90;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.IdTextBox.Location = new System.Drawing.Point(114, 41);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(44, 22);
            this.IdTextBox.TabIndex = 3;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.NameTextBox.Location = new System.Drawing.Point(115, 68);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(212, 22);
            this.NameTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // GovernorTextBox
            // 
            this.GovernorTextBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.GovernorTextBox.Location = new System.Drawing.Point(114, 95);
            this.GovernorTextBox.Name = "GovernorTextBox";
            this.GovernorTextBox.Size = new System.Drawing.Size(212, 22);
            this.GovernorTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Governor";
            // 
            // AreaTextBox
            // 
            this.AreaTextBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.AreaTextBox.Location = new System.Drawing.Point(114, 122);
            this.AreaTextBox.Name = "AreaTextBox";
            this.AreaTextBox.Size = new System.Drawing.Size(124, 22);
            this.AreaTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(6, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Area";
            // 
            // MinimumWageTextBox
            // 
            this.MinimumWageTextBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.MinimumWageTextBox.Location = new System.Drawing.Point(114, 150);
            this.MinimumWageTextBox.Name = "MinimumWageTextBox";
            this.MinimumWageTextBox.Size = new System.Drawing.Size(124, 22);
            this.MinimumWageTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(6, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "MinimumWage";
            // 
            // btn_add
            // 
            this.AddButton.BackColor = System.Drawing.Color.SkyBlue;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.AddButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddButton.Location = new System.Drawing.Point(119, 245);
            this.AddButton.Name = "btn_add";
            this.AddButton.Size = new System.Drawing.Size(91, 47);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Clear GroupBox";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.ClickAddButton);
            // 
            // btn_save
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.SaveButton.Location = new System.Drawing.Point(14, 245);
            this.SaveButton.Name = "btn_save";
            this.SaveButton.Size = new System.Drawing.Size(99, 47);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Add set from GroupBox";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.ClickSaveButton);
            // 
            // btn_delete
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.DeleteButton.Location = new System.Drawing.Point(313, 245);
            this.DeleteButton.Name = "btn_delete";
            this.DeleteButton.Size = new System.Drawing.Size(91, 47);
            this.DeleteButton.TabIndex = 15;
            this.DeleteButton.Text = "Delete Data Set";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.ClickDeleteButton);
            // 
            // group_info
            // 
            this.group_info.Controls.Add(this.label1);
            this.group_info.Controls.Add(this.TimeZoneTextBox);
            this.group_info.Controls.Add(this.MinimumWageTextBox);
            this.group_info.Controls.Add(this.label6);
            this.group_info.Controls.Add(this.AreaTextBox);
            this.group_info.Controls.Add(this.label5);
            this.group_info.Controls.Add(this.GovernorTextBox);
            this.group_info.Controls.Add(this.label4);
            this.group_info.Controls.Add(this.NameTextBox);
            this.group_info.Controls.Add(this.label3);
            this.group_info.Controls.Add(this.IdTextBox);
            this.group_info.Controls.Add(this.label2);
            this.group_info.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.group_info.Location = new System.Drawing.Point(12, 22);
            this.group_info.Name = "group_info";
            this.group_info.Size = new System.Drawing.Size(353, 204);
            this.group_info.TabIndex = 16;
            this.group_info.TabStop = false;
            this.group_info.Text = "State\'s subelements (GroupBox)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(6, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "TimeZone";
            // 
            // TimeZoneTextBox
            // 
            this.TimeZoneTextBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.TimeZoneTextBox.Location = new System.Drawing.Point(114, 177);
            this.TimeZoneTextBox.Name = "TimeZoneTextBox";
            this.TimeZoneTextBox.Size = new System.Drawing.Size(44, 22);
            this.TimeZoneTextBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(388, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(266, 46);
            this.label7.TabIndex = 17;
            this.label7.Text = "XML Application";
            // 
            // ChooseXMLButton
            // 
            this.ChooseXMLButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ChooseXMLButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseXMLButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ChooseXMLButton.Location = new System.Drawing.Point(370, 80);
            this.ChooseXMLButton.Margin = new System.Windows.Forms.Padding(2);
            this.ChooseXMLButton.Name = "ChooseXMLButton";
            this.ChooseXMLButton.Size = new System.Drawing.Size(74, 41);
            this.ChooseXMLButton.TabIndex = 18;
            this.ChooseXMLButton.Text = "Choose XML";
            this.ChooseXMLButton.UseVisualStyleBackColor = false;
            this.ChooseXMLButton.Click += new System.EventHandler(this.ChooseXMLButton_Click);
            // 
            // FileTextBox
            // 
            this.FileTextBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.FileTextBox.Location = new System.Drawing.Point(450, 90);
            this.FileTextBox.Name = "FileTextBox";
            this.FileTextBox.Size = new System.Drawing.Size(203, 22);
            this.FileTextBox.TabIndex = 19;
            // 
            // btn_update
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.UpdateButton.Location = new System.Drawing.Point(216, 245);
            this.UpdateButton.Name = "btn_update";
            this.UpdateButton.Size = new System.Drawing.Size(91, 47);
            this.UpdateButton.TabIndex = 20;
            this.UpdateButton.Text = "Saves Changes";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.ClickUpdateButton);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 700);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.FileTextBox);
            this.Controls.Add(this.ChooseXMLButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.group_info);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(679, 739);
            this.MinimumSize = new System.Drawing.Size(679, 739);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XML Application";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.group_info.ResumeLayout(false);
            this.group_info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GovernorTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AreaTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MinimumWageTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.GroupBox group_info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TimeZoneTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ChooseXMLButton;
        private System.Windows.Forms.TextBox FileTextBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Governor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Area;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinimumWage;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeZone;
    }
}

