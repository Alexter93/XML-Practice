namespace XMLPractice
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtXMLFile = new System.Windows.Forms.TextBox();
            this.btnBrowseXML = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFileContent = new System.Windows.Forms.TextBox();
            this.btnViewXMLFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "XML File:";
            // 
            // txtXMLFile
            // 
            this.txtXMLFile.Location = new System.Drawing.Point(12, 29);
            this.txtXMLFile.Name = "txtXMLFile";
            this.txtXMLFile.Size = new System.Drawing.Size(250, 22);
            this.txtXMLFile.TabIndex = 1;
            // 
            // btnBrowseXML
            // 
            this.btnBrowseXML.Location = new System.Drawing.Point(280, 29);
            this.btnBrowseXML.Name = "btnBrowseXML";
            this.btnBrowseXML.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseXML.TabIndex = 2;
            this.btnBrowseXML.Text = "Browse";
            this.btnBrowseXML.UseVisualStyleBackColor = true;
            this.btnBrowseXML.Click += new System.EventHandler(this.btnBrowseXML_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "XML File Content:";
            // 
            // txtFileContent
            // 
            this.txtFileContent.Location = new System.Drawing.Point(12, 118);
            this.txtFileContent.Multiline = true;
            this.txtFileContent.Name = "txtFileContent";
            this.txtFileContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFileContent.Size = new System.Drawing.Size(343, 264);
            this.txtFileContent.TabIndex = 4;
            // 
            // btnViewXMLFile
            // 
            this.btnViewXMLFile.Location = new System.Drawing.Point(128, 57);
            this.btnViewXMLFile.Name = "btnViewXMLFile";
            this.btnViewXMLFile.Size = new System.Drawing.Size(103, 23);
            this.btnViewXMLFile.TabIndex = 5;
            this.btnViewXMLFile.Text = "View XML File";
            this.btnViewXMLFile.UseVisualStyleBackColor = true;
            this.btnViewXMLFile.Click += new System.EventHandler(this.btnViewXMLFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 395);
            this.Controls.Add(this.btnViewXMLFile);
            this.Controls.Add(this.txtFileContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowseXML);
            this.Controls.Add(this.txtXMLFile);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtXMLFile;
        private System.Windows.Forms.Button btnBrowseXML;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFileContent;
        private System.Windows.Forms.Button btnViewXMLFile;
    }
}

