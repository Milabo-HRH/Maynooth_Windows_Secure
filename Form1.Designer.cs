namespace WindowsRegistry
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
            this.BApply = new System.Windows.Forms.Button();
            this.ChBShutDown = new System.Windows.Forms.CheckBox();
            this.ChBDesktop = new System.Windows.Forms.CheckBox();
            this.ChBTaskManager = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BApply
            // 
            this.BApply.Location = new System.Drawing.Point(140, 107);
            this.BApply.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BApply.Name = "BApply";
            this.BApply.Size = new System.Drawing.Size(85, 27);
            this.BApply.TabIndex = 0;
            this.BApply.Text = "Apply";
            this.BApply.UseVisualStyleBackColor = true;
            // 
            // ChBShutDown
            // 
            this.ChBShutDown.AutoSize = true;
            this.ChBShutDown.Location = new System.Drawing.Point(252, 53);
            this.ChBShutDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChBShutDown.Name = "ChBShutDown";
            this.ChBShutDown.Size = new System.Drawing.Size(84, 19);
            this.ChBShutDown.TabIndex = 3;
            this.ChBShutDown.Text = "Shut Down";
            this.ChBShutDown.UseVisualStyleBackColor = true;
            // 
            // ChBDesktop
            // 
            this.ChBDesktop.AutoSize = true;
            this.ChBDesktop.Location = new System.Drawing.Point(14, 53);
            this.ChBDesktop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChBDesktop.Name = "ChBDesktop";
            this.ChBDesktop.Size = new System.Drawing.Size(69, 19);
            this.ChBDesktop.TabIndex = 8;
            this.ChBDesktop.Text = "Desktop";
            this.ChBDesktop.UseVisualStyleBackColor = true;
            // 
            // ChBTaskManager
            // 
            this.ChBTaskManager.AutoSize = true;
            this.ChBTaskManager.Location = new System.Drawing.Point(114, 53);
            this.ChBTaskManager.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChBTaskManager.Name = "ChBTaskManager";
            this.ChBTaskManager.Size = new System.Drawing.Size(99, 19);
            this.ChBTaskManager.TabIndex = 9;
            this.ChBTaskManager.Text = "Task Manager";
            this.ChBTaskManager.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 170);
            this.Controls.Add(this.ChBTaskManager);
            this.Controls.Add(this.ChBDesktop);
            this.Controls.Add(this.ChBShutDown);
            this.Controls.Add(this.BApply);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Prevent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BApply;
        private System.Windows.Forms.CheckBox ChBShutDown;
        private System.Windows.Forms.CheckBox ChBDesktop;
        private System.Windows.Forms.CheckBox ChBTaskManager;
    }
}

