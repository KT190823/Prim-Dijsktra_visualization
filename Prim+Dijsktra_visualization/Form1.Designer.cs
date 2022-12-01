namespace Prim_Dijsktra_visualization
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Inputgraphtb = new System.Windows.Forms.TextBox();
            this.PictureBoard = new System.Windows.Forms.Panel();
            this.ReadGraphbtn = new System.Windows.Forms.Button();
            this.Primbtn = new System.Windows.Forms.Button();
            this.Dijsktrabtn = new System.Windows.Forms.Button();
            this.Resetbtn = new System.Windows.Forms.Button();
            this.Clearallbtn = new System.Windows.Forms.Button();
            this.Directedgraphtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Moreoutputlabel = new System.Windows.Forms.Label();
            this.Moreoutputtb = new System.Windows.Forms.TextBox();
            this.startnode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.delaytime = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUploadFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Inputgraphtb
            // 
            this.Inputgraphtb.BackColor = System.Drawing.Color.White;
            this.Inputgraphtb.Location = new System.Drawing.Point(45, 88);
            this.Inputgraphtb.Multiline = true;
            this.Inputgraphtb.Name = "Inputgraphtb";
            this.Inputgraphtb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Inputgraphtb.Size = new System.Drawing.Size(217, 182);
            this.Inputgraphtb.TabIndex = 0;
            // 
            // PictureBoard
            // 
            this.PictureBoard.BackColor = System.Drawing.Color.White;
            this.PictureBoard.Location = new System.Drawing.Point(635, 88);
            this.PictureBoard.Name = "PictureBoard";
            this.PictureBoard.Size = new System.Drawing.Size(639, 551);
            this.PictureBoard.TabIndex = 1;
            this.PictureBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoard_MouseClick);
            // 
            // ReadGraphbtn
            // 
            this.ReadGraphbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ReadGraphbtn.Location = new System.Drawing.Point(45, 296);
            this.ReadGraphbtn.Name = "ReadGraphbtn";
            this.ReadGraphbtn.Size = new System.Drawing.Size(138, 39);
            this.ReadGraphbtn.TabIndex = 2;
            this.ReadGraphbtn.Text = "Read graph";
            this.ReadGraphbtn.UseVisualStyleBackColor = false;
            this.ReadGraphbtn.Click += new System.EventHandler(this.ReadGraphbtn_Click);
            // 
            // Primbtn
            // 
            this.Primbtn.BackColor = System.Drawing.Color.Red;
            this.Primbtn.Location = new System.Drawing.Point(477, 394);
            this.Primbtn.Name = "Primbtn";
            this.Primbtn.Size = new System.Drawing.Size(152, 48);
            this.Primbtn.TabIndex = 3;
            this.Primbtn.Text = "Prim";
            this.Primbtn.UseVisualStyleBackColor = false;
            this.Primbtn.Click += new System.EventHandler(this.Primbtn_Click);
            // 
            // Dijsktrabtn
            // 
            this.Dijsktrabtn.BackColor = System.Drawing.Color.Lime;
            this.Dijsktrabtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Dijsktrabtn.Location = new System.Drawing.Point(480, 458);
            this.Dijsktrabtn.Name = "Dijsktrabtn";
            this.Dijsktrabtn.Size = new System.Drawing.Size(152, 48);
            this.Dijsktrabtn.TabIndex = 4;
            this.Dijsktrabtn.Text = "Dijkstra";
            this.Dijsktrabtn.UseVisualStyleBackColor = false;
            this.Dijsktrabtn.Click += new System.EventHandler(this.Dijsktrabtn_Click);
            // 
            // Resetbtn
            // 
            this.Resetbtn.BackColor = System.Drawing.Color.Gray;
            this.Resetbtn.ForeColor = System.Drawing.Color.White;
            this.Resetbtn.Location = new System.Drawing.Point(480, 527);
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.Size = new System.Drawing.Size(152, 48);
            this.Resetbtn.TabIndex = 5;
            this.Resetbtn.Text = "Reset";
            this.Resetbtn.UseVisualStyleBackColor = false;
            this.Resetbtn.Click += new System.EventHandler(this.Resetbtn_Click);
            // 
            // Clearallbtn
            // 
            this.Clearallbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Clearallbtn.ForeColor = System.Drawing.Color.White;
            this.Clearallbtn.Location = new System.Drawing.Point(480, 591);
            this.Clearallbtn.Name = "Clearallbtn";
            this.Clearallbtn.Size = new System.Drawing.Size(152, 48);
            this.Clearallbtn.TabIndex = 6;
            this.Clearallbtn.Text = "Clear all";
            this.Clearallbtn.UseVisualStyleBackColor = false;
            this.Clearallbtn.Click += new System.EventHandler(this.Clearallbtn_Click);
            // 
            // Directedgraphtb
            // 
            this.Directedgraphtb.BackColor = System.Drawing.Color.White;
            this.Directedgraphtb.Location = new System.Drawing.Point(407, 308);
            this.Directedgraphtb.Name = "Directedgraphtb";
            this.Directedgraphtb.Size = new System.Drawing.Size(67, 27);
            this.Directedgraphtb.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Input graph";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(635, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Picture Board";
            // 
            // Moreoutputlabel
            // 
            this.Moreoutputlabel.AutoSize = true;
            this.Moreoutputlabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Moreoutputlabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Moreoutputlabel.Location = new System.Drawing.Point(270, 56);
            this.Moreoutputlabel.Name = "Moreoutputlabel";
            this.Moreoutputlabel.Size = new System.Drawing.Size(124, 28);
            this.Moreoutputlabel.TabIndex = 9;
            this.Moreoutputlabel.Text = "More output";
            // 
            // Moreoutputtb
            // 
            this.Moreoutputtb.BackColor = System.Drawing.Color.White;
            this.Moreoutputtb.Location = new System.Drawing.Point(270, 88);
            this.Moreoutputtb.Multiline = true;
            this.Moreoutputtb.Name = "Moreoutputtb";
            this.Moreoutputtb.Size = new System.Drawing.Size(202, 182);
            this.Moreoutputtb.TabIndex = 11;
            // 
            // startnode
            // 
            this.startnode.BackColor = System.Drawing.Color.Lime;
            this.startnode.FormattingEnabled = true;
            this.startnode.Location = new System.Drawing.Point(407, 478);
            this.startnode.Name = "startnode";
            this.startnode.Size = new System.Drawing.Size(67, 28);
            this.startnode.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(405, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Start node";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(251, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "Directed graph";
            // 
            // delaytime
            // 
            this.delaytime.FormattingEnabled = true;
            this.delaytime.Items.AddRange(new object[] {
            "0.2",
            "1",
            "2",
            "3"});
            this.delaytime.Location = new System.Drawing.Point(407, 359);
            this.delaytime.Name = "delaytime";
            this.delaytime.Size = new System.Drawing.Size(67, 28);
            this.delaytime.TabIndex = 16;
            this.delaytime.SelectedIndexChanged += new System.EventHandler(this.delaytime_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(251, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 28);
            this.label6.TabIndex = 17;
            this.label6.Text = "Delay time(sec)";
            // 
            // btnUploadFile
            // 
            this.btnUploadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUploadFile.Location = new System.Drawing.Point(45, 341);
            this.btnUploadFile.Name = "btnUploadFile";
            this.btnUploadFile.Size = new System.Drawing.Size(138, 46);
            this.btnUploadFile.TabIndex = 19;
            this.btnUploadFile.Text = "Upload file graph";
            this.btnUploadFile.UseVisualStyleBackColor = false;
            this.btnUploadFile.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1317, 677);
            this.Controls.Add(this.btnUploadFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.delaytime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startnode);
            this.Controls.Add(this.Moreoutputtb);
            this.Controls.Add(this.Moreoutputlabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Directedgraphtb);
            this.Controls.Add(this.Clearallbtn);
            this.Controls.Add(this.Resetbtn);
            this.Controls.Add(this.Dijsktrabtn);
            this.Controls.Add(this.Primbtn);
            this.Controls.Add(this.ReadGraphbtn);
            this.Controls.Add(this.PictureBoard);
            this.Controls.Add(this.Inputgraphtb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Inputgraphtb;
        private Panel PictureBoard;
        private Button ReadGraphbtn;
        private Button Primbtn;
        private Button Dijsktrabtn;
        private Button Resetbtn;
        private Button Clearallbtn;
        private TextBox Directedgraphtb;
        private Label label2;
        private Label label4;
        private Label Moreoutputlabel;
        private TextBox Moreoutputtb;
        private ComboBox startnode;
        private Label label1;
        private Label label5;
        private ComboBox delaytime;
        private Label label6;
        private Button btnUploadFile;
    }
}