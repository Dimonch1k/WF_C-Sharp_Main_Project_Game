namespace WF_C__Main_Project_Game
{
    partial class Form_Choose_Fighters
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            button_Sumbit = new Button();
            chooseFighter1_Button = new Button();
            chooseFighter2_Button = new Button();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SandyBrown;
            label1.Font = new Font("Verdana", 28F);
            label1.Location = new Point(220, 240);
            label1.Name = "label1";
            label1.Size = new Size(191, 46);
            label1.TabIndex = 0;
            label1.Text = "Fighter 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gold;
            label2.Font = new Font("Verdana", 28F);
            label2.Location = new Point(220, 331);
            label2.Name = "label2";
            label2.Size = new Size(191, 46);
            label2.TabIndex = 1;
            label2.Text = "Fighter 2";
            // 
            // button_Sumbit
            // 
            button_Sumbit.BackColor = Color.LimeGreen;
            button_Sumbit.Cursor = Cursors.No;
            button_Sumbit.Enabled = false;
            button_Sumbit.Font = new Font("Verdana", 36F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button_Sumbit.ForeColor = SystemColors.Desktop;
            button_Sumbit.Location = new Point(220, 469);
            button_Sumbit.Name = "button_Sumbit";
            button_Sumbit.Size = new Size(447, 74);
            button_Sumbit.TabIndex = 2;
            button_Sumbit.Text = "Sumbit";
            button_Sumbit.UseMnemonic = false;
            button_Sumbit.UseVisualStyleBackColor = false;
            button_Sumbit.Click += sumbitButton_Click;
            // 
            // chooseFighter1_Button
            // 
            chooseFighter1_Button.BackColor = SystemColors.ActiveBorder;
            chooseFighter1_Button.Cursor = Cursors.Hand;
            chooseFighter1_Button.Font = new Font("Verdana", 12F);
            chooseFighter1_Button.ForeColor = SystemColors.Desktop;
            chooseFighter1_Button.Location = new Point(510, 240);
            chooseFighter1_Button.Name = "chooseFighter1_Button";
            chooseFighter1_Button.Size = new Size(157, 46);
            chooseFighter1_Button.TabIndex = 7;
            chooseFighter1_Button.Text = "Choose Fighter 1";
            chooseFighter1_Button.UseVisualStyleBackColor = false;
            chooseFighter1_Button.TextChanged += button1_TextChanged;
            chooseFighter1_Button.Click += chooseFighter1Button_Click;
            // 
            // chooseFighter2_Button
            // 
            chooseFighter2_Button.BackColor = SystemColors.ActiveBorder;
            chooseFighter2_Button.Cursor = Cursors.Hand;
            chooseFighter2_Button.Font = new Font("Verdana", 12F);
            chooseFighter2_Button.ForeColor = SystemColors.Desktop;
            chooseFighter2_Button.Location = new Point(510, 331);
            chooseFighter2_Button.Name = "chooseFighter2_Button";
            chooseFighter2_Button.Size = new Size(157, 46);
            chooseFighter2_Button.TabIndex = 8;
            chooseFighter2_Button.Text = "Choose Fighter 2";
            chooseFighter2_Button.UseVisualStyleBackColor = false;
            chooseFighter2_Button.TextChanged += button2_TextChanged;
            chooseFighter2_Button.Click += chooseFighter2Button_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkOrange;
            label3.Font = new Font("Vijaya", 72F);
            label3.Location = new Point(272, 18);
            label3.Name = "label3";
            label3.Size = new Size(316, 130);
            label3.TabIndex = 9;
            label3.Text = "Fighters";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form_Choose_Fighters
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 729);
            Controls.Add(label3);
            Controls.Add(chooseFighter2_Button);
            Controls.Add(chooseFighter1_Button);
            Controls.Add(button_Sumbit);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_Choose_Fighters";
            Text = "Form_Choose_Fighters";
            Load += Form_Choose_Fighters_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button_Sumbit;
        private Button chooseFighter1_Button;
        private Button chooseFighter2_Button;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}