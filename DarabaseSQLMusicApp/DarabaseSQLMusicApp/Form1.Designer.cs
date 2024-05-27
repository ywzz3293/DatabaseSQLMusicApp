namespace DarabaseSQLMusicApp
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            button3 = new Button();
            txt_description = new TextBox();
            txt_artist = new TextBox();
            txt_year = new TextBox();
            txt_imageURL = new TextBox();
            txt_name = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            dataGridView2 = new DataGridView();
            button4 = new Button();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(267, 11);
            button1.Name = "button1";
            button1.Size = new Size(132, 29);
            button1.TabIndex = 0;
            button1.Text = "Load Albums";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(267, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(801, 210);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button2
            // 
            button2.Location = new Point(647, 12);
            button2.Name = "button2";
            button2.Size = new Size(86, 29);
            button2.TabIndex = 2;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(435, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 27);
            textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(27, 295);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(txt_description);
            groupBox1.Controls.Add(txt_artist);
            groupBox1.Controls.Add(txt_year);
            groupBox1.Controls.Add(txt_imageURL);
            groupBox1.Controls.Add(txt_name);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 259);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Album";
            // 
            // button3
            // 
            button3.Location = new Point(79, 221);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 10;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txt_description
            // 
            txt_description.Location = new Point(106, 179);
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(125, 27);
            txt_description.TabIndex = 9;
            // 
            // txt_artist
            // 
            txt_artist.Location = new Point(106, 71);
            txt_artist.Name = "txt_artist";
            txt_artist.Size = new Size(125, 27);
            txt_artist.TabIndex = 8;
            // 
            // txt_year
            // 
            txt_year.Location = new Point(106, 107);
            txt_year.Name = "txt_year";
            txt_year.Size = new Size(125, 27);
            txt_year.TabIndex = 7;
            // 
            // txt_imageURL
            // 
            txt_imageURL.Location = new Point(106, 143);
            txt_imageURL.Name = "txt_imageURL";
            txt_imageURL.Size = new Size(125, 27);
            txt_imageURL.TabIndex = 6;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(106, 35);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(125, 27);
            txt_name.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 31);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 4;
            label5.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 183);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 3;
            label4.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 145);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "ImageUrl";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 107);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 1;
            label2.Text = "Year";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 69);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 0;
            label1.Text = "Artist";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(267, 274);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 6;
            label6.Text = "Tracks";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(270, 295);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(494, 151);
            dataGridView2.TabIndex = 7;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // button4
            // 
            button4.Location = new Point(270, 452);
            button4.Name = "button4";
            button4.Size = new Size(129, 29);
            button4.TabIndex = 8;
            button4.Text = "Delete Track";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(804, 298);
            webView21.Name = "webView21";
            webView21.Size = new Size(264, 148);
            webView21.TabIndex = 9;
            webView21.ZoomFactor = 1D;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 518);
            Controls.Add(webView21);
            Controls.Add(button4);
            Controls.Add(dataGridView2);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private TextBox txt_description;
        private TextBox txt_artist;
        private TextBox txt_year;
        private TextBox txt_imageURL;
        private TextBox txt_name;
        private Label label5;
        private Button button3;
        private Label label6;
        private DataGridView dataGridView2;
        private Button button4;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}
