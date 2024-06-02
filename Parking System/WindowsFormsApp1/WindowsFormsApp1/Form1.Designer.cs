namespace WindowsFormsApp1
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
            this.Serctext = new System.Windows.Forms.TextBox();
            this.Searshbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textNumberPlae = new System.Windows.Forms.TextBox();
            this.textToken = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextNic = new System.Windows.Forms.TextBox();
            this.vehicleTypecom = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCler = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.Comgate = new System.Windows.Forms.ComboBox();
            this.Refechbtn = new System.Windows.Forms.Button();
            this.btnfill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Serctext
            // 
            this.Serctext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Serctext.Location = new System.Drawing.Point(410, 47);
            this.Serctext.Name = "Serctext";
            this.Serctext.Size = new System.Drawing.Size(684, 29);
            this.Serctext.TabIndex = 12;
            this.Serctext.Text = "Search Hear";
            this.Serctext.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Serctext_MouseClick);
            // 
            // Searshbtn
            // 
            this.Searshbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searshbtn.Location = new System.Drawing.Point(1111, 47);
            this.Searshbtn.Name = "Searshbtn";
            this.Searshbtn.Size = new System.Drawing.Size(125, 31);
            this.Searshbtn.TabIndex = 13;
            this.Searshbtn.Text = "Search";
            this.Searshbtn.UseVisualStyleBackColor = true;
            this.Searshbtn.Click += new System.EventHandler(this.Searshbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vehicle Number";
            // 
            // textNumberPlae
            // 
            this.textNumberPlae.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNumberPlae.Location = new System.Drawing.Point(46, 174);
            this.textNumberPlae.Name = "textNumberPlae";
            this.textNumberPlae.Size = new System.Drawing.Size(328, 29);
            this.textNumberPlae.TabIndex = 3;
            this.textNumberPlae.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textNumberPlae_KeyDown);
            this.textNumberPlae.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textNumberPlae_KeyUp);
            // 
            // textToken
            // 
            this.textToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textToken.Location = new System.Drawing.Point(46, 115);
            this.textToken.Name = "textToken";
            this.textToken.Size = new System.Drawing.Size(328, 29);
            this.textToken.TabIndex = 2;
            this.textToken.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textToken_KeyDown);
            this.textToken.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textToken_KeyUp);
            this.textToken.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.textToken_PreviewKeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Token Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "NICNumber";
            // 
            // TextNic
            // 
            this.TextNic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextNic.Location = new System.Drawing.Point(46, 255);
            this.TextNic.Name = "TextNic";
            this.TextNic.Size = new System.Drawing.Size(328, 29);
            this.TextNic.TabIndex = 4;
            this.TextNic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextNic_KeyDown);
            this.TextNic.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextNic_KeyUp);
            // 
            // vehicleTypecom
            // 
            this.vehicleTypecom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleTypecom.FormattingEnabled = true;
            this.vehicleTypecom.Items.AddRange(new object[] {
            " Moter Cycle",
            " Three Wheel",
            " Other"});
            this.vehicleTypecom.Location = new System.Drawing.Point(46, 337);
            this.vehicleTypecom.Name = "vehicleTypecom";
            this.vehicleTypecom.Size = new System.Drawing.Size(328, 32);
            this.vehicleTypecom.TabIndex = 5;
            this.vehicleTypecom.Text = "-- Select Type --";
            this.vehicleTypecom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.vehicleTypecom_KeyDown);
            this.vehicleTypecom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.vehicleTypecom_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vehicle Type";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(251, 466);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 55);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnSave_KeyUp);
            // 
            // btnCler
            // 
            this.btnCler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCler.Location = new System.Drawing.Point(54, 466);
            this.btnCler.Name = "btnCler";
            this.btnCler.Size = new System.Drawing.Size(114, 55);
            this.btnCler.TabIndex = 8;
            this.btnCler.Text = "Clear";
            this.btnCler.UseVisualStyleBackColor = true;
            this.btnCler.Click += new System.EventHandler(this.btnCler_Click);
            this.btnCler.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnCler_KeyUp);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(54, 547);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 55);
            this.button3.TabIndex = 10;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(251, 547);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 55);
            this.button4.TabIndex = 9;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(410, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(837, 487);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.VirtualMode = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "GatePass";
            // 
            // Comgate
            // 
            this.Comgate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comgate.FormattingEnabled = true;
            this.Comgate.Items.AddRange(new object[] {
            "IN",
            " OUT"});
            this.Comgate.Location = new System.Drawing.Point(46, 419);
            this.Comgate.Name = "Comgate";
            this.Comgate.Size = new System.Drawing.Size(328, 32);
            this.Comgate.TabIndex = 6;
            this.Comgate.Text = "-- Select Type --";
            this.Comgate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Comgate_KeyDown);
            this.Comgate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Comgate_KeyUp);
            // 
            // Refechbtn
            // 
            this.Refechbtn.Location = new System.Drawing.Point(240, 37);
            this.Refechbtn.Name = "Refechbtn";
            this.Refechbtn.Size = new System.Drawing.Size(134, 39);
            this.Refechbtn.TabIndex = 11;
            this.Refechbtn.Text = "Refesh";
            this.Refechbtn.UseVisualStyleBackColor = true;
            this.Refechbtn.Click += new System.EventHandler(this.Refechbtn_Click);
            // 
            // btnfill
            // 
            this.btnfill.Location = new System.Drawing.Point(46, 28);
            this.btnfill.Name = "btnfill";
            this.btnfill.Size = new System.Drawing.Size(110, 48);
            this.btnfill.TabIndex = 1;
            this.btnfill.Text = "FILL";
            this.btnfill.UseVisualStyleBackColor = true;
            this.btnfill.Click += new System.EventHandler(this.btnfill_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 627);
            this.Controls.Add(this.btnfill);
            this.Controls.Add(this.Refechbtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCler);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Comgate);
            this.Controls.Add(this.vehicleTypecom);
            this.Controls.Add(this.textToken);
            this.Controls.Add(this.TextNic);
            this.Controls.Add(this.textNumberPlae);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Searshbtn);
            this.Controls.Add(this.Serctext);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Serctext;
        private System.Windows.Forms.Button Searshbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNumberPlae;
        private System.Windows.Forms.TextBox textToken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextNic;
        private System.Windows.Forms.ComboBox vehicleTypecom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCler;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Comgate;
        private System.Windows.Forms.Button Refechbtn;
        private System.Windows.Forms.Button btnfill;
    }
}

