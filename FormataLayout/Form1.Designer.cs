namespace FormataLayout
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_processa = new Button();
            dataGridView1 = new DataGridView();
            txtLayout = new TextBox();
            txtString = new TextBox();
            grd_nome = new DataGridViewTextBoxColumn();
            grd_valor = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_processa
            // 
            btn_processa.Location = new Point(357, 290);
            btn_processa.Name = "btn_processa";
            btn_processa.Size = new Size(150, 46);
            btn_processa.TabIndex = 0;
            btn_processa.Text = "Processar";
            btn_processa.UseVisualStyleBackColor = true;
            btn_processa.Click += btn_processa_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { grd_nome, grd_valor });
            dataGridView1.Location = new Point(357, 359);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(812, 1074);
            dataGridView1.TabIndex = 1;
            // 
            // txtLayout
            // 
            txtLayout.Location = new Point(54, 51);
            txtLayout.Multiline = true;
            txtLayout.Name = "txtLayout";
            txtLayout.Size = new Size(200, 1421);
            txtLayout.TabIndex = 2;
            // 
            // txtString
            // 
            txtString.Location = new Point(357, 51);
            txtString.Multiline = true;
            txtString.Name = "txtString";
            txtString.Size = new Size(812, 218);
            txtString.TabIndex = 3;
            // 
            // grd_nome
            // 
            grd_nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grd_nome.HeaderText = "Nome";
            grd_nome.MinimumWidth = 10;
            grd_nome.Name = "grd_nome";
            // 
            // grd_valor
            // 
            grd_valor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grd_valor.HeaderText = "Valor";
            grd_valor.MinimumWidth = 10;
            grd_valor.Name = "grd_valor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 16);
            label1.Name = "label1";
            label1.Size = new Size(85, 32);
            label1.TabIndex = 4;
            label1.Text = "Layout";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(357, 16);
            label2.Name = "label2";
            label2.Size = new Size(161, 32);
            label2.TabIndex = 5;
            label2.Text = "Insira a string:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 1572);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtString);
            Controls.Add(txtLayout);
            Controls.Add(dataGridView1);
            Controls.Add(btn_processa);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_processa;
        private DataGridView dataGridView1;
        private TextBox txtLayout;
        private TextBox txtString;
        private DataGridViewTextBoxColumn grd_nome;
        private DataGridViewTextBoxColumn grd_valor;
        private Label label1;
        private Label label2;
    }
}