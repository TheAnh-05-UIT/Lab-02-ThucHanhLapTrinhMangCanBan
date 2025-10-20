namespace Lab02_24520115_NguyenQuangTheAnh
{
    partial class frm_Bai04
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
            this.btn_Write = new System.Windows.Forms.Button();
            this.btn_Read = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.txt_WriteName = new System.Windows.Forms.TextBox();
            this.txt_WriteId = new System.Windows.Forms.TextBox();
            this.txt_WritePhone = new System.Windows.Forms.TextBox();
            this.txt_WriteCourseOne = new System.Windows.Forms.TextBox();
            this.txt_WriteCourseTwo = new System.Windows.Forms.TextBox();
            this.txt_WriteCourseThree = new System.Windows.Forms.TextBox();
            this.txt_ReadName = new System.Windows.Forms.TextBox();
            this.txt_ReadId = new System.Windows.Forms.TextBox();
            this.txt_ReadPhone = new System.Windows.Forms.TextBox();
            this.txt_ReadCourseOne = new System.Windows.Forms.TextBox();
            this.txt_ReadCourseTwo = new System.Windows.Forms.TextBox();
            this.txt_ReadCourseThree = new System.Windows.Forms.TextBox();
            this.txt_ReadCourseAvg = new System.Windows.Forms.TextBox();
            this.lbl_WriteName = new System.Windows.Forms.Label();
            this.lbl_WriteId = new System.Windows.Forms.Label();
            this.lbl_WritePhone = new System.Windows.Forms.Label();
            this.lbl_WriteCourseOne = new System.Windows.Forms.Label();
            this.lbl_WriteCourseTwo = new System.Windows.Forms.Label();
            this.lbl_WriteCourseThree = new System.Windows.Forms.Label();
            this.lbl_ReadName = new System.Windows.Forms.Label();
            this.lbl_ReadId = new System.Windows.Forms.Label();
            this.lbl_ReadPhone = new System.Windows.Forms.Label();
            this.lbl_ReadCourseOne = new System.Windows.Forms.Label();
            this.lbl_ReadCourseTwo = new System.Windows.Forms.Label();
            this.lbl_ReadCourseThree = new System.Windows.Forms.Label();
            this.lbl_ReadCourseAvg = new System.Windows.Forms.Label();
            this.lbl_Number = new System.Windows.Forms.Label();
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Write
            // 
            this.btn_Write.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Write.Location = new System.Drawing.Point(34, 37);
            this.btn_Write.Name = "btn_Write";
            this.btn_Write.Size = new System.Drawing.Size(377, 56);
            this.btn_Write.TabIndex = 0;
            this.btn_Write.Text = "Write File";
            this.btn_Write.UseVisualStyleBackColor = true;
            this.btn_Write.Click += new System.EventHandler(this.btn_Write_Click);
            // 
            // btn_Read
            // 
            this.btn_Read.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Read.Location = new System.Drawing.Point(869, 37);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(377, 56);
            this.btn_Read.TabIndex = 1;
            this.btn_Read.Text = "Read File";
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(140, 602);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(124, 53);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(876, 622);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(110, 43);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.Location = new System.Drawing.Point(1136, 622);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(110, 43);
            this.btn_Next.TabIndex = 4;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // txt_WriteName
            // 
            this.txt_WriteName.Location = new System.Drawing.Point(175, 137);
            this.txt_WriteName.Name = "txt_WriteName";
            this.txt_WriteName.Size = new System.Drawing.Size(236, 26);
            this.txt_WriteName.TabIndex = 6;
            // 
            // txt_WriteId
            // 
            this.txt_WriteId.Location = new System.Drawing.Point(175, 207);
            this.txt_WriteId.Name = "txt_WriteId";
            this.txt_WriteId.Size = new System.Drawing.Size(236, 26);
            this.txt_WriteId.TabIndex = 7;
            // 
            // txt_WritePhone
            // 
            this.txt_WritePhone.Location = new System.Drawing.Point(175, 278);
            this.txt_WritePhone.Name = "txt_WritePhone";
            this.txt_WritePhone.Size = new System.Drawing.Size(236, 26);
            this.txt_WritePhone.TabIndex = 8;
            // 
            // txt_WriteCourseOne
            // 
            this.txt_WriteCourseOne.Location = new System.Drawing.Point(175, 346);
            this.txt_WriteCourseOne.Name = "txt_WriteCourseOne";
            this.txt_WriteCourseOne.Size = new System.Drawing.Size(236, 26);
            this.txt_WriteCourseOne.TabIndex = 9;
            // 
            // txt_WriteCourseTwo
            // 
            this.txt_WriteCourseTwo.Location = new System.Drawing.Point(175, 417);
            this.txt_WriteCourseTwo.Name = "txt_WriteCourseTwo";
            this.txt_WriteCourseTwo.Size = new System.Drawing.Size(236, 26);
            this.txt_WriteCourseTwo.TabIndex = 10;
            // 
            // txt_WriteCourseThree
            // 
            this.txt_WriteCourseThree.Location = new System.Drawing.Point(175, 485);
            this.txt_WriteCourseThree.Name = "txt_WriteCourseThree";
            this.txt_WriteCourseThree.Size = new System.Drawing.Size(236, 26);
            this.txt_WriteCourseThree.TabIndex = 11;
            // 
            // txt_ReadName
            // 
            this.txt_ReadName.Location = new System.Drawing.Point(1002, 140);
            this.txt_ReadName.Name = "txt_ReadName";
            this.txt_ReadName.Size = new System.Drawing.Size(244, 26);
            this.txt_ReadName.TabIndex = 12;
            // 
            // txt_ReadId
            // 
            this.txt_ReadId.Location = new System.Drawing.Point(1002, 206);
            this.txt_ReadId.Name = "txt_ReadId";
            this.txt_ReadId.Size = new System.Drawing.Size(244, 26);
            this.txt_ReadId.TabIndex = 13;
            // 
            // txt_ReadPhone
            // 
            this.txt_ReadPhone.Location = new System.Drawing.Point(1002, 278);
            this.txt_ReadPhone.Name = "txt_ReadPhone";
            this.txt_ReadPhone.Size = new System.Drawing.Size(244, 26);
            this.txt_ReadPhone.TabIndex = 14;
            // 
            // txt_ReadCourseOne
            // 
            this.txt_ReadCourseOne.Location = new System.Drawing.Point(1002, 344);
            this.txt_ReadCourseOne.Name = "txt_ReadCourseOne";
            this.txt_ReadCourseOne.Size = new System.Drawing.Size(244, 26);
            this.txt_ReadCourseOne.TabIndex = 15;
            // 
            // txt_ReadCourseTwo
            // 
            this.txt_ReadCourseTwo.Location = new System.Drawing.Point(1002, 418);
            this.txt_ReadCourseTwo.Name = "txt_ReadCourseTwo";
            this.txt_ReadCourseTwo.Size = new System.Drawing.Size(244, 26);
            this.txt_ReadCourseTwo.TabIndex = 16;
            // 
            // txt_ReadCourseThree
            // 
            this.txt_ReadCourseThree.Location = new System.Drawing.Point(1002, 484);
            this.txt_ReadCourseThree.Name = "txt_ReadCourseThree";
            this.txt_ReadCourseThree.Size = new System.Drawing.Size(244, 26);
            this.txt_ReadCourseThree.TabIndex = 17;
            // 
            // txt_ReadCourseAvg
            // 
            this.txt_ReadCourseAvg.Location = new System.Drawing.Point(1002, 552);
            this.txt_ReadCourseAvg.Name = "txt_ReadCourseAvg";
            this.txt_ReadCourseAvg.Size = new System.Drawing.Size(244, 26);
            this.txt_ReadCourseAvg.TabIndex = 18;
            // 
            // lbl_WriteName
            // 
            this.lbl_WriteName.AutoSize = true;
            this.lbl_WriteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WriteName.Location = new System.Drawing.Point(34, 135);
            this.lbl_WriteName.Name = "lbl_WriteName";
            this.lbl_WriteName.Size = new System.Drawing.Size(71, 26);
            this.lbl_WriteName.TabIndex = 19;
            this.lbl_WriteName.Text = "Name";
            // 
            // lbl_WriteId
            // 
            this.lbl_WriteId.AutoSize = true;
            this.lbl_WriteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WriteId.Location = new System.Drawing.Point(34, 207);
            this.lbl_WriteId.Name = "lbl_WriteId";
            this.lbl_WriteId.Size = new System.Drawing.Size(34, 26);
            this.lbl_WriteId.TabIndex = 20;
            this.lbl_WriteId.Text = "ID";
            // 
            // lbl_WritePhone
            // 
            this.lbl_WritePhone.AutoSize = true;
            this.lbl_WritePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WritePhone.Location = new System.Drawing.Point(34, 278);
            this.lbl_WritePhone.Name = "lbl_WritePhone";
            this.lbl_WritePhone.Size = new System.Drawing.Size(75, 26);
            this.lbl_WritePhone.TabIndex = 21;
            this.lbl_WritePhone.Text = "Phone";
            // 
            // lbl_WriteCourseOne
            // 
            this.lbl_WriteCourseOne.AutoSize = true;
            this.lbl_WriteCourseOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WriteCourseOne.Location = new System.Drawing.Point(34, 344);
            this.lbl_WriteCourseOne.Name = "lbl_WriteCourseOne";
            this.lbl_WriteCourseOne.Size = new System.Drawing.Size(100, 26);
            this.lbl_WriteCourseOne.TabIndex = 22;
            this.lbl_WriteCourseOne.Text = "Course 1";
            // 
            // lbl_WriteCourseTwo
            // 
            this.lbl_WriteCourseTwo.AutoSize = true;
            this.lbl_WriteCourseTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WriteCourseTwo.Location = new System.Drawing.Point(34, 415);
            this.lbl_WriteCourseTwo.Name = "lbl_WriteCourseTwo";
            this.lbl_WriteCourseTwo.Size = new System.Drawing.Size(100, 26);
            this.lbl_WriteCourseTwo.TabIndex = 23;
            this.lbl_WriteCourseTwo.Text = "Course 2";
            // 
            // lbl_WriteCourseThree
            // 
            this.lbl_WriteCourseThree.AutoSize = true;
            this.lbl_WriteCourseThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WriteCourseThree.Location = new System.Drawing.Point(34, 485);
            this.lbl_WriteCourseThree.Name = "lbl_WriteCourseThree";
            this.lbl_WriteCourseThree.Size = new System.Drawing.Size(100, 26);
            this.lbl_WriteCourseThree.TabIndex = 24;
            this.lbl_WriteCourseThree.Text = "Course 3";
            // 
            // lbl_ReadName
            // 
            this.lbl_ReadName.AutoSize = true;
            this.lbl_ReadName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReadName.Location = new System.Drawing.Point(871, 138);
            this.lbl_ReadName.Name = "lbl_ReadName";
            this.lbl_ReadName.Size = new System.Drawing.Size(71, 26);
            this.lbl_ReadName.TabIndex = 25;
            this.lbl_ReadName.Text = "Name";
            // 
            // lbl_ReadId
            // 
            this.lbl_ReadId.AutoSize = true;
            this.lbl_ReadId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReadId.Location = new System.Drawing.Point(871, 206);
            this.lbl_ReadId.Name = "lbl_ReadId";
            this.lbl_ReadId.Size = new System.Drawing.Size(34, 26);
            this.lbl_ReadId.TabIndex = 26;
            this.lbl_ReadId.Text = "ID";
            // 
            // lbl_ReadPhone
            // 
            this.lbl_ReadPhone.AutoSize = true;
            this.lbl_ReadPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReadPhone.Location = new System.Drawing.Point(871, 279);
            this.lbl_ReadPhone.Name = "lbl_ReadPhone";
            this.lbl_ReadPhone.Size = new System.Drawing.Size(75, 26);
            this.lbl_ReadPhone.TabIndex = 27;
            this.lbl_ReadPhone.Text = "Phone";
            // 
            // lbl_ReadCourseOne
            // 
            this.lbl_ReadCourseOne.AutoSize = true;
            this.lbl_ReadCourseOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReadCourseOne.Location = new System.Drawing.Point(871, 347);
            this.lbl_ReadCourseOne.Name = "lbl_ReadCourseOne";
            this.lbl_ReadCourseOne.Size = new System.Drawing.Size(100, 26);
            this.lbl_ReadCourseOne.TabIndex = 28;
            this.lbl_ReadCourseOne.Text = "Course 1";
            // 
            // lbl_ReadCourseTwo
            // 
            this.lbl_ReadCourseTwo.AutoSize = true;
            this.lbl_ReadCourseTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReadCourseTwo.Location = new System.Drawing.Point(871, 418);
            this.lbl_ReadCourseTwo.Name = "lbl_ReadCourseTwo";
            this.lbl_ReadCourseTwo.Size = new System.Drawing.Size(100, 26);
            this.lbl_ReadCourseTwo.TabIndex = 29;
            this.lbl_ReadCourseTwo.Text = "Course 2";
            // 
            // lbl_ReadCourseThree
            // 
            this.lbl_ReadCourseThree.AutoSize = true;
            this.lbl_ReadCourseThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReadCourseThree.Location = new System.Drawing.Point(871, 484);
            this.lbl_ReadCourseThree.Name = "lbl_ReadCourseThree";
            this.lbl_ReadCourseThree.Size = new System.Drawing.Size(100, 26);
            this.lbl_ReadCourseThree.TabIndex = 30;
            this.lbl_ReadCourseThree.Text = "Course 3";
            // 
            // lbl_ReadCourseAvg
            // 
            this.lbl_ReadCourseAvg.AutoSize = true;
            this.lbl_ReadCourseAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReadCourseAvg.Location = new System.Drawing.Point(871, 550);
            this.lbl_ReadCourseAvg.Name = "lbl_ReadCourseAvg";
            this.lbl_ReadCourseAvg.Size = new System.Drawing.Size(93, 26);
            this.lbl_ReadCourseAvg.TabIndex = 31;
            this.lbl_ReadCourseAvg.Text = "Average";
            // 
            // lbl_Number
            // 
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.Location = new System.Drawing.Point(1062, 635);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(18, 20);
            this.lbl_Number.TabIndex = 32;
            this.lbl_Number.Text = "1";
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.ItemHeight = 20;
            this.listBoxStudents.Location = new System.Drawing.Point(440, 51);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(403, 604);
            this.listBoxStudents.TabIndex = 34;
            // 
            // frm_Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 717);
            this.Controls.Add(this.listBoxStudents);
            this.Controls.Add(this.lbl_Number);
            this.Controls.Add(this.lbl_ReadCourseAvg);
            this.Controls.Add(this.lbl_ReadCourseThree);
            this.Controls.Add(this.lbl_ReadCourseTwo);
            this.Controls.Add(this.lbl_ReadCourseOne);
            this.Controls.Add(this.lbl_ReadPhone);
            this.Controls.Add(this.lbl_ReadId);
            this.Controls.Add(this.lbl_ReadName);
            this.Controls.Add(this.lbl_WriteCourseThree);
            this.Controls.Add(this.lbl_WriteCourseTwo);
            this.Controls.Add(this.lbl_WriteCourseOne);
            this.Controls.Add(this.lbl_WritePhone);
            this.Controls.Add(this.lbl_WriteId);
            this.Controls.Add(this.lbl_WriteName);
            this.Controls.Add(this.txt_ReadCourseAvg);
            this.Controls.Add(this.txt_ReadCourseThree);
            this.Controls.Add(this.txt_ReadCourseTwo);
            this.Controls.Add(this.txt_ReadCourseOne);
            this.Controls.Add(this.txt_ReadPhone);
            this.Controls.Add(this.txt_ReadId);
            this.Controls.Add(this.txt_ReadName);
            this.Controls.Add(this.txt_WriteCourseThree);
            this.Controls.Add(this.txt_WriteCourseTwo);
            this.Controls.Add(this.txt_WriteCourseOne);
            this.Controls.Add(this.txt_WritePhone);
            this.Controls.Add(this.txt_WriteId);
            this.Controls.Add(this.txt_WriteName);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Read);
            this.Controls.Add(this.btn_Write);
            this.Name = "frm_Bai04";
            this.Text = "FormBai04";
            this.Load += new System.EventHandler(this.frm_Bai04_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Write;
        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.TextBox txt_WriteName;
        private System.Windows.Forms.TextBox txt_WriteId;
        private System.Windows.Forms.TextBox txt_WritePhone;
        private System.Windows.Forms.TextBox txt_WriteCourseOne;
        private System.Windows.Forms.TextBox txt_WriteCourseTwo;
        private System.Windows.Forms.TextBox txt_WriteCourseThree;
        private System.Windows.Forms.TextBox txt_ReadName;
        private System.Windows.Forms.TextBox txt_ReadId;
        private System.Windows.Forms.TextBox txt_ReadPhone;
        private System.Windows.Forms.TextBox txt_ReadCourseOne;
        private System.Windows.Forms.TextBox txt_ReadCourseTwo;
        private System.Windows.Forms.TextBox txt_ReadCourseThree;
        private System.Windows.Forms.TextBox txt_ReadCourseAvg;
        private System.Windows.Forms.Label lbl_WriteName;
        private System.Windows.Forms.Label lbl_WriteId;
        private System.Windows.Forms.Label lbl_WritePhone;
        private System.Windows.Forms.Label lbl_WriteCourseOne;
        private System.Windows.Forms.Label lbl_WriteCourseTwo;
        private System.Windows.Forms.Label lbl_WriteCourseThree;
        private System.Windows.Forms.Label lbl_ReadName;
        private System.Windows.Forms.Label lbl_ReadId;
        private System.Windows.Forms.Label lbl_ReadPhone;
        private System.Windows.Forms.Label lbl_ReadCourseOne;
        private System.Windows.Forms.Label lbl_ReadCourseTwo;
        private System.Windows.Forms.Label lbl_ReadCourseThree;
        private System.Windows.Forms.Label lbl_ReadCourseAvg;
        private System.Windows.Forms.Label lbl_Number;
        private System.Windows.Forms.ListBox listBoxStudents;
    }
}