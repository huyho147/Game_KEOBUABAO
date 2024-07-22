namespace Game_KEOBUABAO
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
            KeoBtn = new Button();
            BuaBtn = new Button();
            BaoBtn = new Button();
            RoundLbl = new Label();
            ScoreBtn = new Label();
            label1 = new Label();
            button1 = new Button();
            KetQuaTxt = new Label();
            SuspendLayout();
            // 
            // KeoBtn
            // 
            KeoBtn.BackgroundImage = Properties.Resources.kéo;
            KeoBtn.BackgroundImageLayout = ImageLayout.Zoom;
            KeoBtn.Cursor = Cursors.Hand;
            KeoBtn.Font = new Font("Tahoma", 20F);
            KeoBtn.Location = new Point(59, 245);
            KeoBtn.Margin = new Padding(0);
            KeoBtn.Name = "KeoBtn";
            KeoBtn.Size = new Size(160, 138);
            KeoBtn.TabIndex = 0;
            KeoBtn.UseVisualStyleBackColor = true;
            KeoBtn.Click += KeoBtn_Click;
            // 
            // BuaBtn
            // 
            BuaBtn.BackgroundImage = Properties.Resources.búa;
            BuaBtn.BackgroundImageLayout = ImageLayout.Zoom;
            BuaBtn.Cursor = Cursors.Hand;
            BuaBtn.Font = new Font("Tahoma", 20F);
            BuaBtn.Location = new Point(257, 245);
            BuaBtn.Margin = new Padding(0);
            BuaBtn.Name = "BuaBtn";
            BuaBtn.Size = new Size(160, 138);
            BuaBtn.TabIndex = 0;
            BuaBtn.UseVisualStyleBackColor = true;
            BuaBtn.Click += BuaBtn_Click;
            // 
            // BaoBtn
            // 
            BaoBtn.BackgroundImage = Properties.Resources.bao;
            BaoBtn.BackgroundImageLayout = ImageLayout.Zoom;
            BaoBtn.Cursor = Cursors.Hand;
            BaoBtn.Font = new Font("Tahoma", 20F);
            BaoBtn.Location = new Point(448, 245);
            BaoBtn.Margin = new Padding(0);
            BaoBtn.Name = "BaoBtn";
            BaoBtn.Size = new Size(160, 138);
            BaoBtn.TabIndex = 0;
            BaoBtn.UseVisualStyleBackColor = true;
            BaoBtn.Click += BaoBtn_Click;
            // 
            // RoundLbl
            // 
            RoundLbl.AutoSize = true;
            RoundLbl.Font = new Font("Tahoma", 20F);
            RoundLbl.Location = new Point(257, 18);
            RoundLbl.Name = "RoundLbl";
            RoundLbl.Size = new Size(156, 41);
            RoundLbl.TabIndex = 1;
            RoundLbl.Text = "Round: 0";
            // 
            // ScoreBtn
            // 
            ScoreBtn.AutoSize = true;
            ScoreBtn.Font = new Font("Tahoma", 20F);
            ScoreBtn.Location = new Point(257, 76);
            ScoreBtn.Name = "ScoreBtn";
            ScoreBtn.Size = new Size(143, 41);
            ScoreBtn.TabIndex = 1;
            ScoreBtn.Text = "Score: 0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20F);
            label1.Location = new Point(189, 175);
            label1.Name = "label1";
            label1.Size = new Size(309, 41);
            label1.TabIndex = 2;
            label1.Text = "Hãy chọn đi nào :D";
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 20F);
            button1.Location = new Point(509, 18);
            button1.Name = "button1";
            button1.Size = new Size(131, 77);
            button1.TabIndex = 3;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // KetQuaTxt
            // 
            KetQuaTxt.AutoSize = true;
            KetQuaTxt.Font = new Font("Tahoma", 20F);
            KetQuaTxt.Location = new Point(114, 412);
            KetQuaTxt.Name = "KetQuaTxt";
            KetQuaTxt.Size = new Size(0, 41);
            KetQuaTxt.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 493);
            Controls.Add(KetQuaTxt);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(ScoreBtn);
            Controls.Add(RoundLbl);
            Controls.Add(BaoBtn);
            Controls.Add(BuaBtn);
            Controls.Add(KeoBtn);
            Name = "Form1";
            Text = "Kéo Búa Bao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button KeoBtn;
        private Button BuaBtn;
        private Button BaoBtn;
        private Label RoundLbl;
        private Label ScoreBtn;
        private Label label1;
        private Button button1;
        private Label KetQuaTxt;
    }
}
