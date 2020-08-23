namespace GmodUploadTool
{
    partial class Form7
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
            this.label1 = new System.Windows.Forms.Label();
            skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "输出目录不能为空！！！";
            // 
            // skinEngine1
            // 
            skinEngine1.@__DrawButtonFocusRectangle = true;
            skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            skinEngine1.SerialNumber = "";
            skinEngine1.SkinFile = null;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 35);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "警告";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public static Sunisoft.IrisSkin.SkinEngine skinEngine1;
    }
}