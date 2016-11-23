namespace GrabberFirstCheckUpProject
{
    partial class GrabberMainForm
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
            this.btnGetGrabberData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetGrabberData
            // 
            this.btnGetGrabberData.Location = new System.Drawing.Point(130, 226);
            this.btnGetGrabberData.Name = "btnGetGrabberData";
            this.btnGetGrabberData.Size = new System.Drawing.Size(142, 23);
            this.btnGetGrabberData.TabIndex = 1;
            this.btnGetGrabberData.Text = "GetGrabber";
            this.btnGetGrabberData.UseVisualStyleBackColor = true;
            this.btnGetGrabberData.Click += new System.EventHandler(this.btnGetGrabberData_Click);
            // 
            // GrabberMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnGetGrabberData);
            this.Name = "GrabberMainForm";
            this.Text = "Grabber";
            this.Load += new System.EventHandler(this.GrabberMainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGetGrabberData;
    }
}

