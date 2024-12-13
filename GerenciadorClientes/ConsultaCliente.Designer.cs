namespace GerenciadorClientes
{
    partial class ConsultaCliente
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            buttonSearch = new Button();
            comboBox1 = new ComboBox();
            buttonPrevPage = new Button();
            buttonNextPage = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(812, 334);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(1, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(316, 23);
            textBox1.TabIndex = 3;
            // 
            // buttonSearch
            // 
            buttonSearch.Anchor = AnchorStyles.None;
            buttonSearch.Location = new Point(617, 9);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(196, 26);
            buttonSearch.TabIndex = 4;
            buttonSearch.Text = "Consultar";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nome", "Telefone" });
            comboBox1.Location = new Point(339, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(187, 23);
            comboBox1.TabIndex = 5;
            // 
            // buttonPrevPage
            // 
            buttonPrevPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonPrevPage.Location = new Point(1, 382);
            buttonPrevPage.Name = "buttonPrevPage";
            buttonPrevPage.Size = new Size(100, 23);
            buttonPrevPage.TabIndex = 6;
            buttonPrevPage.Text = "Página Anterior";
            buttonPrevPage.UseVisualStyleBackColor = true;
            buttonPrevPage.Click += buttonPrevPage_Click;
            // 
            // buttonNextPage
            // 
            buttonNextPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonNextPage.Location = new Point(713, 382);
            buttonNextPage.Name = "buttonNextPage";
            buttonNextPage.Size = new Size(100, 23);
            buttonNextPage.TabIndex = 7;
            buttonNextPage.Text = "Próxima Página";
            buttonNextPage.UseVisualStyleBackColor = true;
            buttonNextPage.Click += buttonNextPage_Click;
            // 
            // ConsultaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 406);
            Controls.Add(comboBox1);
            Controls.Add(buttonSearch);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(buttonPrevPage);
            Controls.Add(buttonNextPage);
            Name = "ConsultaCliente";
            Text = "Form2";
            Load += ConsultaCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button buttonSearch;
        private ComboBox comboBox1;
        private Button buttonPrevPage;
        private Button buttonNextPage;
    }
}
