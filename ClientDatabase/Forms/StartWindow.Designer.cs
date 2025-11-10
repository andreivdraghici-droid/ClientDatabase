namespace ClientDatabase.Forms
{
    partial class StartWindow
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
            this.buttonResetTable = new System.Windows.Forms.Button();
            this.labelResultsTable = new System.Windows.Forms.Label();
            this.buttonRegisterClient = new System.Windows.Forms.Button();
            this.buttonSearchDatabase = new System.Windows.Forms.Button();
            this.textBoxSearchDatabase = new System.Windows.Forms.TextBox();
            this.labelSearchDatabase = new System.Windows.Forms.Label();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonResetTable
            // 
            this.buttonResetTable.Font = new System.Drawing.Font("Nachlieli CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonResetTable.Location = new System.Drawing.Point(626, 366);
            this.buttonResetTable.Name = "buttonResetTable";
            this.buttonResetTable.Size = new System.Drawing.Size(128, 48);
            this.buttonResetTable.TabIndex = 3;
            this.buttonResetTable.Text = "Reset Rezultate";
            this.buttonResetTable.UseVisualStyleBackColor = true;
            this.buttonResetTable.Click += new System.EventHandler(this.buttonResetTable_Click);
            // 
            // labelResultsTable
            // 
            this.labelResultsTable.AutoSize = true;
            this.labelResultsTable.Font = new System.Drawing.Font("Nachlieli CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelResultsTable.Location = new System.Drawing.Point(47, 67);
            this.labelResultsTable.Name = "labelResultsTable";
            this.labelResultsTable.Size = new System.Drawing.Size(115, 18);
            this.labelResultsTable.TabIndex = 6;
            this.labelResultsTable.Text = "Rezultate Clienti";
            // 
            // buttonRegisterClient
            // 
            this.buttonRegisterClient.Font = new System.Drawing.Font("Nachlieli CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonRegisterClient.Location = new System.Drawing.Point(642, 28);
            this.buttonRegisterClient.Name = "buttonRegisterClient";
            this.buttonRegisterClient.Size = new System.Drawing.Size(112, 57);
            this.buttonRegisterClient.TabIndex = 4;
            this.buttonRegisterClient.Text = "Inregistrare Client";
            this.buttonRegisterClient.UseVisualStyleBackColor = true;
            this.buttonRegisterClient.Click += new System.EventHandler(this.buttonRegisterClient_Click);
            // 
            // buttonSearchDatabase
            // 
            this.buttonSearchDatabase.Font = new System.Drawing.Font("Nachlieli CLM", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSearchDatabase.Location = new System.Drawing.Point(497, 366);
            this.buttonSearchDatabase.Name = "buttonSearchDatabase";
            this.buttonSearchDatabase.Size = new System.Drawing.Size(112, 48);
            this.buttonSearchDatabase.TabIndex = 2;
            this.buttonSearchDatabase.Text = "Cauta";
            this.buttonSearchDatabase.UseVisualStyleBackColor = true;
            this.buttonSearchDatabase.Click += new System.EventHandler(this.buttonSearchDatabase_Click);
            // 
            // textBoxSearchDatabase
            // 
            this.textBoxSearchDatabase.Location = new System.Drawing.Point(46, 381);
            this.textBoxSearchDatabase.Name = "textBoxSearchDatabase";
            this.textBoxSearchDatabase.Size = new System.Drawing.Size(427, 20);
            this.textBoxSearchDatabase.TabIndex = 1;
            // 
            // labelSearchDatabase
            // 
            this.labelSearchDatabase.AutoSize = true;
            this.labelSearchDatabase.Font = new System.Drawing.Font("Nachlieli CLM", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelSearchDatabase.Location = new System.Drawing.Point(47, 351);
            this.labelSearchDatabase.Name = "labelSearchDatabase";
            this.labelSearchDatabase.Size = new System.Drawing.Size(102, 18);
            this.labelSearchDatabase.TabIndex = 7;
            this.labelSearchDatabase.Text = "Cautare clienti";
            this.labelSearchDatabase.Click += new System.EventHandler(this.labelSearchDatabase_Click);
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Location = new System.Drawing.Point(50, 106);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.Size = new System.Drawing.Size(703, 230);
            this.dataGridViewClients.TabIndex = 5;
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewClients);
            this.Controls.Add(this.labelSearchDatabase);
            this.Controls.Add(this.textBoxSearchDatabase);
            this.Controls.Add(this.buttonSearchDatabase);
            this.Controls.Add(this.buttonRegisterClient);
            this.Controls.Add(this.buttonResetTable);
            this.Controls.Add(this.labelResultsTable);
            this.Name = "StartWindow";
            this.Text = "Client Database App";
            this.Load += new System.EventHandler(this.StartWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonResetTable;
        private System.Windows.Forms.Label labelResultsTable;
        private System.Windows.Forms.Button buttonRegisterClient;
        private System.Windows.Forms.Button buttonSearchDatabase;
        private System.Windows.Forms.TextBox textBoxSearchDatabase;
        private System.Windows.Forms.Label labelSearchDatabase;
        private System.Windows.Forms.DataGridView dataGridViewClients;
    }
}