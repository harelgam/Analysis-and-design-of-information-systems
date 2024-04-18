namespace Group4
{
    partial class ReasonForHoldForm
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
            this.ReasonForGap_textbox = new System.Windows.Forms.TextBox();
            this.Confirm_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(155, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "What is the reason for the gap?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ReasonForGap_textbox
            // 
            this.ReasonForGap_textbox.Location = new System.Drawing.Point(100, 133);
            this.ReasonForGap_textbox.Name = "ReasonForGap_textbox";
            this.ReasonForGap_textbox.Size = new System.Drawing.Size(593, 20);
            this.ReasonForGap_textbox.TabIndex = 1;
            this.ReasonForGap_textbox.TextChanged += new System.EventHandler(this.ReasonForGap_textbox_TextChanged);
            // 
            // Confirm_btn
            // 
            this.Confirm_btn.Location = new System.Drawing.Point(298, 211);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.Size = new System.Drawing.Size(182, 79);
            this.Confirm_btn.TabIndex = 2;
            this.Confirm_btn.Text = "Confirm";
            this.Confirm_btn.UseVisualStyleBackColor = true;
            this.Confirm_btn.Click += new System.EventHandler(this.Confirm_btn_Click);
            // 
            // ReasonForHoldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 353);
            this.Controls.Add(this.Confirm_btn);
            this.Controls.Add(this.ReasonForGap_textbox);
            this.Controls.Add(this.label1);
            this.Name = "ReasonForHoldForm";
            this.Text = "ReasonForHoldForm";
            this.Load += new System.EventHandler(this.ReasonForHoldForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ReasonForGap_textbox;
        private System.Windows.Forms.Button Confirm_btn;
    }
}