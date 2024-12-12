namespace GerenciadorClientes
{
    partial class CadastroCliente
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox8 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do Cliente:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(118, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 43);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 2;
            label2.Text = "Digite o CEP:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(118, 35);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(233, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(371, 43);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 4;
            label3.Text = "Endereço:";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(442, 40);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(203, 23);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 77);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 6;
            label4.Text = "Bairro:";
            label4.Click += label4_Click;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(118, 69);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(233, 23);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(371, 77);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 8;
            label5.Text = "Cidade:";
            label5.Click += label5_Click;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(442, 74);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(203, 23);
            textBox5.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 112);
            label6.Name = "label6";
            label6.Size = new Size(24, 15);
            label6.TabIndex = 10;
            label6.Text = "UF:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(118, 104);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(233, 23);
            textBox6.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 148);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 12;
            label7.Text = "Telefone:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(118, 140);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(233, 23);
            textBox7.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(371, 148);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 14;
            label8.Text = "E-mail:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(442, 140);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(58, 23);
            textBox8.TabIndex = 15;
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 165);
            Controls.Add(textBox8);
            Controls.Add(label8);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "CadastroCliente";
            Text = "CadastroCliente";
            Load += CadastroCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox8;
    }
}