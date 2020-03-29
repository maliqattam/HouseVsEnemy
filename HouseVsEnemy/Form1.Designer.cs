namespace HouseVsEnemy
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
            this.descriptipn = new System.Windows.Forms.TextBox();
            this.gottre = new System.Windows.Forms.Button();
            this.exits = new System.Windows.Forms.ComboBox();
            this.goThroughTheDoor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descriptipn
            // 
            this.descriptipn.Location = new System.Drawing.Point(12, 12);
            this.descriptipn.Multiline = true;
            this.descriptipn.Name = "descriptipn";
            this.descriptipn.Size = new System.Drawing.Size(411, 230);
            this.descriptipn.TabIndex = 0;
            this.descriptipn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // gottre
            // 
            this.gottre.Location = new System.Drawing.Point(12, 259);
            this.gottre.Name = "gottre";
            this.gottre.Size = new System.Drawing.Size(120, 23);
            this.gottre.TabIndex = 1;
            this.gottre.Text = "Go here: ";
            this.gottre.UseVisualStyleBackColor = true;
            this.gottre.Click += new System.EventHandler(this.gottre_Click);
            // 
            // exits
            // 
            this.exits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exits.FormattingEnabled = true;
            this.exits.Location = new System.Drawing.Point(152, 259);
            this.exits.Name = "exits";
            this.exits.Size = new System.Drawing.Size(271, 24);
            this.exits.TabIndex = 2;
            // 
            // goThroughTheDoor
            // 
            this.goThroughTheDoor.Location = new System.Drawing.Point(12, 305);
            this.goThroughTheDoor.Name = "goThroughTheDoor";
            this.goThroughTheDoor.Size = new System.Drawing.Size(411, 23);
            this.goThroughTheDoor.TabIndex = 3;
            this.goThroughTheDoor.Text = "Go Through the Door";
            this.goThroughTheDoor.UseVisualStyleBackColor = true;
            this.goThroughTheDoor.Click += new System.EventHandler(this.goThroughTheDoor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 355);
            this.Controls.Add(this.goThroughTheDoor);
            this.Controls.Add(this.exits);
            this.Controls.Add(this.gottre);
            this.Controls.Add(this.descriptipn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox descriptipn;
        private System.Windows.Forms.Button gottre;
        private System.Windows.Forms.ComboBox exits;
        private System.Windows.Forms.Button goThroughTheDoor;
    }
}

