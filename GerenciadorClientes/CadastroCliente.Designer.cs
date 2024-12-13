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
            textBoxNome = new TextBox();
            label2 = new Label();
            textBoxCep = new TextBox();
            label3 = new Label();
            textBoxEndereco = new TextBox();
            label4 = new Label();
            textBoxBairro = new TextBox();
            label5 = new Label();
            textBoxCidade = new TextBox();
            label6 = new Label();
            textBoxUf = new TextBox();
            label7 = new Label();
            textBoxTelefone = new TextBox();
            label8 = new Label();
            textBoxEmail = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
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
            // textBoxNome
            // 
            textBoxNome.Location = new Point(118, 1);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(233, 23);
            textBoxNome.TabIndex = 1;
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
            // textBoxCep
            // 
            textBoxCep.Location = new Point(118, 35);
            textBoxCep.Name = "textBoxCep";
            textBoxCep.Size = new Size(129, 23);
            textBoxCep.TabIndex = 3;
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
            // textBoxEndereco
            // 
            textBoxEndereco.Enabled = false;
            textBoxEndereco.Location = new Point(442, 40);
            textBoxEndereco.Name = "textBoxEndereco";
            textBoxEndereco.Size = new Size(203, 23);
            textBoxEndereco.TabIndex = 5;
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
            // textBoxBairro
            // 
            textBoxBairro.Enabled = false;
            textBoxBairro.Location = new Point(118, 69);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(233, 23);
            textBoxBairro.TabIndex = 7;
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
            // textBoxCidade
            // 
            textBoxCidade.Enabled = false;
            textBoxCidade.Location = new Point(442, 74);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(203, 23);
            textBoxCidade.TabIndex = 9;
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
            // textBoxUf
            // 
            textBoxUf.Location = new Point(118, 104);
            textBoxUf.Name = "textBoxUf";
            textBoxUf.Size = new Size(233, 23);
            textBoxUf.TabIndex = 11;
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
            // textBoxTelefone
            // 
            textBoxTelefone.Location = new Point(118, 140);
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(233, 23);
            textBoxTelefone.TabIndex = 13;
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
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(442, 140);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(203, 23);
            textBoxEmail.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(12, 180);
            button1.Name = "button1";
            button1.Size = new Size(113, 31);
            button1.TabIndex = 16;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(532, 180);
            button2.Name = "button2";
            button2.Size = new Size(113, 31);
            button2.TabIndex = 17;
            button2.Text = "Inserir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_ClickAsync;
            // 
            // button3
            // 
            button3.Location = new Point(263, 35);
            button3.Name = "button3";
            button3.Size = new Size(88, 23);
            button3.TabIndex = 18;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 223);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxEmail);
            Controls.Add(label8);
            Controls.Add(textBoxTelefone);
            Controls.Add(label7);
            Controls.Add(textBoxUf);
            Controls.Add(label6);
            Controls.Add(textBoxCidade);
            Controls.Add(label5);
            Controls.Add(textBoxBairro);
            Controls.Add(label4);
            Controls.Add(textBoxEndereco);
            Controls.Add(label3);
            Controls.Add(textBoxCep);
            Controls.Add(label2);
            Controls.Add(textBoxNome);
            Controls.Add(label1);
            Name = "CadastroCliente";
            Text = "CadastroCliente";
            Load += CadastroCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxNome;
        private Label label2;
        private TextBox textBoxCep;
        private Label label3;
        private TextBox textBoxEndereco;
        private Label label4;
        private TextBox textBoxBairro;
        private Label label5;
        private TextBox textBoxCidade;
        private Label label6;
        private TextBox textBoxUf;
        private Label label7;
        private TextBox textBoxTelefone;
        private Label label8;
        private TextBox textBoxEmail;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}