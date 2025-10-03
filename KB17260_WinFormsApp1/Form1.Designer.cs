namespace KB17260_WinFormsApp1
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
            ultraListView1 = new Infragistics.Win.UltraWinListView.UltraListView();
            ((System.ComponentModel.ISupportInitialize)ultraListView1).BeginInit();
            SuspendLayout();
            // 
            // ultraListView1
            // 
            ultraListView1.Location = new Point(12, 12);
            ultraListView1.Name = "ultraListView1";
            ultraListView1.Size = new Size(257, 266);
            ultraListView1.TabIndex = 0;
            ultraListView1.Text = "ultraListView1";
            ultraListView1.ItemCheckStateChanged += ultraListView1_ItemCheckStateChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ultraListView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ultraListView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Infragistics.Win.UltraWinListView.UltraListView ultraListView1;
    }
}
