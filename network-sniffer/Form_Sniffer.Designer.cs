namespace network_sniffer
{
    partial class Form_Sniffer
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
            this.textbox_messages = new System.Windows.Forms.TextBox();
            this.button_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textbox_messages
            // 
            this.textbox_messages.Location = new System.Drawing.Point(13, 13);
            this.textbox_messages.Multiline = true;
            this.textbox_messages.Name = "textbox_messages";
            this.textbox_messages.Size = new System.Drawing.Size(775, 391);
            this.textbox_messages.TabIndex = 0;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(13, 415);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // form_sniffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.textbox_messages);
            this.Name = "form_sniffer";
            this.Text = "Sniffer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_messages;
        private System.Windows.Forms.Button button_start;
    }
}

