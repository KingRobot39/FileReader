namespace FileReader___dylan_hughes
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
            this.filepathlabel = new System.Windows.Forms.Label();
            this.filepathtextbox = new System.Windows.Forms.TextBox();
            this.readbutton = new System.Windows.Forms.Button();
            this.displaylistbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // filepathlabel
            // 
            this.filepathlabel.AutoSize = true;
            this.filepathlabel.Location = new System.Drawing.Point(87, 33);
            this.filepathlabel.Name = "filepathlabel";
            this.filepathlabel.Size = new System.Drawing.Size(121, 20);
            this.filepathlabel.TabIndex = 0;
            this.filepathlabel.Text = "File Path/Name:";
            // 
            // filepathtextbox
            // 
            this.filepathtextbox.Location = new System.Drawing.Point(214, 30);
            this.filepathtextbox.Name = "filepathtextbox";
            this.filepathtextbox.Size = new System.Drawing.Size(390, 26);
            this.filepathtextbox.TabIndex = 1;
            // 
            // readbutton
            // 
            this.readbutton.Location = new System.Drawing.Point(91, 85);
            this.readbutton.Name = "readbutton";
            this.readbutton.Size = new System.Drawing.Size(117, 29);
            this.readbutton.TabIndex = 2;
            this.readbutton.Text = "Read File";
            this.readbutton.UseVisualStyleBackColor = true;
            this.readbutton.Click += new System.EventHandler(this.readbutton_Click);
            // 
            // displaylistbox
            // 
            this.displaylistbox.FormattingEnabled = true;
            this.displaylistbox.ItemHeight = 20;
            this.displaylistbox.Location = new System.Drawing.Point(91, 159);
            this.displaylistbox.Name = "displaylistbox";
            this.displaylistbox.Size = new System.Drawing.Size(626, 204);
            this.displaylistbox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.displaylistbox);
            this.Controls.Add(this.readbutton);
            this.Controls.Add(this.filepathtextbox);
            this.Controls.Add(this.filepathlabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label filepathlabel;
        private System.Windows.Forms.TextBox filepathtextbox;
        private System.Windows.Forms.Button readbutton;
        private System.Windows.Forms.ListBox displaylistbox;
    }
}

