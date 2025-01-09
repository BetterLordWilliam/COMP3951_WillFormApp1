namespace WillFormApp1
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
            willFormStartButton = new Button();
            SuspendLayout();
            // 
            // willFormStartButton
            // 
            willFormStartButton.Location = new Point(338, 197);
            willFormStartButton.Name = "willFormStartButton";
            willFormStartButton.Size = new Size(131, 40);
            willFormStartButton.TabIndex = 0;
            willFormStartButton.Text = "Start Form";
            willFormStartButton.UseVisualStyleBackColor = true;
            willFormStartButton.Click += willFormStartButton_Click;
            // 
            // Form1
            // 
            AcceptButton = willFormStartButton;
            AccessibleDescription = "Will form that you can use to answer cool questions";
            AccessibleName = "Will form";
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(willFormStartButton);
            Name = "Form1";
            Text = "Will's Form";
            ResumeLayout(false);
        }

        #endregion

        private Button willFormStartButton;
    }
}
