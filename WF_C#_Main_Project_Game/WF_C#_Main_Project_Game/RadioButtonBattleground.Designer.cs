namespace WF_C__Main_Project_Game
{
    partial class RadioButtonBattleground
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
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkOrange;
            label1.Font = new Font("Verdana", 15F);
            label1.Location = new Point(130, 24);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 0;
            label1.Text = "Battleground";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.DarkRed;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Verdana", 9F, FontStyle.Bold);
            radioButton1.ForeColor = SystemColors.ButtonHighlight;
            radioButton1.Location = new Point(56, 100);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(69, 18);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Vulcan";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.Click += radioButton1_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Gold;
            radioButton2.Font = new Font("Verdana", 9F);
            radioButton2.Location = new Point(170, 100);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(54, 18);
            radioButton2.TabIndex = 2;
            radioButton2.Text = "Field";
            radioButton2.UseVisualStyleBackColor = false;
            radioButton2.Click += radioButton2_Click;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.DarkGray;
            radioButton3.Font = new Font("Verdana", 9F);
            radioButton3.ForeColor = SystemColors.ActiveCaptionText;
            radioButton3.Location = new Point(275, 100);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(75, 18);
            radioButton3.TabIndex = 3;
            radioButton3.Text = "Subway";
            radioButton3.UseVisualStyleBackColor = false;
            radioButton3.Click += radioButton3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Beige;
            button1.Font = new Font("Verdana", 15F);
            button1.Location = new Point(130, 173);
            button1.Name = "button1";
            button1.Size = new Size(143, 35);
            button1.TabIndex = 4;
            button1.Text = "Sumbit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += sumbitButton_Click;
            // 
            // RadioButtonBattleground
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 282);
            Controls.Add(button1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Name = "RadioButtonBattleground";
            Text = "RadioButtonBattleground";
            Load += RadioButtonBattleground_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button button1;
    }
}