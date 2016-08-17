namespace Lab1
{
    partial class Necessities
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
            this.cart_list = new System.Windows.Forms.ListView();
            this.ok_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cart_list
            // 
            this.cart_list.Location = new System.Drawing.Point(35, 12);
            this.cart_list.Name = "cart_list";
            this.cart_list.Size = new System.Drawing.Size(454, 291);
            this.cart_list.TabIndex = 0;
            this.cart_list.UseCompatibleStateImageBehavior = false;
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(152, 323);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(177, 26);
            this.ok_button.TabIndex = 1;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // Necessities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 365);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.cart_list);
            this.Name = "Necessities";
            this.Text = "Necessary Items";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView cart_list;
        private System.Windows.Forms.Button ok_button;
    }
}