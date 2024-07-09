namespace WinFormsApp2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            tamekran = new Button();
            simgedrm = new Button();
            kapat = new Button();
            panel6 = new Panel();
            BtnHistory = new Button();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            BtnPercent = new WinFormsApp3.ArtanButton();
            BtnCE = new WinFormsApp3.ArtanButton();
            BtnC = new WinFormsApp3.ArtanButton();
            BtnBackSpace = new WinFormsApp3.ArtanButton();
            Btn1X = new WinFormsApp3.ArtanButton();
            BtnX2 = new WinFormsApp3.ArtanButton();
            BtnSquare = new WinFormsApp3.ArtanButton();
            BtnDivisio = new WinFormsApp3.ArtanButton();
            Btn6 = new WinFormsApp3.ArtanButton();
            BtnMultiply = new WinFormsApp3.ArtanButton();
            BtnSubtraction = new WinFormsApp3.ArtanButton();
            Btn2 = new WinFormsApp3.ArtanButton();
            BtnPM = new WinFormsApp3.ArtanButton();
            Btn0 = new WinFormsApp3.ArtanButton();
            Btn3 = new WinFormsApp3.ArtanButton();
            BtnDesimal = new WinFormsApp3.ArtanButton();
            BtnPlus = new WinFormsApp3.ArtanButton();
            BtnEquals = new WinFormsApp3.ArtanButton();
            Btn9 = new WinFormsApp3.ArtanButton();
            Btn8 = new WinFormsApp3.ArtanButton();
            Btn5 = new WinFormsApp3.ArtanButton();
            Btn4 = new WinFormsApp3.ArtanButton();
            Btn1 = new WinFormsApp3.ArtanButton();
            Btn7 = new WinFormsApp3.ArtanButton();
            richTextBox1 = new RichTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(359, 40);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(359, 40);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(359, 40);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(tamekran);
            panel4.Controls.Add(simgedrm);
            panel4.Controls.Add(kapat);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(359, 40);
            panel4.TabIndex = 2;
            // 
            // tamekran
            // 
            tamekran.FlatAppearance.BorderSize = 0;
            tamekran.FlatAppearance.MouseOverBackColor = Color.Red;
            tamekran.FlatStyle = FlatStyle.Flat;
            tamekran.Location = new Point(255, 0);
            tamekran.Margin = new Padding(0);
            tamekran.Name = "tamekran";
            tamekran.Size = new Size(50, 40);
            tamekran.TabIndex = 2;
            tamekran.Text = "□ ";
            tamekran.UseVisualStyleBackColor = true;
            // 
            // simgedrm
            // 
            simgedrm.FlatAppearance.BorderSize = 0;
            simgedrm.FlatAppearance.MouseOverBackColor = Color.Red;
            simgedrm.FlatStyle = FlatStyle.Flat;
            simgedrm.Location = new Point(204, 0);
            simgedrm.Margin = new Padding(0);
            simgedrm.Name = "simgedrm";
            simgedrm.Size = new Size(50, 40);
            simgedrm.TabIndex = 1;
            simgedrm.Text = "-";
            simgedrm.UseVisualStyleBackColor = true;
            // 
            // kapat
            // 
            kapat.FlatAppearance.BorderSize = 0;
            kapat.FlatAppearance.MouseOverBackColor = Color.Red;
            kapat.FlatStyle = FlatStyle.Flat;
            kapat.Location = new Point(307, 0);
            kapat.Margin = new Padding(0);
            kapat.Name = "kapat";
            kapat.Size = new Size(50, 40);
            kapat.TabIndex = 0;
            kapat.Text = "X";
            kapat.UseVisualStyleBackColor = true;
            kapat.Click += kapat_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(BtnHistory);
            panel6.Location = new Point(0, 40);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(350, 40);
            panel6.TabIndex = 3;
            // 
            // BtnHistory
            // 
            BtnHistory.BackgroundImage = (Image)resources.GetObject("BtnHistory.BackgroundImage");
            BtnHistory.BackgroundImageLayout = ImageLayout.Zoom;
            BtnHistory.FlatAppearance.BorderSize = 0;
            BtnHistory.FlatAppearance.MouseOverBackColor = Color.Red;
            BtnHistory.FlatStyle = FlatStyle.Flat;
            BtnHistory.Location = new Point(266, 0);
            BtnHistory.Margin = new Padding(0);
            BtnHistory.Name = "BtnHistory";
            BtnHistory.Size = new Size(91, 40);
            BtnHistory.TabIndex = 4;
            BtnHistory.UseVisualStyleBackColor = true;
            BtnHistory.Click += BtnHistory_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(32, 32, 32);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Gadugi", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(0, 83);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(350, 45);
            textBox1.TabIndex = 4;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(32, 32, 32);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Gadugi", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = SystemColors.Window;
            textBox3.Location = new Point(-2, 110);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(350, 45);
            textBox3.TabIndex = 5;
            textBox3.Text = "0";
            textBox3.TextAlign = HorizontalAlignment.Right;
            // 
            // BtnPercent
            // 
            BtnPercent.BackColor = Color.FromArgb(50, 50, 50);
            BtnPercent.BackgroundColor = Color.FromArgb(50, 50, 50);
            BtnPercent.BackgroundImageLayout = ImageLayout.None;
            BtnPercent.BorderRadius = 20;
            BtnPercent.BorderSize = 0;
            BtnPercent.FlatAppearance.BorderSize = 0;
            BtnPercent.FlatStyle = FlatStyle.Flat;
            BtnPercent.ForeColor = Color.White;
            BtnPercent.Location = new Point(-2, 191);
            BtnPercent.Name = "BtnPercent";
            BtnPercent.Size = new Size(92, 54);
            BtnPercent.TabIndex = 6;
            BtnPercent.Text = "%";
            BtnPercent.TextColor = Color.White;
            BtnPercent.UseVisualStyleBackColor = false;
            BtnPercent.Click += BtnOperations_Click;
            // 
            // BtnCE
            // 
            BtnCE.BackColor = Color.FromArgb(50, 50, 50);
            BtnCE.BackgroundColor = Color.FromArgb(50, 50, 50);
            BtnCE.BackgroundImageLayout = ImageLayout.None;
            BtnCE.BorderRadius = 20;
            BtnCE.BorderSize = 0;
            BtnCE.FlatAppearance.BorderSize = 0;
            BtnCE.FlatStyle = FlatStyle.Flat;
            BtnCE.ForeColor = Color.White;
            BtnCE.Location = new Point(93, 191);
            BtnCE.Name = "BtnCE";
            BtnCE.Size = new Size(79, 54);
            BtnCE.TabIndex = 6;
            BtnCE.Text = "CE";
            BtnCE.TextColor = Color.White;
            BtnCE.UseVisualStyleBackColor = false;
            BtnCE.Click += BtnCE_Click;
            // 
            // BtnC
            // 
            BtnC.BackColor = Color.FromArgb(50, 50, 50);
            BtnC.BackgroundColor = Color.FromArgb(50, 50, 50);
            BtnC.BackgroundImageLayout = ImageLayout.None;
            BtnC.BorderRadius = 20;
            BtnC.BorderSize = 0;
            BtnC.FlatAppearance.BorderSize = 0;
            BtnC.FlatStyle = FlatStyle.Flat;
            BtnC.ForeColor = Color.White;
            BtnC.Location = new Point(175, 191);
            BtnC.Name = "BtnC";
            BtnC.Size = new Size(85, 54);
            BtnC.TabIndex = 6;
            BtnC.Text = "C";
            BtnC.TextColor = Color.White;
            BtnC.UseVisualStyleBackColor = false;
            BtnC.Click += BtnC_Click;
            // 
            // BtnBackSpace
            // 
            BtnBackSpace.BackColor = Color.FromArgb(50, 50, 50);
            BtnBackSpace.BackgroundColor = Color.FromArgb(50, 50, 50);
            BtnBackSpace.BackgroundImage = (Image)resources.GetObject("BtnBackSpace.BackgroundImage");
            BtnBackSpace.BackgroundImageLayout = ImageLayout.Zoom;
            BtnBackSpace.BorderRadius = 20;
            BtnBackSpace.BorderSize = 0;
            BtnBackSpace.FlatAppearance.BorderSize = 0;
            BtnBackSpace.FlatStyle = FlatStyle.Flat;
            BtnBackSpace.ForeColor = Color.White;
            BtnBackSpace.Location = new Point(263, 191);
            BtnBackSpace.Name = "BtnBackSpace";
            BtnBackSpace.Size = new Size(90, 54);
            BtnBackSpace.TabIndex = 6;
            BtnBackSpace.TextColor = Color.White;
            BtnBackSpace.UseVisualStyleBackColor = false;
            BtnBackSpace.Click += BtnBackSpace_Click;
            // 
            // Btn1X
            // 
            Btn1X.BackColor = Color.FromArgb(50, 50, 50);
            Btn1X.BackgroundColor = Color.FromArgb(50, 50, 50);
            Btn1X.BackgroundImageLayout = ImageLayout.None;
            Btn1X.BorderRadius = 20;
            Btn1X.BorderSize = 0;
            Btn1X.FlatAppearance.BorderSize = 0;
            Btn1X.FlatStyle = FlatStyle.Flat;
            Btn1X.ForeColor = Color.White;
            Btn1X.Location = new Point(-2, 251);
            Btn1X.Name = "Btn1X";
            Btn1X.Size = new Size(92, 54);
            Btn1X.TabIndex = 6;
            Btn1X.Text = "1/X";
            Btn1X.TextColor = Color.White;
            Btn1X.UseVisualStyleBackColor = false;
            Btn1X.Click += BtnOperations_Click;
            // 
            // BtnX2
            // 
            BtnX2.BackColor = Color.FromArgb(50, 50, 50);
            BtnX2.BackgroundColor = Color.FromArgb(50, 50, 50);
            BtnX2.BackgroundImageLayout = ImageLayout.None;
            BtnX2.BorderRadius = 20;
            BtnX2.BorderSize = 0;
            BtnX2.FlatAppearance.BorderSize = 0;
            BtnX2.FlatStyle = FlatStyle.Flat;
            BtnX2.ForeColor = Color.White;
            BtnX2.Location = new Point(93, 251);
            BtnX2.Name = "BtnX2";
            BtnX2.Size = new Size(79, 54);
            BtnX2.TabIndex = 6;
            BtnX2.Text = "x²";
            BtnX2.TextColor = Color.White;
            BtnX2.UseVisualStyleBackColor = false;
            BtnX2.Click += BtnOperations_Click;
            // 
            // BtnSquare
            // 
            BtnSquare.BackColor = Color.FromArgb(50, 50, 50);
            BtnSquare.BackgroundColor = Color.FromArgb(50, 50, 50);
            BtnSquare.BackgroundImageLayout = ImageLayout.None;
            BtnSquare.BorderRadius = 20;
            BtnSquare.BorderSize = 0;
            BtnSquare.FlatAppearance.BorderSize = 0;
            BtnSquare.FlatStyle = FlatStyle.Flat;
            BtnSquare.ForeColor = Color.White;
            BtnSquare.Location = new Point(175, 251);
            BtnSquare.Name = "BtnSquare";
            BtnSquare.Size = new Size(85, 54);
            BtnSquare.TabIndex = 6;
            BtnSquare.Text = " √x";
            BtnSquare.TextColor = Color.White;
            BtnSquare.UseVisualStyleBackColor = false;
            BtnSquare.Click += BtnOperations_Click;
            // 
            // BtnDivisio
            // 
            BtnDivisio.BackColor = Color.FromArgb(50, 50, 50);
            BtnDivisio.BackgroundColor = Color.FromArgb(50, 50, 50);
            BtnDivisio.BackgroundImageLayout = ImageLayout.None;
            BtnDivisio.BorderRadius = 20;
            BtnDivisio.BorderSize = 0;
            BtnDivisio.FlatAppearance.BorderSize = 0;
            BtnDivisio.FlatStyle = FlatStyle.Flat;
            BtnDivisio.ForeColor = Color.White;
            BtnDivisio.Location = new Point(263, 251);
            BtnDivisio.Name = "BtnDivisio";
            BtnDivisio.Size = new Size(90, 54);
            BtnDivisio.TabIndex = 6;
            BtnDivisio.Text = "÷ ";
            BtnDivisio.TextColor = Color.White;
            BtnDivisio.UseVisualStyleBackColor = false;
            BtnDivisio.Click += BtnMathOpperation_Click;
            // 
            // Btn6
            // 
            Btn6.BackColor = Color.FromArgb(60, 60, 60);
            Btn6.BackgroundColor = Color.FromArgb(60, 60, 60);
            Btn6.BackgroundImageLayout = ImageLayout.None;
            Btn6.BorderRadius = 20;
            Btn6.BorderSize = -1;
            Btn6.FlatAppearance.BorderSize = 0;
            Btn6.FlatStyle = FlatStyle.Flat;
            Btn6.ForeColor = Color.White;
            Btn6.Location = new Point(179, 371);
            Btn6.Name = "Btn6";
            Btn6.Size = new Size(85, 54);
            Btn6.TabIndex = 6;
            Btn6.Text = "6";
            Btn6.TextColor = Color.White;
            Btn6.UseVisualStyleBackColor = false;
            Btn6.Click += BynNum_Click;
            // 
            // BtnMultiply
            // 
            BtnMultiply.BackColor = Color.FromArgb(50, 50, 50);
            BtnMultiply.BackgroundColor = Color.FromArgb(50, 50, 50);
            BtnMultiply.BackgroundImageLayout = ImageLayout.None;
            BtnMultiply.BorderRadius = 20;
            BtnMultiply.BorderSize = 0;
            BtnMultiply.FlatAppearance.BorderSize = 0;
            BtnMultiply.FlatStyle = FlatStyle.Flat;
            BtnMultiply.ForeColor = Color.White;
            BtnMultiply.Location = new Point(263, 311);
            BtnMultiply.Name = "BtnMultiply";
            BtnMultiply.Size = new Size(90, 54);
            BtnMultiply.TabIndex = 6;
            BtnMultiply.Text = "×";
            BtnMultiply.TextColor = Color.White;
            BtnMultiply.UseVisualStyleBackColor = false;
            BtnMultiply.Click += BtnMathOpperation_Click;
            // 
            // BtnSubtraction
            // 
            BtnSubtraction.BackColor = Color.FromArgb(50, 50, 50);
            BtnSubtraction.BackgroundColor = Color.FromArgb(50, 50, 50);
            BtnSubtraction.BackgroundImageLayout = ImageLayout.None;
            BtnSubtraction.BorderRadius = 20;
            BtnSubtraction.BorderSize = 0;
            BtnSubtraction.FlatAppearance.BorderSize = 0;
            BtnSubtraction.FlatStyle = FlatStyle.Flat;
            BtnSubtraction.ForeColor = Color.White;
            BtnSubtraction.Location = new Point(263, 371);
            BtnSubtraction.Name = "BtnSubtraction";
            BtnSubtraction.Size = new Size(90, 54);
            BtnSubtraction.TabIndex = 6;
            BtnSubtraction.Text = "-";
            BtnSubtraction.TextColor = Color.White;
            BtnSubtraction.UseVisualStyleBackColor = false;
            BtnSubtraction.Click += BtnMathOpperation_Click;
            // 
            // Btn2
            // 
            Btn2.BackColor = Color.FromArgb(60, 60, 60);
            Btn2.BackgroundColor = Color.FromArgb(60, 60, 60);
            Btn2.BackgroundImageLayout = ImageLayout.None;
            Btn2.BorderRadius = 20;
            Btn2.BorderSize = 0;
            Btn2.FlatAppearance.BorderSize = 0;
            Btn2.FlatStyle = FlatStyle.Flat;
            Btn2.ForeColor = Color.White;
            Btn2.Location = new Point(92, 429);
            Btn2.Name = "Btn2";
            Btn2.Size = new Size(79, 54);
            Btn2.TabIndex = 6;
            Btn2.Text = "2";
            Btn2.TextColor = Color.White;
            Btn2.UseVisualStyleBackColor = false;
            Btn2.Click += BynNum_Click;
            // 
            // BtnPM
            // 
            BtnPM.BackColor = Color.FromArgb(60, 60, 60);
            BtnPM.BackgroundColor = Color.FromArgb(60, 60, 60);
            BtnPM.BackgroundImageLayout = ImageLayout.None;
            BtnPM.BorderRadius = 20;
            BtnPM.BorderSize = 0;
            BtnPM.FlatAppearance.BorderSize = 0;
            BtnPM.FlatStyle = FlatStyle.Flat;
            BtnPM.ForeColor = Color.White;
            BtnPM.Location = new Point(3, 489);
            BtnPM.Name = "BtnPM";
            BtnPM.Size = new Size(85, 54);
            BtnPM.TabIndex = 6;
            BtnPM.Text = "+/_";
            BtnPM.TextColor = Color.White;
            BtnPM.UseVisualStyleBackColor = false;
            BtnPM.Click += BtnOperations_Click;
            // 
            // Btn0
            // 
            Btn0.BackColor = Color.FromArgb(60, 60, 60);
            Btn0.BackgroundColor = Color.FromArgb(60, 60, 60);
            Btn0.BackgroundImageLayout = ImageLayout.None;
            Btn0.BorderRadius = 20;
            Btn0.BorderSize = 0;
            Btn0.FlatAppearance.BorderSize = 0;
            Btn0.FlatStyle = FlatStyle.Flat;
            Btn0.ForeColor = Color.White;
            Btn0.Location = new Point(93, 488);
            Btn0.Name = "Btn0";
            Btn0.Size = new Size(79, 54);
            Btn0.TabIndex = 6;
            Btn0.Text = "0";
            Btn0.TextColor = Color.White;
            Btn0.UseVisualStyleBackColor = false;
            Btn0.Click += BynNum_Click;
            // 
            // Btn3
            // 
            Btn3.BackColor = Color.FromArgb(60, 60, 60);
            Btn3.BackgroundColor = Color.FromArgb(60, 60, 60);
            Btn3.BackgroundImageLayout = ImageLayout.None;
            Btn3.BorderRadius = 20;
            Btn3.BorderSize = 0;
            Btn3.FlatAppearance.BorderSize = 0;
            Btn3.FlatStyle = FlatStyle.Flat;
            Btn3.ForeColor = Color.White;
            Btn3.Location = new Point(175, 428);
            Btn3.Name = "Btn3";
            Btn3.Size = new Size(85, 54);
            Btn3.TabIndex = 6;
            Btn3.Text = "3";
            Btn3.TextColor = Color.White;
            Btn3.UseVisualStyleBackColor = false;
            Btn3.Click += BynNum_Click;
            // 
            // BtnDesimal
            // 
            BtnDesimal.BackColor = Color.FromArgb(60, 60, 60);
            BtnDesimal.BackgroundColor = Color.FromArgb(60, 60, 60);
            BtnDesimal.BackgroundImageLayout = ImageLayout.None;
            BtnDesimal.BorderRadius = 20;
            BtnDesimal.BorderSize = 0;
            BtnDesimal.FlatAppearance.BorderSize = 0;
            BtnDesimal.FlatStyle = FlatStyle.Flat;
            BtnDesimal.ForeColor = Color.White;
            BtnDesimal.Location = new Point(177, 488);
            BtnDesimal.Name = "BtnDesimal";
            BtnDesimal.Size = new Size(85, 54);
            BtnDesimal.TabIndex = 6;
            BtnDesimal.Text = ",";
            BtnDesimal.TextColor = Color.White;
            BtnDesimal.UseVisualStyleBackColor = false;
            BtnDesimal.Click += BynNum_Click;
            // 
            // BtnPlus
            // 
            BtnPlus.BackColor = Color.FromArgb(50, 50, 50);
            BtnPlus.BackgroundColor = Color.FromArgb(50, 50, 50);
            BtnPlus.BackgroundImageLayout = ImageLayout.None;
            BtnPlus.BorderRadius = 20;
            BtnPlus.BorderSize = 0;
            BtnPlus.FlatAppearance.BorderSize = 0;
            BtnPlus.FlatStyle = FlatStyle.Flat;
            BtnPlus.ForeColor = Color.White;
            BtnPlus.Location = new Point(263, 428);
            BtnPlus.Name = "BtnPlus";
            BtnPlus.Size = new Size(90, 54);
            BtnPlus.TabIndex = 6;
            BtnPlus.Text = "+";
            BtnPlus.TextColor = Color.White;
            BtnPlus.UseVisualStyleBackColor = false;
            BtnPlus.Click += BtnMathOpperation_Click;
            // 
            // BtnEquals
            // 
            BtnEquals.BackColor = SystemColors.Highlight;
            BtnEquals.BackgroundColor = SystemColors.Highlight;
            BtnEquals.BackgroundImageLayout = ImageLayout.None;
            BtnEquals.BorderRadius = 20;
            BtnEquals.BorderSize = 0;
            BtnEquals.FlatAppearance.BorderSize = 0;
            BtnEquals.FlatStyle = FlatStyle.Flat;
            BtnEquals.ForeColor = Color.White;
            BtnEquals.Location = new Point(266, 488);
            BtnEquals.Name = "BtnEquals";
            BtnEquals.Size = new Size(90, 54);
            BtnEquals.TabIndex = 6;
            BtnEquals.Text = "=";
            BtnEquals.TextColor = Color.White;
            BtnEquals.UseVisualStyleBackColor = false;
            BtnEquals.Click += BtnEquals_Click;
            // 
            // Btn9
            // 
            Btn9.BackColor = Color.FromArgb(60, 60, 60);
            Btn9.BackgroundColor = Color.FromArgb(60, 60, 60);
            Btn9.BackgroundImageLayout = ImageLayout.None;
            Btn9.BorderRadius = 20;
            Btn9.BorderSize = 0;
            Btn9.FlatAppearance.BorderSize = 0;
            Btn9.FlatStyle = FlatStyle.Flat;
            Btn9.ForeColor = Color.White;
            Btn9.Location = new Point(177, 310);
            Btn9.Name = "Btn9";
            Btn9.Size = new Size(85, 54);
            Btn9.TabIndex = 6;
            Btn9.Text = "9";
            Btn9.TextColor = Color.White;
            Btn9.UseVisualStyleBackColor = false;
            Btn9.Click += BynNum_Click;
            // 
            // Btn8
            // 
            Btn8.BackColor = Color.FromArgb(60, 60, 60);
            Btn8.BackgroundColor = Color.FromArgb(60, 60, 60);
            Btn8.BackgroundImageLayout = ImageLayout.None;
            Btn8.BorderRadius = 20;
            Btn8.BorderSize = 0;
            Btn8.FlatAppearance.BorderSize = 0;
            Btn8.FlatStyle = FlatStyle.Flat;
            Btn8.ForeColor = Color.White;
            Btn8.Location = new Point(89, 309);
            Btn8.Name = "Btn8";
            Btn8.Size = new Size(85, 54);
            Btn8.TabIndex = 6;
            Btn8.Text = "8";
            Btn8.TextColor = Color.White;
            Btn8.UseVisualStyleBackColor = false;
            Btn8.Click += BynNum_Click;
            // 
            // Btn5
            // 
            Btn5.BackColor = Color.FromArgb(60, 60, 60);
            Btn5.BackgroundColor = Color.FromArgb(60, 60, 60);
            Btn5.BackgroundImageLayout = ImageLayout.None;
            Btn5.BorderRadius = 20;
            Btn5.BorderSize = 0;
            Btn5.FlatAppearance.BorderSize = 0;
            Btn5.FlatStyle = FlatStyle.Flat;
            Btn5.ForeColor = Color.White;
            Btn5.Location = new Point(90, 371);
            Btn5.Name = "Btn5";
            Btn5.Size = new Size(85, 54);
            Btn5.TabIndex = 6;
            Btn5.Text = "5";
            Btn5.TextColor = Color.White;
            Btn5.UseVisualStyleBackColor = false;
            Btn5.Click += BynNum_Click;
            // 
            // Btn4
            // 
            Btn4.BackColor = Color.FromArgb(60, 60, 60);
            Btn4.BackgroundColor = Color.FromArgb(60, 60, 60);
            Btn4.BackgroundImageLayout = ImageLayout.None;
            Btn4.BorderRadius = 20;
            Btn4.BorderSize = 0;
            Btn4.FlatAppearance.BorderSize = 0;
            Btn4.FlatStyle = FlatStyle.Flat;
            Btn4.ForeColor = Color.White;
            Btn4.Location = new Point(0, 370);
            Btn4.Name = "Btn4";
            Btn4.Size = new Size(85, 54);
            Btn4.TabIndex = 6;
            Btn4.Text = "4";
            Btn4.TextColor = Color.White;
            Btn4.UseVisualStyleBackColor = false;
            Btn4.Click += BynNum_Click;
            // 
            // Btn1
            // 
            Btn1.BackColor = Color.FromArgb(60, 60, 60);
            Btn1.BackgroundColor = Color.FromArgb(60, 60, 60);
            Btn1.BackgroundImageLayout = ImageLayout.None;
            Btn1.BorderRadius = 20;
            Btn1.BorderSize = 0;
            Btn1.FlatAppearance.BorderSize = 0;
            Btn1.FlatStyle = FlatStyle.Flat;
            Btn1.ForeColor = Color.White;
            Btn1.Location = new Point(1, 430);
            Btn1.Name = "Btn1";
            Btn1.Size = new Size(85, 54);
            Btn1.TabIndex = 6;
            Btn1.Text = "1";
            Btn1.TextColor = Color.White;
            Btn1.UseVisualStyleBackColor = false;
            Btn1.Click += BynNum_Click;
            // 
            // Btn7
            // 
            Btn7.BackColor = Color.FromArgb(60, 60, 60);
            Btn7.BackgroundColor = Color.FromArgb(60, 60, 60);
            Btn7.BackgroundImageLayout = ImageLayout.None;
            Btn7.BorderRadius = 20;
            Btn7.BorderSize = 0;
            Btn7.FlatAppearance.BorderSize = 0;
            Btn7.FlatStyle = FlatStyle.Flat;
            Btn7.ForeColor = Color.White;
            Btn7.Location = new Point(1, 309);
            Btn7.Name = "Btn7";
            Btn7.Size = new Size(85, 54);
            Btn7.TabIndex = 6;
            Btn7.Text = "7";
            Btn7.TextColor = Color.White;
            Btn7.UseVisualStyleBackColor = false;
            Btn7.Click += BynNum_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(32, 32, 32);
            richTextBox1.Location = new Point(-2, 548);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(361, 13);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(359, 565);
            Controls.Add(BtnEquals);
            Controls.Add(BtnSubtraction);
            Controls.Add(BtnDivisio);
            Controls.Add(BtnPlus);
            Controls.Add(BtnMultiply);
            Controls.Add(BtnBackSpace);
            Controls.Add(BtnDesimal);
            Controls.Add(Btn7);
            Controls.Add(Btn1);
            Controls.Add(Btn4);
            Controls.Add(Btn5);
            Controls.Add(Btn8);
            Controls.Add(Btn9);
            Controls.Add(Btn6);
            Controls.Add(Btn3);
            Controls.Add(BtnSquare);
            Controls.Add(Btn0);
            Controls.Add(BtnPM);
            Controls.Add(BtnC);
            Controls.Add(Btn2);
            Controls.Add(BtnX2);
            Controls.Add(Btn1X);
            Controls.Add(BtnCE);
            Controls.Add(BtnPercent);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button kapat;
        private Panel panel6;
        private Button tamekran;
        private Button simgedrm;
        private Button BtnHistory;
        private TextBox textBox1;
        private TextBox textBox3;
        private WinFormsApp3.ArtanButton BtnPercent;
        private WinFormsApp3.ArtanButton BtnCE;
        private WinFormsApp3.ArtanButton BtnC;
        private WinFormsApp3.ArtanButton BtnBackSpace;
        private WinFormsApp3.ArtanButton Btn1X;
        private WinFormsApp3.ArtanButton BtnX2;
        private WinFormsApp3.ArtanButton BtnSquare;
        private WinFormsApp3.ArtanButton BtnDivisio;
        private WinFormsApp3.ArtanButton artanButton9;
        private WinFormsApp3.ArtanButton artanButton10;
        private WinFormsApp3.ArtanButton artanButton11;
        private WinFormsApp3.ArtanButton artanButton12;
        private WinFormsApp3.ArtanButton artanButton13;
        private WinFormsApp3.ArtanButton Btn6;
        private WinFormsApp3.ArtanButton BtnMultiply;
        private WinFormsApp3.ArtanButton BtnSubtraction;
        private WinFormsApp3.ArtanButton Btn2;
        private WinFormsApp3.ArtanButton BtnPM;
        private WinFormsApp3.ArtanButton Btn0;
        private WinFormsApp3.ArtanButton Btn3;
        private WinFormsApp3.ArtanButton BtnDesimal;
        private WinFormsApp3.ArtanButton BtnPlus;
        private WinFormsApp3.ArtanButton BtnEquals;
        private WinFormsApp3.ArtanButton Btn9;
        private WinFormsApp3.ArtanButton Btn8;
        private WinFormsApp3.ArtanButton Btn5;
        private WinFormsApp3.ArtanButton Btn4;
        private WinFormsApp3.ArtanButton Btn1;
        private WinFormsApp3.ArtanButton Btn7;
        private RichTextBox richTextBox1;
    }
}
