
namespace maoNaRoda
{
    partial class formCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCadastro));
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtConfirmSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.brnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtLogin.Location = new System.Drawing.Point(24, 184);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogin.Size = new System.Drawing.Size(223, 22);
            this.txtLogin.TabIndex = 1;
            // 
            // txtGmail
            // 
            this.txtGmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtGmail.Location = new System.Drawing.Point(24, 268);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGmail.Size = new System.Drawing.Size(223, 22);
            this.txtGmail.TabIndex = 2;
            this.txtGmail.TextChanged += new System.EventHandler(this.txtGmail_TextChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSenha.Location = new System.Drawing.Point(24, 350);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSenha.Size = new System.Drawing.Size(223, 22);
            this.txtSenha.TabIndex = 3;
            // 
            // txtConfirmSenha
            // 
            this.txtConfirmSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirmSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtConfirmSenha.Location = new System.Drawing.Point(24, 435);
            this.txtConfirmSenha.Name = "txtConfirmSenha";
            this.txtConfirmSenha.PasswordChar = '*';
            this.txtConfirmSenha.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConfirmSenha.Size = new System.Drawing.Size(223, 22);
            this.txtConfirmSenha.TabIndex = 4;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Transparent;
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnEntrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.ForeColor = System.Drawing.Color.Transparent;
            this.btnEntrar.Location = new System.Drawing.Point(39, 529);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(196, 31);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // brnCadastrar
            // 
            this.brnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.brnCadastrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.brnCadastrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.brnCadastrar.FlatAppearance.BorderSize = 0;
            this.brnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.brnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.brnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnCadastrar.ForeColor = System.Drawing.Color.Transparent;
            this.brnCadastrar.Location = new System.Drawing.Point(39, 479);
            this.brnCadastrar.Name = "brnCadastrar";
            this.brnCadastrar.Size = new System.Drawing.Size(196, 31);
            this.brnCadastrar.TabIndex = 6;
            this.brnCadastrar.UseVisualStyleBackColor = true;
            this.brnCadastrar.Click += new System.EventHandler(this.brnCadastrar_Click);
            // 
            // formCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(270, 581);
            this.Controls.Add(this.brnCadastrar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtConfirmSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtGmail);
            this.Controls.Add(this.txtLogin);
            this.MaximumSize = new System.Drawing.Size(286, 620);
            this.MinimumSize = new System.Drawing.Size(286, 620);
            this.Name = "formCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtGmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtConfirmSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button brnCadastrar;
    }
}