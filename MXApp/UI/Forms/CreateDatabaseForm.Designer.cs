namespace UI.Forms
{
    partial class CreateDatabaseForm
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
            this.btnBrowseLog = new System.Windows.Forms.Button();
            this.btnBrowseData = new System.Windows.Forms.Button();
            this.btnCreateDatabase = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRecoveryModel = new System.Windows.Forms.ComboBox();
            this.txtLogPath = new System.Windows.Forms.TextBox();
            this.txtDataPath = new System.Windows.Forms.TextBox();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBrowseLog
            // 
            this.btnBrowseLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseLog.Location = new System.Drawing.Point(622, 298);
            this.btnBrowseLog.Name = "btnBrowseLog";
            this.btnBrowseLog.Size = new System.Drawing.Size(31, 26);
            this.btnBrowseLog.TabIndex = 24;
            this.btnBrowseLog.Text = "...";
            this.btnBrowseLog.UseVisualStyleBackColor = true;
            // 
            // btnBrowseData
            // 
            this.btnBrowseData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseData.Location = new System.Drawing.Point(622, 245);
            this.btnBrowseData.Name = "btnBrowseData";
            this.btnBrowseData.Size = new System.Drawing.Size(31, 24);
            this.btnBrowseData.TabIndex = 23;
            this.btnBrowseData.Text = "...";
            this.btnBrowseData.UseVisualStyleBackColor = true;
            // 
            // btnCreateDatabase
            // 
            this.btnCreateDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateDatabase.Location = new System.Drawing.Point(309, 358);
            this.btnCreateDatabase.Name = "btnCreateDatabase";
            this.btnCreateDatabase.Size = new System.Drawing.Size(142, 33);
            this.btnCreateDatabase.TabIndex = 22;
            this.btnCreateDatabase.Text = "Create";
            this.btnCreateDatabase.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(162, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Recovery Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(148, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Log File Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "Data File Path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Database Name";
            // 
            // comboBoxRecoveryModel
            // 
            this.comboBoxRecoveryModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRecoveryModel.FormattingEnabled = true;
            this.comboBoxRecoveryModel.Items.AddRange(new object[] {
            "FULL",
            "SIMPLE"});
            this.comboBoxRecoveryModel.Location = new System.Drawing.Point(151, 184);
            this.comboBoxRecoveryModel.Name = "comboBoxRecoveryModel";
            this.comboBoxRecoveryModel.Size = new System.Drawing.Size(140, 26);
            this.comboBoxRecoveryModel.TabIndex = 17;
            // 
            // txtLogPath
            // 
            this.txtLogPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogPath.Location = new System.Drawing.Point(151, 298);
            this.txtLogPath.Name = "txtLogPath";
            this.txtLogPath.Size = new System.Drawing.Size(472, 24);
            this.txtLogPath.TabIndex = 16;
            // 
            // txtDataPath
            // 
            this.txtDataPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataPath.Location = new System.Drawing.Point(151, 245);
            this.txtDataPath.Name = "txtDataPath";
            this.txtDataPath.Size = new System.Drawing.Size(472, 24);
            this.txtDataPath.TabIndex = 15;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabaseName.Location = new System.Drawing.Point(151, 79);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(472, 24);
            this.txtDatabaseName.TabIndex = 14;
            // 
            // CreateDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBrowseLog);
            this.Controls.Add(this.btnBrowseData);
            this.Controls.Add(this.btnCreateDatabase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxRecoveryModel);
            this.Controls.Add(this.txtLogPath);
            this.Controls.Add(this.txtDataPath);
            this.Controls.Add(this.txtDatabaseName);
            this.Name = "CreateDatabaseForm";
            this.Text = "CreateDatabaseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseLog;
        private System.Windows.Forms.Button btnBrowseData;
        private System.Windows.Forms.Button btnCreateDatabase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRecoveryModel;
        private System.Windows.Forms.TextBox txtLogPath;
        private System.Windows.Forms.TextBox txtDataPath;
        private System.Windows.Forms.TextBox txtDatabaseName;
    }
}