namespace SLVP_Aflevering1_v2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbDelPos = new System.Windows.Forms.TextBox();
            this.btnDelPos = new System.Windows.Forms.Button();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblDelPos = new System.Windows.Forms.Label();
            this.lblArray = new System.Windows.Forms.Label();
            this.btnArrayDel = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnRevSort = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.lblList = new System.Windows.Forms.Label();
            this.btnAutoSort = new System.Windows.Forms.Button();
            this.dgvArray = new System.Windows.Forms.DataGridView();
            this.dgvList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAdd
            // 
            this.tbAdd.Location = new System.Drawing.Point(105, 34);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(100, 20);
            this.tbAdd.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(105, 61);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add name";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbDelPos
            // 
            this.tbDelPos.Location = new System.Drawing.Point(105, 130);
            this.tbDelPos.Name = "tbDelPos";
            this.tbDelPos.Size = new System.Drawing.Size(100, 20);
            this.tbDelPos.TabIndex = 1;
            // 
            // btnDelPos
            // 
            this.btnDelPos.Location = new System.Drawing.Point(105, 156);
            this.btnDelPos.Name = "btnDelPos";
            this.btnDelPos.Size = new System.Drawing.Size(85, 23);
            this.btnDelPos.TabIndex = 3;
            this.btnDelPos.Text = "Delete position";
            this.btnDelPos.UseVisualStyleBackColor = true;
            this.btnDelPos.Click += new System.EventHandler(this.btnDelPos_Click);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(66, 34);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(38, 13);
            this.lblAdd.TabIndex = 7;
            this.lblAdd.Text = "Name:";
            // 
            // lblDelPos
            // 
            this.lblDelPos.AutoSize = true;
            this.lblDelPos.Location = new System.Drawing.Point(55, 133);
            this.lblDelPos.Name = "lblDelPos";
            this.lblDelPos.Size = new System.Drawing.Size(47, 13);
            this.lblDelPos.TabIndex = 8;
            this.lblDelPos.Text = "Position:";
            // 
            // lblArray
            // 
            this.lblArray.AutoSize = true;
            this.lblArray.Location = new System.Drawing.Point(258, 33);
            this.lblArray.Name = "lblArray";
            this.lblArray.Size = new System.Drawing.Size(42, 13);
            this.lblArray.TabIndex = 9;
            this.lblArray.Text = "Navne:";
            // 
            // btnArrayDel
            // 
            this.btnArrayDel.Location = new System.Drawing.Point(494, 49);
            this.btnArrayDel.Name = "btnArrayDel";
            this.btnArrayDel.Size = new System.Drawing.Size(96, 23);
            this.btnArrayDel.TabIndex = 12;
            this.btnArrayDel.Text = "Delete selected";
            this.btnArrayDel.UseVisualStyleBackColor = true;
            this.btnArrayDel.Click += new System.EventHandler(this.btnArrayDel_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(494, 94);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(96, 23);
            this.btnSort.TabIndex = 13;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnRevSort
            // 
            this.btnRevSort.Location = new System.Drawing.Point(494, 123);
            this.btnRevSort.Name = "btnRevSort";
            this.btnRevSort.Size = new System.Drawing.Size(96, 23);
            this.btnRevSort.TabIndex = 14;
            this.btnRevSort.Text = "Sort reversed";
            this.btnRevSort.UseVisualStyleBackColor = true;
            this.btnRevSort.Click += new System.EventHandler(this.btnRevSort_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(332, 424);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(42, 13);
            this.lblOutput.TabIndex = 16;
            this.lblOutput.Text = "Output:";
            // 
            // tbOutput
            // 
            this.tbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutput.Location = new System.Drawing.Point(380, 422);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(291, 17);
            this.tbOutput.TabIndex = 17;
            this.tbOutput.Text = "Shows if last operation was a success or an error.";
            this.tbOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(593, 33);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(42, 13);
            this.lblList.TabIndex = 18;
            this.lblList.Text = "Navne:";
            // 
            // btnAutoSort
            // 
            this.btnAutoSort.Location = new System.Drawing.Point(494, 152);
            this.btnAutoSort.Name = "btnAutoSort";
            this.btnAutoSort.Size = new System.Drawing.Size(96, 27);
            this.btnAutoSort.TabIndex = 19;
            this.btnAutoSort.Text = "Autosort: yes";
            this.btnAutoSort.UseVisualStyleBackColor = true;
            this.btnAutoSort.Click += new System.EventHandler(this.btnAutoSort_Click);
            // 
            // dgvArray
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArray.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArray.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArray.Location = new System.Drawing.Point(261, 49);
            this.dgvArray.Name = "dgvArray";
            this.dgvArray.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArray.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArray.Size = new System.Drawing.Size(216, 276);
            this.dgvArray.TabIndex = 20;
            this.dgvArray.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArray_CellContentClick);
            // 
            // dgvList
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvList.Location = new System.Drawing.Point(597, 50);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvList.Size = new System.Drawing.Size(216, 276);
            this.dgvList.TabIndex = 21;
            this.dgvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 508);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.dgvArray);
            this.Controls.Add(this.btnAutoSort);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnRevSort);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnArrayDel);
            this.Controls.Add(this.lblArray);
            this.Controls.Add(this.lblDelPos);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.btnDelPos);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbDelPos);
            this.Controls.Add(this.tbAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbDelPos;
        private System.Windows.Forms.Button btnDelPos;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblDelPos;
        private System.Windows.Forms.Label lblArray;
        private System.Windows.Forms.Button btnArrayDel;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnRevSort;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Button btnAutoSort;
        private System.Windows.Forms.DataGridView dgvArray;
        private System.Windows.Forms.DataGridView dgvList;
    }
}

