namespace Lab1
{
    partial class Form1
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
            this.login_panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password_box = new System.Windows.Forms.TextBox();
            this.username_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_products = new System.Windows.Forms.Label();
            this.label_shopping = new System.Windows.Forms.Label();
            this.product_list = new System.Windows.Forms.ListView();
            this.add_button = new System.Windows.Forms.Button();
            this.remove_button = new System.Windows.Forms.Button();
            this.finalize_button = new System.Windows.Forms.Button();
            this.shopping_list = new System.Windows.Forms.ListView();
            this.login_panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_panel
            // 
            this.login_panel.Controls.Add(this.button1);
            this.login_panel.Controls.Add(this.label3);
            this.login_panel.Controls.Add(this.label2);
            this.login_panel.Controls.Add(this.password_box);
            this.login_panel.Controls.Add(this.username_box);
            this.login_panel.Controls.Add(this.label1);
            this.login_panel.Location = new System.Drawing.Point(327, 58);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(226, 184);
            this.login_panel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(89, 102);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(95, 20);
            this.password_box.TabIndex = 2;
            // 
            // username_box
            // 
            this.username_box.Location = new System.Drawing.Point(89, 61);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(95, 20);
            this.username_box.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log In";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createSessionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1018, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createSessionToolStripMenuItem
            // 
            this.createSessionToolStripMenuItem.Enabled = false;
            this.createSessionToolStripMenuItem.Name = "createSessionToolStripMenuItem";
            this.createSessionToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.createSessionToolStripMenuItem.Text = "Create Session";
            this.createSessionToolStripMenuItem.Click += new System.EventHandler(this.createSessionToolStripMenuItem_Click);
            // 
            // label_products
            // 
            this.label_products.AutoSize = true;
            this.label_products.Enabled = false;
            this.label_products.Location = new System.Drawing.Point(90, 38);
            this.label_products.Name = "label_products";
            this.label_products.Size = new System.Drawing.Size(95, 13);
            this.label_products.TabIndex = 2;
            this.label_products.Text = "Available Products";
            this.label_products.Visible = false;
            // 
            // label_shopping
            // 
            this.label_shopping.AutoSize = true;
            this.label_shopping.Enabled = false;
            this.label_shopping.Location = new System.Drawing.Point(548, 39);
            this.label_shopping.Name = "label_shopping";
            this.label_shopping.Size = new System.Drawing.Size(99, 13);
            this.label_shopping.TabIndex = 3;
            this.label_shopping.Text = "Your Shopping Cart";
            this.label_shopping.Visible = false;
            // 
            // product_list
            // 
            this.product_list.Location = new System.Drawing.Point(11, 58);
            this.product_list.Name = "product_list";
            this.product_list.Size = new System.Drawing.Size(423, 282);
            this.product_list.TabIndex = 4;
            this.product_list.UseCompatibleStateImageBehavior = false;
            this.product_list.Visible = false;
            // 
            // add_button
            // 
            this.add_button.Enabled = false;
            this.add_button.Location = new System.Drawing.Point(78, 359);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(266, 31);
            this.add_button.TabIndex = 5;
            this.add_button.Text = "Add to Cart";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Visible = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // remove_button
            // 
            this.remove_button.Enabled = false;
            this.remove_button.Location = new System.Drawing.Point(494, 359);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(153, 30);
            this.remove_button.TabIndex = 6;
            this.remove_button.Text = "Remove from Cart";
            this.remove_button.UseVisualStyleBackColor = true;
            this.remove_button.Visible = false;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // finalize_button
            // 
            this.finalize_button.Enabled = false;
            this.finalize_button.Location = new System.Drawing.Point(674, 360);
            this.finalize_button.Name = "finalize_button";
            this.finalize_button.Size = new System.Drawing.Size(136, 28);
            this.finalize_button.TabIndex = 7;
            this.finalize_button.Text = "View Intallation Summary";
            this.finalize_button.UseVisualStyleBackColor = true;
            this.finalize_button.Visible = false;
            this.finalize_button.Click += new System.EventHandler(this.finalize_button_Click);
            // 
            // shopping_list
            // 
            this.shopping_list.Enabled = false;
            this.shopping_list.Location = new System.Drawing.Point(494, 58);
            this.shopping_list.Name = "shopping_list";
            this.shopping_list.Size = new System.Drawing.Size(512, 282);
            this.shopping_list.TabIndex = 8;
            this.shopping_list.UseCompatibleStateImageBehavior = false;
            this.shopping_list.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 402);
            this.Controls.Add(this.shopping_list);
            this.Controls.Add(this.finalize_button);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.product_list);
            this.Controls.Add(this.label_shopping);
            this.Controls.Add(this.label_products);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.login_panel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.login_panel.ResumeLayout(false);
            this.login_panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel login_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createSessionToolStripMenuItem;
        private System.Windows.Forms.Label label_products;
        private System.Windows.Forms.Label label_shopping;
        private System.Windows.Forms.ListView product_list;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.Button finalize_button;
        private System.Windows.Forms.ListView shopping_list;
    }
}

