
namespace Tyuiu.ChepurnykhSR.Sprint7.Project.V14
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            this.buttonClose_CSR = new System.Windows.Forms.Button();
            this.labelInfo_CSR = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonClose_CSR
            // 
            this.buttonClose_CSR.Location = new System.Drawing.Point(700, 318);
            this.buttonClose_CSR.Name = "buttonClose_CSR";
            this.buttonClose_CSR.Size = new System.Drawing.Size(75, 23);
            this.buttonClose_CSR.TabIndex = 0;
            this.buttonClose_CSR.Text = "Закрыть";
            this.buttonClose_CSR.UseVisualStyleBackColor = true;
            this.buttonClose_CSR.Click += new System.EventHandler(this.buttonClose_CSR_Click);
            this.buttonClose_CSR.MouseEnter += new System.EventHandler(this.buttonClose_CSR_MouseEnter);
            this.buttonClose_CSR.MouseLeave += new System.EventHandler(this.buttonClose_CSR_MouseLeave);
            // 
            // labelInfo_CSR
            // 
            this.labelInfo_CSR.AutoSize = true;
            this.labelInfo_CSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo_CSR.Location = new System.Drawing.Point(12, 9);
            this.labelInfo_CSR.Name = "labelInfo_CSR";
            this.labelInfo_CSR.Size = new System.Drawing.Size(778, 306);
            this.labelInfo_CSR.TabIndex = 1;
            this.labelInfo_CSR.Text = resources.GetString("labelInfo_CSR.Text");
            // 
            // FormGuide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 353);
            this.Controls.Add(this.labelInfo_CSR);
            this.Controls.Add(this.buttonClose_CSR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGuide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Информация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose_CSR;
        private System.Windows.Forms.Label labelInfo_CSR;
    }
}