
namespace Ticketing_System
{
    partial class AddPrice
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GroupCount = new System.Windows.Forms.ComboBox();
            this.Duration = new System.Windows.Forms.ComboBox();
            this.childWeekend = new System.Windows.Forms.TextBox();
            this.childWeek = new System.Windows.Forms.TextBox();
            this.AdultWeekend = new System.Windows.Forms.TextBox();
            this.Adultweek = new System.Windows.Forms.TextBox();
            this.Agedweekend = new System.Windows.Forms.TextBox();
            this.Agedweek = new System.Windows.Forms.TextBox();
            this.btnPriceSave = new System.Windows.Forms.Button();
            this.pricedata = new System.Windows.Forms.DataGridView();
            this.btnedit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pricedata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(54, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(54, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duration";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(54, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Child";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(140, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Weekend";

            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(274, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Weekday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(54, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Adult";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(54, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Aged";
            // 
            // GroupCount
            // 
            this.GroupCount.FormattingEnabled = true;
            this.GroupCount.Items.AddRange(new object[] {
            "1",
            "2",
            "5",
            "10",
            "15"});
            this.GroupCount.Location = new System.Drawing.Point(144, 66);
            this.GroupCount.Name = "GroupCount";
            this.GroupCount.Size = new System.Drawing.Size(121, 24);
            this.GroupCount.TabIndex = 8;
            // 
            // Duration
            // 
            this.Duration.FormattingEnabled = true;
            this.Duration.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "4>"});
            this.Duration.Location = new System.Drawing.Point(144, 110);
            this.Duration.Name = "Duration";
            this.Duration.Size = new System.Drawing.Size(121, 24);
            this.Duration.TabIndex = 9;
            // 
            // childWeekend
            // 
            this.childWeekend.Location = new System.Drawing.Point(129, 245);
            this.childWeekend.Name = "childWeekend";
            this.childWeekend.Size = new System.Drawing.Size(100, 22);
            this.childWeekend.TabIndex = 10;
            // 
            // childWeek
            // 
            this.childWeek.Location = new System.Drawing.Point(278, 244);
            this.childWeek.Name = "childWeek";
            this.childWeek.Size = new System.Drawing.Size(100, 22);
            this.childWeek.TabIndex = 11;
            // 
            // AdultWeekend
            // 
            this.AdultWeekend.Location = new System.Drawing.Point(129, 296);
            this.AdultWeekend.Name = "AdultWeekend";
            this.AdultWeekend.Size = new System.Drawing.Size(100, 22);
            this.AdultWeekend.TabIndex = 12;
            // 
            // Adultweek
            // 
            this.Adultweek.Location = new System.Drawing.Point(278, 296);
            this.Adultweek.Name = "Adultweek";
            this.Adultweek.Size = new System.Drawing.Size(100, 22);
            this.Adultweek.TabIndex = 13;
            // 
            // Agedweekend
            // 
            this.Agedweekend.Location = new System.Drawing.Point(129, 344);
            this.Agedweekend.Name = "Agedweekend";
            this.Agedweekend.Size = new System.Drawing.Size(100, 22);
            this.Agedweekend.TabIndex = 14;
            // 
            // Agedweek
            // 
            this.Agedweek.Location = new System.Drawing.Point(278, 346);
            this.Agedweek.Name = "Agedweek";
            this.Agedweek.Size = new System.Drawing.Size(100, 22);
            this.Agedweek.TabIndex = 15;
            // 
            // btnPriceSave
            // 
            this.btnPriceSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPriceSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPriceSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPriceSave.Location = new System.Drawing.Point(119, 399);
            this.btnPriceSave.Name = "btnPriceSave";
            this.btnPriceSave.Size = new System.Drawing.Size(99, 37);
            this.btnPriceSave.TabIndex = 16;
            this.btnPriceSave.Text = "Save";
            this.btnPriceSave.UseVisualStyleBackColor = false;
            this.btnPriceSave.Click += new System.EventHandler(this.btnPriceSave_Click);
            // 
            // pricedata
            // 
            this.pricedata.BackgroundColor = System.Drawing.Color.Silver;
            this.pricedata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pricedata.Location = new System.Drawing.Point(384, 66);
            this.pricedata.Name = "pricedata";
            this.pricedata.RowHeadersWidth = 51;
            this.pricedata.RowTemplate.Height = 24;
            this.pricedata.Size = new System.Drawing.Size(504, 370);
            this.pricedata.TabIndex = 18;
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnedit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnedit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(252, 399);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(99, 37);
            this.btnedit.TabIndex = 19;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // AddPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.pricedata);
            this.Controls.Add(this.btnPriceSave);
            this.Controls.Add(this.Agedweek);
            this.Controls.Add(this.Agedweekend);
            this.Controls.Add(this.Adultweek);
            this.Controls.Add(this.AdultWeekend);
            this.Controls.Add(this.childWeek);
            this.Controls.Add(this.childWeekend);
            this.Controls.Add(this.Duration);
            this.Controls.Add(this.GroupCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPrice";
            this.Size = new System.Drawing.Size(891, 449);
            ((System.ComponentModel.ISupportInitialize)(this.pricedata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox GroupCount;
        private System.Windows.Forms.ComboBox Duration;
        private System.Windows.Forms.TextBox childWeekend;
        private System.Windows.Forms.TextBox childWeek;
        private System.Windows.Forms.TextBox AdultWeekend;
        private System.Windows.Forms.TextBox Adultweek;
        private System.Windows.Forms.TextBox Agedweekend;
        private System.Windows.Forms.TextBox Agedweek;
        private System.Windows.Forms.Button btnPriceSave;
        private System.Windows.Forms.DataGridView pricedata;
        private System.Windows.Forms.Button btnedit;
    }
}
