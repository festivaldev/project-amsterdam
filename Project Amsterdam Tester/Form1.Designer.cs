namespace Project_Amsterdam_Tester
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.singleColorMatrix1 = new Amsterdam.SingleColorMatrix();
            this.SuspendLayout();
            // 
            // singleColorMatrix1
            // 
            this.singleColorMatrix1.Location = new System.Drawing.Point(91, 128);
            this.singleColorMatrix1.Name = "singleColorMatrix1";
            this.singleColorMatrix1.Size = new System.Drawing.Size(1402, 130);
            this.singleColorMatrix1.TabIndex = 0;
            this.singleColorMatrix1.Text = "singleColorMatrix1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1584, 427);
            this.Controls.Add(this.singleColorMatrix1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Amsterdam.SingleColorMatrix singleColorMatrix1;
    }
}

