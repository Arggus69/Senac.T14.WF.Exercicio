namespace Senac.T14.WF.Exercicio
{
    partial class FrmPrincipal
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
            groupBox1 = new GroupBox();
            btnSair = new Button();
            btnUsuario = new Button();
            btnChamadas = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSair);
            groupBox1.Controls.Add(btnUsuario);
            groupBox1.Controls.Add(btnChamadas);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(541, 399);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(187, 348);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(167, 48);
            btnSair.TabIndex = 2;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnUsuario
            // 
            btnUsuario.Location = new Point(319, 116);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(167, 163);
            btnUsuario.TabIndex = 1;
            btnUsuario.Text = "Usuario";
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnChamadas
            // 
            btnChamadas.Location = new Point(75, 116);
            btnChamadas.Name = "btnChamadas";
            btnChamadas.Size = new Size(167, 163);
            btnChamadas.TabIndex = 0;
            btnChamadas.Text = "Chamadas";
            btnChamadas.UseVisualStyleBackColor = true;
            btnChamadas.Click += btnChamadas_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 436);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSair;
        private Button btnUsuario;
        private Button btnChamadas;
    }
}
