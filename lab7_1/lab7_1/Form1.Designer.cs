namespace lab7_1
{
    partial class FileManipulator
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
            this.fName = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.textFName = new System.Windows.Forms.TextBox();
            this.textLName = new System.Windows.Forms.TextBox();
            this.writeTextFile = new System.Windows.Forms.Button();
            this.readTextFile = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fName.Location = new System.Drawing.Point(39, 35);
            this.fName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(57, 17);
            this.fName.TabIndex = 0;
            this.fName.Text = "FName:";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.Location = new System.Drawing.Point(39, 69);
            this.lName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(57, 17);
            this.lName.TabIndex = 1;
            this.lName.Text = "LName:";
            // 
            // textFName
            // 
            this.textFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFName.Location = new System.Drawing.Point(98, 32);
            this.textFName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textFName.Name = "textFName";
            this.textFName.Size = new System.Drawing.Size(173, 23);
            this.textFName.TabIndex = 2;
            // 
            // textLName
            // 
            this.textLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLName.Location = new System.Drawing.Point(98, 66);
            this.textLName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textLName.Name = "textLName";
            this.textLName.Size = new System.Drawing.Size(173, 23);
            this.textLName.TabIndex = 3;
            // 
            // writeTextFile
            // 
            this.writeTextFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeTextFile.Location = new System.Drawing.Point(43, 155);
            this.writeTextFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.writeTextFile.Name = "writeTextFile";
            this.writeTextFile.Size = new System.Drawing.Size(97, 58);
            this.writeTextFile.TabIndex = 4;
            this.writeTextFile.Text = "Write Text File";
            this.writeTextFile.UseVisualStyleBackColor = true;
            this.writeTextFile.Click += new System.EventHandler(this.writeTextFile_Click);
            // 
            // readTextFile
            // 
            this.readTextFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readTextFile.Location = new System.Drawing.Point(173, 155);
            this.readTextFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.readTextFile.Name = "readTextFile";
            this.readTextFile.Size = new System.Drawing.Size(97, 58);
            this.readTextFile.TabIndex = 5;
            this.readTextFile.Text = "Read Text File";
            this.readTextFile.UseVisualStyleBackColor = true;
            this.readTextFile.Click += new System.EventHandler(this.readTextFile_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(107, 287);
            this.exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(97, 34);
            this.exit.TabIndex = 6;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(43, 218);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 58);
            this.button1.TabIndex = 7;
            this.button1.Text = "Write Binary File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(173, 218);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 58);
            this.button2.TabIndex = 8;
            this.button2.Text = "Read Binary File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textAge
            // 
            this.textAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAge.Location = new System.Drawing.Point(98, 106);
            this.textAge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(173, 23);
            this.textAge.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Age:";
            // 
            // FileManipulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 332);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.readTextFile);
            this.Controls.Add(this.writeTextFile);
            this.Controls.Add(this.textLName);
            this.Controls.Add(this.textFName);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.fName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FileManipulator";
            this.Text = "Working With Files";
            this.Load += new System.EventHandler(this.FileManipulator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fName;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox textFName;
        private System.Windows.Forms.TextBox textLName;
        private System.Windows.Forms.Button writeTextFile;
        private System.Windows.Forms.Button readTextFile;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.Label label1;
    }
}

