using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    partial class Form1
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
            locationButtons = new Button[9];
            resetButton = new Button();


            this.textBox1 = new TextBox();
            this.SuspendLayout();
            
            resetButton.Location = new System.Drawing.Point(250, 218);
            resetButton.Name = "resetButton";
            resetButton.Size = new System.Drawing.Size(75, 23);
            resetButton.TabIndex = 0;
            resetButton.Text = "Reset Game";
            resetButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            locationButtons[0] = new Button();
            this.locationButtons[0].Location = new System.Drawing.Point(34, 52);
            this.locationButtons[0].Name = "button1";
            this.locationButtons[0].Size = new System.Drawing.Size(75, 23);
            this.locationButtons[0].TabIndex = 0;
            this.locationButtons[0].Text = "button1";
            this.locationButtons[0].UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            locationButtons[1] = new System.Windows.Forms.Button();
            this.locationButtons[1].Location = new System.Drawing.Point(139, 52);
            this.locationButtons[1].Name = "button2";
            this.locationButtons[1].Size = new System.Drawing.Size(75, 23);
            this.locationButtons[1].TabIndex = 1;
            this.locationButtons[1].Text = "button2";
            this.locationButtons[1].UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            locationButtons[2] = new System.Windows.Forms.Button();
            this.locationButtons[2].Location = new System.Drawing.Point(247, 52);
            this.locationButtons[2].Name = "button3";
            this.locationButtons[2].Size = new System.Drawing.Size(75, 23);
            this.locationButtons[2].TabIndex = 2;
            this.locationButtons[2].Text = "button3";
            this.locationButtons[2].UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            locationButtons[3] = new System.Windows.Forms.Button();
            this.locationButtons[3].Location = new System.Drawing.Point(34, 114);
            this.locationButtons[3].Name = "button4";
            this.locationButtons[3].Size = new System.Drawing.Size(75, 23);
            this.locationButtons[3].TabIndex = 3;
            this.locationButtons[3].Text = "button4";
            this.locationButtons[3].UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            locationButtons[4] = new System.Windows.Forms.Button();
            this.locationButtons[4].Location = new System.Drawing.Point(139, 114);
            this.locationButtons[4].Name = "button5";
            this.locationButtons[4].Size = new System.Drawing.Size(75, 23);
            this.locationButtons[4].TabIndex = 4;
            this.locationButtons[4].Text = "button5";
            this.locationButtons[4].UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            locationButtons[5] = new System.Windows.Forms.Button();
            this.locationButtons[5].Location = new System.Drawing.Point(247, 114);
            this.locationButtons[5].Name = "button6";
            this.locationButtons[5].Size = new System.Drawing.Size(75, 23);
            this.locationButtons[5].TabIndex = 5;
            this.locationButtons[5].Text = "button6";
            this.locationButtons[5].UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            locationButtons[6] = new System.Windows.Forms.Button();
            this.locationButtons[6].Location = new System.Drawing.Point(34, 169);
            this.locationButtons[6].Name = "button7";
            this.locationButtons[6].Size = new System.Drawing.Size(75, 23);
            this.locationButtons[6].TabIndex = 6;
            this.locationButtons[6].Text = "button7";
            this.locationButtons[6].UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            locationButtons[7] = new System.Windows.Forms.Button();
            this.locationButtons[7].Location = new System.Drawing.Point(139, 169);
            this.locationButtons[7].Name = "button8";
            this.locationButtons[7].Size = new System.Drawing.Size(75, 23);
            this.locationButtons[7].TabIndex = 7;
            this.locationButtons[7].Text = "button8";
            this.locationButtons[7].UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            locationButtons[8] = new System.Windows.Forms.Button();
            this.locationButtons[8].Location = new System.Drawing.Point(247, 169);
            this.locationButtons[8].Name = "button9";
            this.locationButtons[8].Size = new System.Drawing.Size(75, 23);
            this.locationButtons[8].TabIndex = 8;
            this.locationButtons[8].Text = "button9";
            this.locationButtons[8].UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 250);
            this.Controls.Add(this.textBox1);
            Controls.Add(resetButton);
            foreach(var b in locationButtons)
            {
                this.Controls.Add(b);
            }
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button resetButton;
        private Button[] locationButtons;
        private TextBox textBox1;
    }
}