using System.Runtime.InteropServices;

namespace lab1
{
    partial class Form1
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private const int EM_SETCUEBANNER = 0x1501;

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
            comboBoxTypes = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            txtSize = new TextBox();
            label1 = new Label();
            btnLoadBackground = new Button();
            btnClearBackground = new Button();
            progressBar1 = new ProgressBar();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxTypes
            // 
            comboBoxTypes.FormattingEnabled = true;
            comboBoxTypes.Items.AddRange(new object[] { "Эллиптическая галактика", "Миндалевидная галактика", "Спиральная галактика" });
            comboBoxTypes.Location = new Point(12, 12);
            comboBoxTypes.Name = "comboBoxTypes";
            comboBoxTypes.Size = new Size(275, 23);
            comboBoxTypes.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(12, 434);
            button1.Name = "button1";
            button1.Size = new Size(275, 30);
            button1.TabIndex = 2;
            button1.Text = "Старт";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnStart_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 484);
            button2.Name = "button2";
            button2.Size = new Size(275, 33);
            button2.TabIndex = 3;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnSave_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(313, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65535, 65535);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(12, 51);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(275, 23);
            txtSize.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 77);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 6;
            label1.Text = "Размеры файла";
            // 
            // btnLoadBackground
            // 
            btnLoadBackground.Location = new Point(12, 117);
            btnLoadBackground.Name = "btnLoadBackground";
            btnLoadBackground.Size = new Size(275, 23);
            btnLoadBackground.TabIndex = 7;
            btnLoadBackground.Text = "Выбрать фон (подложку)";
            btnLoadBackground.UseVisualStyleBackColor = true;
            btnLoadBackground.Click += btnLoadBackground_Click;
            // 
            // btnClearBackground
            // 
            btnClearBackground.Location = new Point(12, 185);
            btnClearBackground.Name = "btnClearBackground";
            btnClearBackground.Size = new Size(275, 23);
            btnClearBackground.TabIndex = 8;
            btnClearBackground.Text = "Удалить фон";
            btnClearBackground.UseVisualStyleBackColor = true;
            btnClearBackground.Click += btnClearBackground_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 579);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(275, 16);
            progressBar1.TabIndex = 9;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 607);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 10;
            // 
            // Form1
            // 
            ClientSize = new Size(1435, 1024);
            Controls.Add(lblStatus);
            Controls.Add(progressBar1);
            Controls.Add(btnClearBackground);
            Controls.Add(btnLoadBackground);
            Controls.Add(label1);
            Controls.Add(txtSize);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBoxTypes);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private ComboBox comboBoxTypes;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private TextBox txtSize;
        private Label label1;
        private Button btnLoadBackground;
        private Button btnClearBackground;
        private ProgressBar progressBar1;
        private Label lblStatus;
    }
}
