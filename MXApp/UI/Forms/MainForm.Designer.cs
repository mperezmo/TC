namespace UI.Forms
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExistingInstances = new System.Windows.Forms.Button();
            this.dataGridViewDatabases = new System.Windows.Forms.DataGridView();
            this.btnViewInstances = new System.Windows.Forms.Button();
            this.btnAddInstance = new System.Windows.Forms.Button();
            this.btnLoadDatabases = new System.Windows.Forms.Button();
            this.txtInstance = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatabases)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExistingInstances
            // 
            this.btnExistingInstances.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExistingInstances.Location = new System.Drawing.Point(307, 365);
            this.btnExistingInstances.Name = "btnExistingInstances";
            this.btnExistingInstances.Size = new System.Drawing.Size(170, 30);
            this.btnExistingInstances.TabIndex = 23;
            this.btnExistingInstances.Text = "View Instances";
            this.btnExistingInstances.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDatabases
            // 
            this.dataGridViewDatabases.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewDatabases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatabases.Location = new System.Drawing.Point(72, 120);
            this.dataGridViewDatabases.Name = "dataGridViewDatabases";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDatabases.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDatabases.RowHeadersWidth = 51;
            this.dataGridViewDatabases.RowTemplate.Height = 24;
            this.dataGridViewDatabases.Size = new System.Drawing.Size(641, 221);
            this.dataGridViewDatabases.TabIndex = 18;
            // 
            // btnViewInstances
            // 
            this.btnViewInstances.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewInstances.Location = new System.Drawing.Point(555, 365);
            this.btnViewInstances.Name = "btnViewInstances";
            this.btnViewInstances.Size = new System.Drawing.Size(158, 30);
            this.btnViewInstances.TabIndex = 22;
            this.btnViewInstances.Text = "More Information";
            this.btnViewInstances.UseVisualStyleBackColor = true;
            // 
            // btnAddInstance
            // 
            this.btnAddInstance.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInstance.Location = new System.Drawing.Point(72, 365);
            this.btnAddInstance.Name = "btnAddInstance";
            this.btnAddInstance.Size = new System.Drawing.Size(120, 30);
            this.btnAddInstance.TabIndex = 21;
            this.btnAddInstance.Text = "Add";
            this.btnAddInstance.UseVisualStyleBackColor = true;
            // 
            // btnLoadDatabases
            // 
            this.btnLoadDatabases.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadDatabases.Location = new System.Drawing.Point(585, 56);
            this.btnLoadDatabases.Name = "btnLoadDatabases";
            this.btnLoadDatabases.Size = new System.Drawing.Size(144, 30);
            this.btnLoadDatabases.TabIndex = 20;
            this.btnLoadDatabases.Text = "Test Connection";
            this.btnLoadDatabases.UseVisualStyleBackColor = true;
            this.btnLoadDatabases.Click += new System.EventHandler(this.btnLoadDatabases_Click);
            // 
            // txtInstance
            // 
            this.txtInstance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInstance.BackColor = System.Drawing.Color.Gainsboro;
            this.txtInstance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInstance.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstance.Location = new System.Drawing.Point(181, 56);
            this.txtInstance.Name = "txtInstance";
            this.txtInstance.Size = new System.Drawing.Size(347, 27);
            this.txtInstance.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExistingInstances);
            this.Controls.Add(this.dataGridViewDatabases);
            this.Controls.Add(this.btnViewInstances);
            this.Controls.Add(this.btnAddInstance);
            this.Controls.Add(this.btnLoadDatabases);
            this.Controls.Add(this.txtInstance);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatabases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExistingInstances;
        private System.Windows.Forms.DataGridView dataGridViewDatabases;
        private System.Windows.Forms.Button btnViewInstances;
        private System.Windows.Forms.Button btnAddInstance;
        private System.Windows.Forms.Button btnLoadDatabases;
        private System.Windows.Forms.TextBox txtInstance;
    }
}