namespace WF_C__Main_Project_Game
{
    partial class Form_Choose_Arena
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
            chooseBattlegroundButton = new Button();
            sumbitButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkOrange;
            label1.Font = new Font("Vijaya", 72F);
            label1.Location = new Point(219, 56);
            label1.Name = "label1";
            label1.Size = new Size(463, 130);
            label1.TabIndex = 0;
            label1.Text = "Battleground";
            label1.Click += label1_Click;
            // 
            // chooseBattlegroundButton
            // 
            chooseBattlegroundButton.BackColor = SystemColors.ActiveBorder;
            chooseBattlegroundButton.Font = new Font("Verdana", 20F);
            chooseBattlegroundButton.ForeColor = SystemColors.Desktop;
            chooseBattlegroundButton.Location = new Point(219, 307);
            chooseBattlegroundButton.Name = "chooseBattlegroundButton";
            chooseBattlegroundButton.Size = new Size(463, 72);
            chooseBattlegroundButton.TabIndex = 1;
            chooseBattlegroundButton.Text = "Choose Battleground";
            chooseBattlegroundButton.UseVisualStyleBackColor = false;
            chooseBattlegroundButton.Click += chooseBattlegroundButton_Click;
            // 
            // sumbitButton
            // 
            sumbitButton.BackColor = Color.LimeGreen;
            sumbitButton.Enabled = false;
            sumbitButton.Font = new Font("Verdana", 36F);
            sumbitButton.Location = new Point(219, 441);
            sumbitButton.Name = "sumbitButton";
            sumbitButton.Size = new Size(463, 74);
            sumbitButton.TabIndex = 2;
            sumbitButton.Text = "Sumbit";
            sumbitButton.UseVisualStyleBackColor = false;
            sumbitButton.Click += sumbitButton_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form_Choose_Arena
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 729);
            Controls.Add(sumbitButton);
            Controls.Add(chooseBattlegroundButton);
            Controls.Add(label1);
            Name = "Form_Choose_Arena";
            Text = "Form_Choose_Weather";
            Load += Form_Choose_Weather_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button chooseBattlegroundButton;
        private Button sumbitButton;
        private System.Windows.Forms.Timer timer1;
    }
}