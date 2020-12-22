namespace PrimerZP
{
    partial class Preface
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
            this.textBox_Preface = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Preface
            // 
            this.textBox_Preface.AutoSize = true;
            this.textBox_Preface.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Preface.Location = new System.Drawing.Point(42, 56);
            this.textBox_Preface.Name = "textBox_Preface";
            this.textBox_Preface.Size = new System.Drawing.Size(0, 69);
            this.textBox_Preface.TabIndex = 0;
            this.textBox_Preface.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.textBox_Preface.Click += new System.EventHandler(this.textBox_Preface_Click);
            // 
            // Preface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 260);
            this.Controls.Add(this.textBox_Preface);
            this.Name = "Preface";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preface";
            this.Load += new System.EventHandler(this.Preface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textBox_Preface;
    }
}