
namespace Ticketing_System
{
    partial class Exit_Visitor
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
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtOutTime = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.VisitorsExitDataGrid = new System.Windows.Forms.DataGridView();
            this.txtVisitorsID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVisitorExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VisitorsExitDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exit Visitor";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(177, 244);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(143, 22);
            this.txtDuration.TabIndex = 23;
            // 
            // txtOutTime
            // 
            this.txtOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.txtOutTime.Location = new System.Drawing.Point(178, 112);
            this.txtOutTime.Name = "txtOutTime";
            this.txtOutTime.ShowUpDown = true;
            this.txtOutTime.Size = new System.Drawing.Size(143, 22);
            this.txtOutTime.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(40, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Out-Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Duration";
            // 
            // VisitorsExitDataGrid
            // 
            this.VisitorsExitDataGrid.AllowUserToDeleteRows = false;
            this.VisitorsExitDataGrid.BackgroundColor = System.Drawing.Color.Silver;
            this.VisitorsExitDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VisitorsExitDataGrid.Location = new System.Drawing.Point(332, 64);
            this.VisitorsExitDataGrid.Name = "VisitorsExitDataGrid";
            this.VisitorsExitDataGrid.RowHeadersWidth = 51;
            this.VisitorsExitDataGrid.RowTemplate.Height = 24;
            this.VisitorsExitDataGrid.Size = new System.Drawing.Size(556, 353);
            this.VisitorsExitDataGrid.TabIndex = 26;
            // 
            // txtVisitorsID
            // 
            this.txtVisitorsID.Location = new System.Drawing.Point(178, 73);
            this.txtVisitorsID.Name = "txtVisitorsID";
            this.txtVisitorsID.Size = new System.Drawing.Size(143, 22);
            this.txtVisitorsID.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Visitor\'s ID";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(177, 281);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(143, 22);
            this.txtPrice.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Price";
            // 
            // btnVisitorExit
            // 
            this.btnVisitorExit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVisitorExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisitorExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitorExit.Location = new System.Drawing.Point(178, 326);
            this.btnVisitorExit.Name = "btnVisitorExit";
            this.btnVisitorExit.Size = new System.Drawing.Size(143, 40);
            this.btnVisitorExit.TabIndex = 29;
            this.btnVisitorExit.Text = "Exit User";
            this.btnVisitorExit.UseVisualStyleBackColor = false;
            this.btnVisitorExit.Click += new System.EventHandler(this.btnVisitorExit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(178, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 40);
            this.button1.TabIndex = 30;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exit_Visitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVisitorExit);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.VisitorsExitDataGrid);
            this.Controls.Add(this.txtVisitorsID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtOutTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "Exit_Visitor";
            this.Size = new System.Drawing.Size(891, 449);
            ((System.ComponentModel.ISupportInitialize)(this.VisitorsExitDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.DateTimePicker txtOutTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView VisitorsExitDataGrid;
        private System.Windows.Forms.TextBox txtVisitorsID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVisitorExit;
        private System.Windows.Forms.Button button1;
    }
}
