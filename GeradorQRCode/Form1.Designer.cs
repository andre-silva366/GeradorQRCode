namespace GeradorQRCode
{
    partial class Form1
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
            label1 = new Label();
            textBoxURL = new TextBox();
            buttonGerarQRCode = new Button();
            buttonLimpar = new Button();
            labelMensagem = new Label();
            pictureBoxQRCode = new PictureBox();
            saveFileDialogQRCode = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRCode).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(234, 51);
            label1.TabIndex = 0;
            label1.Text = "Input the URL to convert: ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxURL
            // 
            textBoxURL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxURL.Location = new Point(252, 63);
            textBoxURL.Name = "textBoxURL";
            textBoxURL.Size = new Size(587, 29);
            textBoxURL.TabIndex = 1;
            // 
            // buttonGerarQRCode
            // 
            buttonGerarQRCode.BackColor = Color.FromArgb(0, 192, 0);
            buttonGerarQRCode.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGerarQRCode.Location = new Point(252, 114);
            buttonGerarQRCode.Name = "buttonGerarQRCode";
            buttonGerarQRCode.Size = new Size(240, 43);
            buttonGerarQRCode.TabIndex = 2;
            buttonGerarQRCode.Text = "Generate QR Code";
            buttonGerarQRCode.UseVisualStyleBackColor = false;
            buttonGerarQRCode.Click += buttonGerarQRCode_Click;
            // 
            // buttonLimpar
            // 
            buttonLimpar.BackColor = Color.Red;
            buttonLimpar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLimpar.Location = new Point(599, 114);
            buttonLimpar.Name = "buttonLimpar";
            buttonLimpar.Size = new Size(240, 43);
            buttonLimpar.TabIndex = 3;
            buttonLimpar.Text = "Clean";
            buttonLimpar.UseVisualStyleBackColor = false;
            buttonLimpar.Click += buttonLimpar_Click;
            // 
            // labelMensagem
            // 
            labelMensagem.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelMensagem.Location = new Point(12, 185);
            labelMensagem.Name = "labelMensagem";
            labelMensagem.Size = new Size(827, 64);
            labelMensagem.TabIndex = 4;
            labelMensagem.Text = "Your QR Code appears below";
            labelMensagem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxQRCode
            // 
            pictureBoxQRCode.Location = new Point(225, 252);
            pictureBoxQRCode.Name = "pictureBoxQRCode";
            pictureBoxQRCode.Size = new Size(400, 400);
            pictureBoxQRCode.TabIndex = 5;
            pictureBoxQRCode.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 677);
            Controls.Add(pictureBoxQRCode);
            Controls.Add(labelMensagem);
            Controls.Add(buttonLimpar);
            Controls.Add(buttonGerarQRCode);
            Controls.Add(textBoxURL);
            Controls.Add(label1);
            MinimumSize = new Size(867, 716);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerador de QR Code";
            ((System.ComponentModel.ISupportInitialize)pictureBoxQRCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal Label label1;
        private TextBox textBoxURL;
        private Button buttonGerarQRCode;
        private Button buttonLimpar;
        internal Label labelMensagem;
        private PictureBox pictureBoxQRCode;
        internal SaveFileDialog saveFileDialogQRCode;
    }
}
