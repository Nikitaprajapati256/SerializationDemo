namespace SerializationDemo
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
            this.deptId = new System.Windows.Forms.Label();
            this.deptName = new System.Windows.Forms.Label();
            this.loction = new System.Windows.Forms.Label();
            this.txtdeptId = new System.Windows.Forms.TextBox();
            this.txtdeptName = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.btnBinaryRead = new System.Windows.Forms.Button();
            this.btnXMLWrite = new System.Windows.Forms.Button();
            this.btnXMLRead = new System.Windows.Forms.Button();
            this.btnSOAPWrite = new System.Windows.Forms.Button();
            this.btnSOAPRead = new System.Windows.Forms.Button();
            this.btnJSONWrite = new System.Windows.Forms.Button();
            this.btnJSONRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deptId
            // 
            this.deptId.AutoSize = true;
            this.deptId.Location = new System.Drawing.Point(65, 61);
            this.deptId.Name = "deptId";
            this.deptId.Size = new System.Drawing.Size(88, 16);
            this.deptId.TabIndex = 0;
            this.deptId.Text = "DepartmentId";
            // 
            // deptName
            // 
            this.deptName.AutoSize = true;
            this.deptName.Location = new System.Drawing.Point(36, 124);
            this.deptName.Name = "deptName";
            this.deptName.Size = new System.Drawing.Size(117, 16);
            this.deptName.TabIndex = 1;
            this.deptName.Text = "Department Name";
            // 
            // loction
            // 
            this.loction.AutoSize = true;
            this.loction.Location = new System.Drawing.Point(95, 193);
            this.loction.Name = "loction";
            this.loction.Size = new System.Drawing.Size(58, 16);
            this.loction.TabIndex = 2;
            this.loction.Text = "Location";
            // 
            // txtdeptId
            // 
            this.txtdeptId.Location = new System.Drawing.Point(219, 61);
            this.txtdeptId.Name = "txtdeptId";
            this.txtdeptId.Size = new System.Drawing.Size(183, 22);
            this.txtdeptId.TabIndex = 3;
            // 
            // txtdeptName
            // 
            this.txtdeptName.Location = new System.Drawing.Point(219, 118);
            this.txtdeptName.Name = "txtdeptName";
            this.txtdeptName.Size = new System.Drawing.Size(183, 22);
            this.txtdeptName.TabIndex = 4;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(219, 187);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(183, 22);
            this.txtLocation.TabIndex = 5;
            // 
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.Location = new System.Drawing.Point(100, 287);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(100, 41);
            this.btnBinaryWrite.TabIndex = 6;
            this.btnBinaryWrite.Text = "BinaryWrite";
            this.btnBinaryWrite.UseVisualStyleBackColor = true;
            this.btnBinaryWrite.Click += new System.EventHandler(this.btnBinaryWrite_Click);
            // 
            // btnBinaryRead
            // 
            this.btnBinaryRead.Location = new System.Drawing.Point(307, 287);
            this.btnBinaryRead.Name = "btnBinaryRead";
            this.btnBinaryRead.Size = new System.Drawing.Size(106, 41);
            this.btnBinaryRead.TabIndex = 7;
            this.btnBinaryRead.Text = "BinaryRead";
            this.btnBinaryRead.UseVisualStyleBackColor = true;
            this.btnBinaryRead.Click += new System.EventHandler(this.btnBinaryRead_Click);
            // 
            // btnXMLWrite
            // 
            this.btnXMLWrite.Location = new System.Drawing.Point(100, 343);
            this.btnXMLWrite.Name = "btnXMLWrite";
            this.btnXMLWrite.Size = new System.Drawing.Size(100, 39);
            this.btnXMLWrite.TabIndex = 8;
            this.btnXMLWrite.Text = "XMLWrite";
            this.btnXMLWrite.UseVisualStyleBackColor = true;
            this.btnXMLWrite.Click += new System.EventHandler(this.btnXMLWrite_Click);
            // 
            // btnXMLRead
            // 
            this.btnXMLRead.Location = new System.Drawing.Point(307, 343);
            this.btnXMLRead.Name = "btnXMLRead";
            this.btnXMLRead.Size = new System.Drawing.Size(106, 39);
            this.btnXMLRead.TabIndex = 9;
            this.btnXMLRead.Text = "XMLRead";
            this.btnXMLRead.UseVisualStyleBackColor = true;
            this.btnXMLRead.Click += new System.EventHandler(this.btnXMLRead_Click);
            // 
            // btnSOAPWrite
            // 
            this.btnSOAPWrite.Location = new System.Drawing.Point(100, 401);
            this.btnSOAPWrite.Name = "btnSOAPWrite";
            this.btnSOAPWrite.Size = new System.Drawing.Size(100, 41);
            this.btnSOAPWrite.TabIndex = 10;
            this.btnSOAPWrite.Text = "SOAPWrite";
            this.btnSOAPWrite.UseVisualStyleBackColor = true;
            this.btnSOAPWrite.Click += new System.EventHandler(this.btnSOAPWrite_Click);
            // 
            // btnSOAPRead
            // 
            this.btnSOAPRead.Location = new System.Drawing.Point(307, 401);
            this.btnSOAPRead.Name = "btnSOAPRead";
            this.btnSOAPRead.Size = new System.Drawing.Size(106, 41);
            this.btnSOAPRead.TabIndex = 11;
            this.btnSOAPRead.Text = "SOAPRead";
            this.btnSOAPRead.UseVisualStyleBackColor = true;
            this.btnSOAPRead.Click += new System.EventHandler(this.btnSOAPRead_Click);
            // 
            // btnJSONWrite
            // 
            this.btnJSONWrite.Location = new System.Drawing.Point(100, 461);
            this.btnJSONWrite.Name = "btnJSONWrite";
            this.btnJSONWrite.Size = new System.Drawing.Size(100, 37);
            this.btnJSONWrite.TabIndex = 12;
            this.btnJSONWrite.Text = "JSONWrite";
            this.btnJSONWrite.UseVisualStyleBackColor = true;
            this.btnJSONWrite.Click += new System.EventHandler(this.btnJSONWrite_Click);
            // 
            // btnJSONRead
            // 
            this.btnJSONRead.Location = new System.Drawing.Point(307, 461);
            this.btnJSONRead.Name = "btnJSONRead";
            this.btnJSONRead.Size = new System.Drawing.Size(106, 37);
            this.btnJSONRead.TabIndex = 13;
            this.btnJSONRead.Text = "JSONRead";
            this.btnJSONRead.UseVisualStyleBackColor = true;
            this.btnJSONRead.Click += new System.EventHandler(this.btnJSONRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 544);
            this.Controls.Add(this.btnJSONRead);
            this.Controls.Add(this.btnJSONWrite);
            this.Controls.Add(this.btnSOAPRead);
            this.Controls.Add(this.btnSOAPWrite);
            this.Controls.Add(this.btnXMLRead);
            this.Controls.Add(this.btnXMLWrite);
            this.Controls.Add(this.btnBinaryRead);
            this.Controls.Add(this.btnBinaryWrite);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtdeptName);
            this.Controls.Add(this.txtdeptId);
            this.Controls.Add(this.loction);
            this.Controls.Add(this.deptName);
            this.Controls.Add(this.deptId);
            this.Name = "Form1";
            this.Text = "Serialization Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deptId;
        private System.Windows.Forms.Label deptName;
        private System.Windows.Forms.Label loction;
        private System.Windows.Forms.TextBox txtdeptId;
        private System.Windows.Forms.TextBox txtdeptName;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnBinaryWrite;
        private System.Windows.Forms.Button btnBinaryRead;
        private System.Windows.Forms.Button btnXMLWrite;
        private System.Windows.Forms.Button btnXMLRead;
        private System.Windows.Forms.Button btnSOAPWrite;
        private System.Windows.Forms.Button btnSOAPRead;
        private System.Windows.Forms.Button btnJSONWrite;
        private System.Windows.Forms.Button btnJSONRead;
    }
}

