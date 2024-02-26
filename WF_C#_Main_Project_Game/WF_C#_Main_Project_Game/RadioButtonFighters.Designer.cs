namespace WF_C__Main_Project_Game
{
    partial class RadioButtonFighters
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.DarkSeaGreen;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Verdana", 9F);
            radioButton1.Location = new Point(58, 95);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(65, 18);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Archer";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.Click += radioButton1_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = SystemColors.ActiveCaption;
            radioButton2.Font = new Font("Verdana", 9F);
            radioButton2.Location = new Point(169, 95);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(59, 18);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Mage";
            radioButton2.UseVisualStyleBackColor = false;
            radioButton2.Click += radioButton2_Click;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.DarkOrange;
            radioButton3.Font = new Font("Verdana", 9F);
            radioButton3.Location = new Point(272, 95);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(71, 18);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Warrior";
            radioButton3.UseVisualStyleBackColor = false;
            radioButton3.Click += radioButton3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkOrange;
            label1.Font = new Font("Verdana", 15F);
            label1.Location = new Point(122, 22);
            label1.Name = "label1";
            label1.Size = new Size(159, 25);
            label1.TabIndex = 3;
            label1.Text = "Choose fighter";
            // 
            // button1
            // 
            button1.BackColor = Color.Beige;
            button1.Font = new Font("Verdana", 15F);
            button1.Location = new Point(122, 167);
            button1.Name = "button1";
            button1.Size = new Size(159, 34);
            button1.TabIndex = 4;
            button1.Text = "Sumbit";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += sumbitButton_Click;
            // 
            // RadioButtonFighters
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 282);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Name = "RadioButtonFighters";
            Text = "RadioButton";
            Load += RadioButtonFighters_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private Label label1;
        private Button button1;
    }
}