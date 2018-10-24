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
            this.combobox_interfaces = new System.Windows.Forms.ComboBox();
            this.button_loaddevices = new System.Windows.Forms.Button();
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
            // combobox_interfaces
            // 
            this.combobox_interfaces.FormattingEnabled = true;
            this.combobox_interfaces.Location = new System.Drawing.Point(208, 418);
            this.combobox_interfaces.Name = "combobox_interfaces";
            this.combobox_interfaces.Size = new System.Drawing.Size(206, 21);
            this.combobox_interfaces.TabIndex = 2;
            // 
            // button_loaddevices
            // 
            this.button_loaddevices.Location = new System.Drawing.Point(94, 416);
            this.button_loaddevices.Name = "button_loaddevices";
            this.button_loaddevices.Size = new System.Drawing.Size(108, 23);
            this.button_loaddevices.TabIndex = 3;
            this.button_loaddevices.Text = "Load devices";
            this.button_loaddevices.UseVisualStyleBackColor = true;
            this.button_loaddevices.Click += new System.EventHandler(this.button_loaddevices_Click);
            // 
            // Form_Sniffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_loaddevices);
            this.Controls.Add(this.combobox_interfaces);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.textbox_messages);
            this.Name = "Form_Sniffer";
            this.Text = "Sniffer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_messages;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.ComboBox combobox_interfaces;
        private System.Windows.Forms.Button button_loaddevices;
    }
}

