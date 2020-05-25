namespace EmailAddressValidator
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Label_Email = new System.Windows.Forms.Label();
            this.TextBox_Email = new System.Windows.Forms.TextBox();
            this.Button_Check = new System.Windows.Forms.Button();
            this.PictureBox_Result = new System.Windows.Forms.PictureBox();
            this.Label_Result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Result)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Email
            // 
            this.Label_Email.AutoSize = true;
            this.Label_Email.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Email.Location = new System.Drawing.Point(33, 24);
            this.Label_Email.Name = "Label_Email";
            this.Label_Email.Size = new System.Drawing.Size(190, 24);
            this.Label_Email.TabIndex = 0;
            this.Label_Email.Text = "Dirección de Correo:";
            // 
            // TextBox_Email
            // 
            this.TextBox_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Email.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Email.Location = new System.Drawing.Point(37, 62);
            this.TextBox_Email.Name = "TextBox_Email";
            this.TextBox_Email.Size = new System.Drawing.Size(453, 32);
            this.TextBox_Email.TabIndex = 1;
            // 
            // Button_Check
            // 
            this.Button_Check.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Check.Location = new System.Drawing.Point(149, 112);
            this.Button_Check.Name = "Button_Check";
            this.Button_Check.Size = new System.Drawing.Size(245, 50);
            this.Button_Check.TabIndex = 2;
            this.Button_Check.Text = "Revisar";
            this.Button_Check.UseVisualStyleBackColor = true;
            this.Button_Check.Click += new System.EventHandler(this.Button_Check_Click);
            // 
            // PictureBox_Result
            // 
            this.PictureBox_Result.Location = new System.Drawing.Point(12, 176);
            this.PictureBox_Result.Name = "PictureBox_Result";
            this.PictureBox_Result.Size = new System.Drawing.Size(100, 100);
            this.PictureBox_Result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Result.TabIndex = 3;
            this.PictureBox_Result.TabStop = false;
            this.PictureBox_Result.Visible = false;
            // 
            // Label_Result
            // 
            this.Label_Result.AutoSize = true;
            this.Label_Result.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Result.Location = new System.Drawing.Point(123, 216);
            this.Label_Result.Name = "Label_Result";
            this.Label_Result.Size = new System.Drawing.Size(100, 24);
            this.Label_Result.TabIndex = 5;
            this.Label_Result.Text = "Resultado";
            this.Label_Result.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(531, 288);
            this.Controls.Add(this.Label_Result);
            this.Controls.Add(this.PictureBox_Result);
            this.Controls.Add(this.Button_Check);
            this.Controls.Add(this.TextBox_Email);
            this.Controls.Add(this.Label_Email);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validador de Correos";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Result)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Email;
        private System.Windows.Forms.TextBox TextBox_Email;
        private System.Windows.Forms.Button Button_Check;
        private System.Windows.Forms.PictureBox PictureBox_Result;
        private System.Windows.Forms.Label Label_Result;
    }
}

