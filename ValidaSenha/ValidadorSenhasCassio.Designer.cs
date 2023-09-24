namespace ValidaSenha
{
    partial class Frm_ValidaSenha
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
            TXT_Senha = new TextBox();
            LBL_Resultado = new Label();
            Btn_Reset = new Button();
            BTN_VerSenha = new Button();
            SuspendLayout();
            // 
            // TXT_Senha
            // 
            TXT_Senha.Location = new Point(12, 45);
            TXT_Senha.Name = "TXT_Senha";
            TXT_Senha.PasswordChar = '*';
            TXT_Senha.PlaceholderText = "  veja a força de sua senha";
            TXT_Senha.Size = new Size(218, 23);
            TXT_Senha.TabIndex = 0;
            TXT_Senha.KeyDown += TXT_Senha_KeyDown;
            // 
            // LBL_Resultado
            // 
            LBL_Resultado.AutoSize = true;
            LBL_Resultado.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LBL_Resultado.Location = new Point(12, 90);
            LBL_Resultado.Name = "LBL_Resultado";
            LBL_Resultado.Size = new Size(0, 22);
            LBL_Resultado.TabIndex = 1;
            LBL_Resultado.Click += LBL_Resultado_Click;
            // 
            // Btn_Reset
            // 
            Btn_Reset.Cursor = Cursors.Hand;
            Btn_Reset.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Reset.Location = new Point(245, 42);
            Btn_Reset.Margin = new Padding(0);
            Btn_Reset.Name = "Btn_Reset";
            Btn_Reset.Size = new Size(111, 26);
            Btn_Reset.TabIndex = 2;
            Btn_Reset.Text = "Limpar";
            Btn_Reset.TextAlign = ContentAlignment.TopCenter;
            Btn_Reset.UseVisualStyleBackColor = true;
            Btn_Reset.Click += Btn_Reset_Click;
            // 
            // BTN_VerSenha
            // 
            BTN_VerSenha.Cursor = Cursors.Hand;
            BTN_VerSenha.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            BTN_VerSenha.Location = new Point(245, 77);
            BTN_VerSenha.Margin = new Padding(0);
            BTN_VerSenha.Name = "BTN_VerSenha";
            BTN_VerSenha.Size = new Size(111, 26);
            BTN_VerSenha.TabIndex = 3;
            BTN_VerSenha.Text = "Mostrar";
            BTN_VerSenha.TextAlign = ContentAlignment.TopCenter;
            BTN_VerSenha.UseVisualStyleBackColor = true;
            BTN_VerSenha.Click += BTN_VerSenha_Click;
            // 
            // Frm_ValidaSenha
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(368, 154);
            Controls.Add(BTN_VerSenha);
            Controls.Add(Btn_Reset);
            Controls.Add(LBL_Resultado);
            Controls.Add(TXT_Senha);
            HelpButton = true;
            Name = "Frm_ValidaSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Validação de Senhas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TXT_Senha;
        private Label LBL_Resultado;
        private Button Btn_Reset;
        private Button BTN_VerSenha;
    }
}