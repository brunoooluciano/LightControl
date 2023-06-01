namespace WinFormsAppLamp
{
    partial class Lighting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lighting));
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // checkBox1
            // 
            resources.ApplyResources(checkBox1, "checkBox1");
            checkBox1.BackColor = Color.FromArgb(55, 55, 39);
            checkBox1.ForeColor = SystemColors.ButtonFace;
            checkBox1.Name = "checkBox1";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            resources.ApplyResources(checkBox2, "checkBox2");
            checkBox2.BackColor = Color.FromArgb(55, 55, 39);
            checkBox2.ForeColor = SystemColors.ButtonFace;
            checkBox2.Name = "checkBox2";
            checkBox2.UseVisualStyleBackColor = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Name = "label3";
            // 
            // Lighting
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Name = "Lighting";
            ResumeLayout(false);
        }

        #endregion
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}