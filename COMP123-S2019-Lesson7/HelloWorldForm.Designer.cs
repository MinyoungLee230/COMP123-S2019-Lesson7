﻿namespace COMP123_S2019_Lesson7
{
    partial class HelloWorldForm
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
            this.HelloWorldLabel = new System.Windows.Forms.Label();
            this.ClickMeButton = new System.Windows.Forms.Button();
            this.RandomNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HelloWorldLabel
            // 
            this.HelloWorldLabel.BackColor = System.Drawing.Color.White;
            this.HelloWorldLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HelloWorldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelloWorldLabel.Location = new System.Drawing.Point(236, 225);
            this.HelloWorldLabel.Name = "HelloWorldLabel";
            this.HelloWorldLabel.Size = new System.Drawing.Size(285, 48);
            this.HelloWorldLabel.TabIndex = 0;
            this.HelloWorldLabel.Text = "Hello, World!";
            this.HelloWorldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClickMeButton
            // 
            this.ClickMeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClickMeButton.Location = new System.Drawing.Point(74, 225);
            this.ClickMeButton.Name = "ClickMeButton";
            this.ClickMeButton.Size = new System.Drawing.Size(156, 48);
            this.ClickMeButton.TabIndex = 1;
            this.ClickMeButton.Text = "Click Me!";
            this.ClickMeButton.UseVisualStyleBackColor = true;
            this.ClickMeButton.Click += new System.EventHandler(this.ClickMeButton_Click);
            // 
            // RandomNumberLabel
            // 
            this.RandomNumberLabel.BackColor = System.Drawing.Color.White;
            this.RandomNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RandomNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomNumberLabel.Location = new System.Drawing.Point(527, 225);
            this.RandomNumberLabel.Name = "RandomNumberLabel";
            this.RandomNumberLabel.Size = new System.Drawing.Size(50, 48);
            this.RandomNumberLabel.TabIndex = 2;
            this.RandomNumberLabel.Text = "99";
            this.RandomNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HelloWorldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.RandomNumberLabel);
            this.Controls.Add(this.ClickMeButton);
            this.Controls.Add(this.HelloWorldLabel);
            this.Name = "HelloWorldForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hello World Form";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label HelloWorldLabel;
        private System.Windows.Forms.Button ClickMeButton;
        public System.Windows.Forms.Label RandomNumberLabel;
    }
}

