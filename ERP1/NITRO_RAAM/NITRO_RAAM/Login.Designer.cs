namespace NITRO_RAAM
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mtbxUser = new MetroFramework.Controls.MetroTextBox();
            this.mlUsuario = new MetroFramework.Controls.MetroLabel();
            this.mlPass = new MetroFramework.Controls.MetroLabel();
            this.mtbPass = new MetroFramework.Controls.MetroTextBox();
            this.mbtnEntrar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NITRO_RAAM.Properties.Resources.antutu21;
            this.pictureBox1.Location = new System.Drawing.Point(84, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mtbxUser
            // 
            // 
            // 
            // 
            this.mtbxUser.CustomButton.Image = null;
            this.mtbxUser.CustomButton.Location = new System.Drawing.Point(123, 2);
            this.mtbxUser.CustomButton.Name = "";
            this.mtbxUser.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtbxUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbxUser.CustomButton.TabIndex = 1;
            this.mtbxUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbxUser.CustomButton.UseSelectable = true;
            this.mtbxUser.CustomButton.Visible = false;
            this.mtbxUser.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtbxUser.Lines = new string[0];
            this.mtbxUser.Location = new System.Drawing.Point(424, 148);
            this.mtbxUser.MaxLength = 32767;
            this.mtbxUser.Name = "mtbxUser";
            this.mtbxUser.PasswordChar = '\0';
            this.mtbxUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbxUser.SelectedText = "";
            this.mtbxUser.SelectionLength = 0;
            this.mtbxUser.SelectionStart = 0;
            this.mtbxUser.ShortcutsEnabled = true;
            this.mtbxUser.Size = new System.Drawing.Size(149, 28);
            this.mtbxUser.TabIndex = 1;
            this.mtbxUser.UseSelectable = true;
            this.mtbxUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbxUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlUsuario
            // 
            this.mlUsuario.AutoSize = true;
            this.mlUsuario.Location = new System.Drawing.Point(463, 124);
            this.mlUsuario.Name = "mlUsuario";
            this.mlUsuario.Size = new System.Drawing.Size(56, 20);
            this.mlUsuario.TabIndex = 2;
            this.mlUsuario.Text = "Usuario";
            // 
            // mlPass
            // 
            this.mlPass.AutoSize = true;
            this.mlPass.Location = new System.Drawing.Point(450, 240);
            this.mlPass.Name = "mlPass";
            this.mlPass.Size = new System.Drawing.Size(79, 20);
            this.mlPass.TabIndex = 4;
            this.mlPass.Text = "Contraseña";
            // 
            // mtbPass
            // 
            // 
            // 
            // 
            this.mtbPass.CustomButton.Image = null;
            this.mtbPass.CustomButton.Location = new System.Drawing.Point(123, 2);
            this.mtbPass.CustomButton.Name = "";
            this.mtbPass.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtbPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbPass.CustomButton.TabIndex = 1;
            this.mtbPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbPass.CustomButton.UseSelectable = true;
            this.mtbPass.CustomButton.Visible = false;
            this.mtbPass.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtbPass.Lines = new string[0];
            this.mtbPass.Location = new System.Drawing.Point(424, 264);
            this.mtbPass.MaxLength = 32767;
            this.mtbPass.Name = "mtbPass";
            this.mtbPass.PasswordChar = '*';
            this.mtbPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbPass.SelectedText = "";
            this.mtbPass.SelectionLength = 0;
            this.mtbPass.SelectionStart = 0;
            this.mtbPass.ShortcutsEnabled = true;
            this.mtbPass.Size = new System.Drawing.Size(149, 28);
            this.mtbPass.TabIndex = 3;
            this.mtbPass.UseSelectable = true;
            this.mtbPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mbtnEntrar
            // 
            this.mbtnEntrar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mbtnEntrar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mbtnEntrar.Location = new System.Drawing.Point(450, 363);
            this.mbtnEntrar.Name = "mbtnEntrar";
            this.mbtnEntrar.Size = new System.Drawing.Size(99, 38);
            this.mbtnEntrar.TabIndex = 5;
            this.mbtnEntrar.Text = "Entrar";
            this.mbtnEntrar.UseSelectable = true;
            this.mbtnEntrar.Click += new System.EventHandler(this.mbtnEntrar_Click);
            // 
            // Login1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.mbtnEntrar);
            this.Controls.Add(this.mlPass);
            this.Controls.Add(this.mtbPass);
            this.Controls.Add(this.mlUsuario);
            this.Controls.Add(this.mtbxUser);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login1";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox mtbxUser;
        private MetroFramework.Controls.MetroLabel mlUsuario;
        private MetroFramework.Controls.MetroLabel mlPass;
        private MetroFramework.Controls.MetroTextBox mtbPass;
        private MetroFramework.Controls.MetroButton mbtnEntrar;
    }
}