namespace WinFormsApp3
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            imie = new TextBox();
            label2 = new Label();
            nazwisko = new TextBox();
            listBox1 = new ListBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            ilosc = new TextBox();
            litery = new RadioButton();
            cyfry = new RadioButton();
            znaki = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 150);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(imie, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(nazwisko, 1, 1);
            tableLayoutPanel1.Controls.Add(listBox1, 0, 2);
            tableLayoutPanel1.Location = new Point(8, 8);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(300, 150);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(45, 25);
            label1.TabIndex = 0;
            label1.Text = "imię";
            // 
            // imie
            // 
            imie.Location = new Point(93, 3);
            imie.Name = "imie";
            imie.Size = new Size(150, 31);
            imie.TabIndex = 1;
            imie.Text = "imię";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 37);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 2;
            label2.Text = "nazwisko";
            // 
            // nazwisko
            // 
            nazwisko.Location = new Point(93, 40);
            nazwisko.Name = "nazwisko";
            nazwisko.Size = new Size(150, 31);
            nazwisko.TabIndex = 3;
            nazwisko.Text = "nazwisko\\";
            // 
            // listBox1
            // 
            tableLayoutPanel1.SetColumnSpan(listBox1, 2);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { "kierownik", "starszy programista", "młodszy programista", "tester" });
            listBox1.Location = new Point(3, 77);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 129);
            listBox1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(ilosc);
            flowLayoutPanel1.Controls.Add(litery);
            flowLayoutPanel1.Controls.Add(cyfry);
            flowLayoutPanel1.Controls.Add(znaki);
            flowLayoutPanel1.Location = new Point(20, 189);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(432, 72);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 0;
            label3.Text = "ile znaków";
            // 
            // ilosc
            // 
            flowLayoutPanel1.SetFlowBreak(ilosc, true);
            ilosc.Location = new Point(103, 3);
            ilosc.Name = "ilosc";
            ilosc.Size = new Size(150, 31);
            ilosc.TabIndex = 1;
            ilosc.Text = "ilość znaków";
            // 
            // litery
            // 
            litery.AutoSize = true;
            litery.Checked = true;
            litery.Location = new Point(3, 40);
            litery.Name = "litery";
            litery.Size = new Size(185, 29);
            litery.TabIndex = 2;
            litery.TabStop = true;
            litery.Text = "małe i wielkie litery";
            litery.UseVisualStyleBackColor = true;
            // 
            // cyfry
            // 
            cyfry.AutoSize = true;
            cyfry.Location = new Point(194, 40);
            cyfry.Name = "cyfry";
            cyfry.Size = new Size(75, 29);
            cyfry.TabIndex = 3;
            cyfry.TabStop = true;
            cyfry.Text = "cyfry";
            cyfry.UseVisualStyleBackColor = true;
            // 
            // znaki
            // 
            znaki.AutoSize = true;
            znaki.Location = new Point(275, 40);
            znaki.Name = "znaki";
            znaki.Size = new Size(154, 29);
            znaki.TabIndex = 4;
            znaki.TabStop = true;
            znaki.Text = "znaki specjalne";
            znaki.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(20, 267);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "generuj hasło";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(28, 300);
            button2.Name = "button2";
            button2.Size = new Size(200, 34);
            button2.TabIndex = 3;
            button2.Text = "zatwierdź";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TextBox imie;
        private Label label2;
        private TextBox nazwisko;
        private ListBox listBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label3;
        private TextBox ilosc;
        private RadioButton litery;
        private RadioButton cyfry;
        private RadioButton znaki;
        private Button button1;
        private Button button2;
    }
}