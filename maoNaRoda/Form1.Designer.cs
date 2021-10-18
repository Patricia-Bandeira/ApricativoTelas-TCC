
namespace maoNaRoda
{
    partial class FormInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrarr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtLogin.Location = new System.Drawing.Point(23, 347);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogin.Size = new System.Drawing.Size(211, 22);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtSenha.Location = new System.Drawing.Point(23, 432);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(220, 22);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.UseSystemPasswordChar = true;
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
            this.btnEntrar.Location = new System.Drawing.Point(41, 484);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(187, 34);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Location = new System.Drawing.Point(54, 643);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(243, 31);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(38, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "E-mail: etec@gmail.com Senha: 12345";
            // 
            // btnCadastrarr
            // 
            this.btnCadastrarr.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarr.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCadastrarr.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnCadastrarr.FlatAppearance.BorderSize = 0;
            this.btnCadastrarr.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnCadastrarr.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnCadastrarr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarr.ForeColor = System.Drawing.Color.Transparent;
            this.btnCadastrarr.Location = new System.Drawing.Point(41, 535);
            this.btnCadastrarr.Name = "btnCadastrarr";
            this.btnCadastrarr.Size = new System.Drawing.Size(187, 34);
            this.btnCadastrarr.TabIndex = 5;
            this.btnCadastrarr.UseVisualStyleBackColor = true;
            this.btnCadastrarr.Click += new System.EventHandler(this.btnCadastrarr_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(270, 581);
            this.Controls.Add(this.btnCadastrarr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.MaximumSize = new System.Drawing.Size(286, 620);
            this.MinimumSize = new System.Drawing.Size(286, 620);
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrarr;
    }
}

