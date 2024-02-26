namespace WF_C__Main_Project_Game
{
    partial class Form_Start
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
            start_label = new Label();
            exit_start_button = new Button();
            continue_start_button = new Button();
            info_start_button = new Button();
            startTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // start_label
            // 
            start_label.AutoSize = true;
            start_label.BackColor = Color.DarkOrange;
            start_label.FlatStyle = FlatStyle.Popup;
            start_label.Font = new Font("Vijaya", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            start_label.Location = new Point(190, 50);
            start_label.Name = "start_label";
            start_label.Size = new Size(507, 130);
            start_label.TabIndex = 0;
            start_label.Text = "START GAME";
            // 
            // exit_start_button
            // 
            exit_start_button.BackColor = Color.OrangeRed;
            exit_start_button.Cursor = Cursors.Hand;
            exit_start_button.Font = new Font("Ukrainian?Present ", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            exit_start_button.Location = new Point(379, 407);
            exit_start_button.Name = "exit_start_button";
            exit_start_button.Size = new Size(129, 49);
            exit_start_button.TabIndex = 1;
            exit_start_button.Text = "EXIT";
            exit_start_button.UseVisualStyleBackColor = false;
            exit_start_button.Click += Exit_start_button_Click;
            // 
            // continue_start_button
            // 
            continue_start_button.BackColor = Color.ForestGreen;
            continue_start_button.Cursor = Cursors.Hand;
            continue_start_button.Font = new Font("Ukrainian?Present ", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            continue_start_button.Location = new Point(379, 268);
            continue_start_button.Name = "continue_start_button";
            continue_start_button.Size = new Size(129, 49);
            continue_start_button.TabIndex = 2;
            continue_start_button.Text = "START";
            continue_start_button.UseVisualStyleBackColor = false;
            continue_start_button.Click += Continue_start_button_Click;
            // 
            // info_start_button
            // 
            info_start_button.BackColor = Color.Yellow;
            info_start_button.Cursor = Cursors.Hand;
            info_start_button.Font = new Font("Ukrainian?Present ", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            info_start_button.Location = new Point(379, 337);
            info_start_button.Name = "info_start_button";
            info_start_button.Size = new Size(129, 50);
            info_start_button.TabIndex = 3;
            info_start_button.Text = "INFO";
            info_start_button.UseVisualStyleBackColor = false;
            info_start_button.Click += Info_start_button_Click;
            // 
            // startTimer
            // 
            startTimer.Tick += timer1_Tick;
            // 
            // Form_Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 729);
            Controls.Add(info_start_button);
            Controls.Add(continue_start_button);
            Controls.Add(exit_start_button);
            Controls.Add(start_label);
            Name = "Form_Start";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Start";
            Load += Form_Start_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label start_label;
        private Button exit_start_button;
        private Button continue_start_button;
        private Button info_start_button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer startTimer;
    }
}