namespace GerenciadorClientes
{
    partial class DeletarCadastro
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
            buttonID = new Button();
            textBoxID = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonID
            // 
            buttonID.Location = new Point(196, 6);
            buttonID.Name = "buttonID";
            buttonID.Size = new Size(75, 23);
            buttonID.TabIndex = 0;
            buttonID.Text = "Deletar";
            buttonID.UseVisualStyleBackColor = true;
            buttonID.Click += buttonID_Click;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(90, 6);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(100, 23);
            textBoxID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 2;
            label1.Text = "Insira o ID";
            // 
            // DeletarCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 33);
            Controls.Add(label1);
            Controls.Add(textBoxID);
            Controls.Add(buttonID);
            Name = "DeletarCadastro";
            Text = "DeletarCadastro";
            Load += DeletarCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonID;
        private TextBox textBoxID;
        private Label label1;
    }
}