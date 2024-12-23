namespace Project10_PostgreSQLToDoListApp
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
            this.btnList = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPriority = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbCompleted = new System.Windows.Forms.RadioButton();
            this.rdbContinue = new System.Windows.Forms.RadioButton();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAllList = new System.Windows.Forms.Button();
            this.btnCheckedList = new System.Windows.Forms.Button();
            this.btnContinueList = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "İşlem Id:";
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.Location = new System.Drawing.Point(234, 36);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(144, 23);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtId.Location = new System.Drawing.Point(80, 35);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(136, 24);
            this.txtId.TabIndex = 2;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTitle.Location = new System.Drawing.Point(80, 65);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(136, 24);
            this.txtTitle.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(32, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Başlık:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kategori:";
            // 
            // txtPriority
            // 
            this.txtPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPriority.Location = new System.Drawing.Point(80, 125);
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.Size = new System.Drawing.Size(136, 24);
            this.txtPriority.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(22, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Öncelik:";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDescription.Location = new System.Drawing.Point(80, 155);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(136, 132);
            this.txtDescription.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Açıklama:";
            // 
            // rdbCompleted
            // 
            this.rdbCompleted.AutoSize = true;
            this.rdbCompleted.Location = new System.Drawing.Point(96, 319);
            this.rdbCompleted.Name = "rdbCompleted";
            this.rdbCompleted.Size = new System.Drawing.Size(82, 17);
            this.rdbCompleted.TabIndex = 13;
            this.rdbCompleted.TabStop = true;
            this.rdbCompleted.Text = "Tamamlandı";
            this.rdbCompleted.UseVisualStyleBackColor = true;
            // 
            // rdbContinue
            // 
            this.rdbContinue.AutoSize = true;
            this.rdbContinue.Location = new System.Drawing.Point(96, 351);
            this.rdbContinue.Name = "rdbContinue";
            this.rdbContinue.Size = new System.Drawing.Size(91, 17);
            this.rdbContinue.TabIndex = 14;
            this.rdbContinue.TabStop = true;
            this.rdbContinue.Text = "Devam Ediyor";
            this.rdbContinue.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreate.Location = new System.Drawing.Point(234, 68);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(144, 23);
            this.btnCreate.TabIndex = 15;
            this.btnCreate.Text = "Oluştur";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(234, 98);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 23);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(234, 128);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAllList
            // 
            this.btnAllList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAllList.Location = new System.Drawing.Point(234, 158);
            this.btnAllList.Name = "btnAllList";
            this.btnAllList.Size = new System.Drawing.Size(144, 30);
            this.btnAllList.TabIndex = 18;
            this.btnAllList.Text = "Tüm Liste";
            this.btnAllList.UseVisualStyleBackColor = true;
            // 
            // btnCheckedList
            // 
            this.btnCheckedList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCheckedList.Location = new System.Drawing.Point(234, 194);
            this.btnCheckedList.Name = "btnCheckedList";
            this.btnCheckedList.Size = new System.Drawing.Size(144, 30);
            this.btnCheckedList.TabIndex = 19;
            this.btnCheckedList.Text = "Tamamlananlar";
            this.btnCheckedList.UseVisualStyleBackColor = true;
            // 
            // btnContinueList
            // 
            this.btnContinueList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnContinueList.Location = new System.Drawing.Point(234, 230);
            this.btnContinueList.Name = "btnContinueList";
            this.btnContinueList.Size = new System.Drawing.Size(144, 30);
            this.btnContinueList.TabIndex = 20;
            this.btnContinueList.Text = "Devam Edenler";
            this.btnContinueList.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(80, 95);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(136, 26);
            this.cmbCategory.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(503, 404);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.btnContinueList);
            this.Controls.Add(this.btnCheckedList);
            this.Controls.Add(this.btnAllList);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.rdbContinue);
            this.Controls.Add(this.rdbCompleted);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPriority);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Yapılacaklar Listesi / To Do List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPriority;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbCompleted;
        private System.Windows.Forms.RadioButton rdbContinue;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAllList;
        private System.Windows.Forms.Button btnCheckedList;
        private System.Windows.Forms.Button btnContinueList;
        private System.Windows.Forms.ComboBox cmbCategory;
    }
}

