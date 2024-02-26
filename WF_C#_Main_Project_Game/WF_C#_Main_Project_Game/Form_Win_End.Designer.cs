namespace WF_C__Main_Project_Game
{
    partial class Form_Win_End
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
            end_game_label = new Label();
            winner_label = new Label();
            SuspendLayout();
            // 
            // end_game_label
            // 
            end_game_label.AutoSize = true;
            end_game_label.BackColor = Color.DarkOrange;
            end_game_label.Font = new Font("Vijaya", 72F);
            end_game_label.Location = new Point(223, 101);
            end_game_label.Name = "end_game_label";
            end_game_label.Size = new Size(443, 130);
            end_game_label.TabIndex = 0;
            end_game_label.Text = "END GAME";
            end_game_label.Click += label1_Click;
            // 
            // winner_label
            // 
            winner_label.AutoSize = true;
            winner_label.Font = new Font("Verdana", 48F, FontStyle.Italic, GraphicsUnit.Point, 204);
            winner_label.Location = new Point(256, 439);
            winner_label.Name = "winner_label";
            winner_label.Size = new Size(304, 78);
            winner_label.TabIndex = 1;
            winner_label.Text = "WINNER";
            // 
            // Form_Win_End
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Snow_Arena;
            ClientSize = new Size(899, 729);
            Controls.Add(winner_label);
            Controls.Add(end_game_label);
            Name = "Form_Win_End";
            Text = "Form_Win_End";
            Load += Form_Win_End_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label end_game_label;
        private Label winner_label;
    }
}