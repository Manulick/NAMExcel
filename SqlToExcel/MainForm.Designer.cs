namespace SqlToExcel
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
            txtQuery = new TextBox();
            dataGridView1 = new DataGridView();
            btnEjecutar = new Button();
            btnExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtQuery
            // 
            txtQuery.Location = new Point(12, 10);
            txtQuery.Multiline = true;
            txtQuery.Name = "txtQuery";
            txtQuery.Size = new Size(438, 83);
            txtQuery.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 145);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(438, 253);
            dataGridView1.TabIndex = 1;
            // 
            // btnEjecutar
            // 
            btnEjecutar.Location = new Point(79, 99);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(75, 23);
            btnEjecutar.TabIndex = 4;
            btnEjecutar.Text = "Ejecutar";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // btnExcel
            // 
            btnExcel.Location = new Point(302, 99);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(75, 23);
            btnExcel.TabIndex = 5;
            btnExcel.Text = "Crear Excel";
            btnExcel.UseVisualStyleBackColor = true;
            btnExcel.Click += btnExcel_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 405);
            Controls.Add(btnExcel);
            Controls.Add(btnEjecutar);
            Controls.Add(dataGridView1);
            Controls.Add(txtQuery);
            Name = "MainForm";
            Text = "`";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtQuery;
        private DataGridView dataGridView1;
        private Button btnEjecutar;
        private Button btnExcel;
    }
}