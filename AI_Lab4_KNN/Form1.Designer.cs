namespace AI_Lab4_KNN
{
    partial class FormMain
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
            this.buttonFindKNN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFindKNN
            // 
            this.buttonFindKNN.Location = new System.Drawing.Point(172, 148);
            this.buttonFindKNN.Name = "buttonFindKNN";
            this.buttonFindKNN.Size = new System.Drawing.Size(301, 195);
            this.buttonFindKNN.TabIndex = 0;
            this.buttonFindKNN.Text = "Find KNN";
            this.buttonFindKNN.UseVisualStyleBackColor = true;
            this.buttonFindKNN.Click += new System.EventHandler(this.buttonFindKNN_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 389);
            this.Controls.Add(this.buttonFindKNN);
            this.Name = "FormMain";
            this.Text = "Best form name ever :)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFindKNN;
    }
}

