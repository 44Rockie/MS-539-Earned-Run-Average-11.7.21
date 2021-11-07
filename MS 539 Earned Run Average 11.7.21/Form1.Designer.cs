
namespace MS_539_Earned_Run_Average_11._7._21
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
            this.earnedRunsPromptLabel = new System.Windows.Forms.Label();
            this.inningsPitchedPromptLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.runsTextBox = new System.Windows.Forms.TextBox();
            this.inningsTextBox = new System.Windows.Forms.TextBox();
            this.eraLabel = new System.Windows.Forms.Label();
            this.calculateEraButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // earnedRunsPromptLabel
            // 
            this.earnedRunsPromptLabel.Location = new System.Drawing.Point(125, 59);
            this.earnedRunsPromptLabel.Name = "earnedRunsPromptLabel";
            this.earnedRunsPromptLabel.Size = new System.Drawing.Size(328, 38);
            this.earnedRunsPromptLabel.TabIndex = 0;
            this.earnedRunsPromptLabel.Text = "Enter the Number of Earned Runs:";
            this.earnedRunsPromptLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // inningsPitchedPromptLabel
            // 
            this.inningsPitchedPromptLabel.Location = new System.Drawing.Point(125, 133);
            this.inningsPitchedPromptLabel.Name = "inningsPitchedPromptLabel";
            this.inningsPitchedPromptLabel.Size = new System.Drawing.Size(328, 38);
            this.inningsPitchedPromptLabel.TabIndex = 1;
            this.inningsPitchedPromptLabel.Text = "Enter the Number of Innings Pitched:";
            this.inningsPitchedPromptLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.Location = new System.Drawing.Point(125, 209);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(328, 38);
            this.outputDescriptionLabel.TabIndex = 2;
            this.outputDescriptionLabel.Text = "Your Earned Run Average:";
            this.outputDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // runsTextBox
            // 
            this.runsTextBox.Location = new System.Drawing.Point(503, 59);
            this.runsTextBox.Name = "runsTextBox";
            this.runsTextBox.Size = new System.Drawing.Size(206, 31);
            this.runsTextBox.TabIndex = 3;
            // 
            // inningsTextBox
            // 
            this.inningsTextBox.Location = new System.Drawing.Point(503, 133);
            this.inningsTextBox.Name = "inningsTextBox";
            this.inningsTextBox.Size = new System.Drawing.Size(206, 31);
            this.inningsTextBox.TabIndex = 4;
            // 
            // eraLabel
            // 
            this.eraLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.eraLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eraLabel.Location = new System.Drawing.Point(503, 209);
            this.eraLabel.Name = "eraLabel";
            this.eraLabel.Size = new System.Drawing.Size(206, 38);
            this.eraLabel.TabIndex = 5;
            // 
            // calculateEraButton
            // 
            this.calculateEraButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.calculateEraButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calculateEraButton.Location = new System.Drawing.Point(71, 302);
            this.calculateEraButton.Name = "calculateEraButton";
            this.calculateEraButton.Size = new System.Drawing.Size(190, 34);
            this.calculateEraButton.TabIndex = 6;
            this.calculateEraButton.Text = "Calculate ERA";
            this.calculateEraButton.UseVisualStyleBackColor = false;
            this.calculateEraButton.Click += new System.EventHandler(this.calculateEraButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(503, 302);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(192, 34);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearButton.Location = new System.Drawing.Point(289, 302);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(185, 34);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateEraButton);
            this.Controls.Add(this.eraLabel);
            this.Controls.Add(this.inningsTextBox);
            this.Controls.Add(this.runsTextBox);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.inningsPitchedPromptLabel);
            this.Controls.Add(this.earnedRunsPromptLabel);
            this.Name = "Form1";
            this.Text = "Earned Run Average";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label earnedRunsPromptLabel;
        private System.Windows.Forms.Label inningsPitchedPromptLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.TextBox runsTextBox;
        private System.Windows.Forms.TextBox inningsTextBox;
        private System.Windows.Forms.Label eraLabel;
        private System.Windows.Forms.Button calculateEraButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
    }
}

