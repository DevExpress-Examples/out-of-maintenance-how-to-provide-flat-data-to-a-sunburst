namespace SunburstFlatDataAdapterSample {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.sunburstControl = new DevExpress.XtraTreeMap.SunburstControl();
            ((System.ComponentModel.ISupportInitialize)(this.sunburstControl)).BeginInit();
            this.SuspendLayout();
            // 
            // sunburstControl
            // 
            this.sunburstControl.BackColor = System.Drawing.Color.White;
            this.sunburstControl.BorderOptions.Color = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(160)))), ((int)(((byte)(170)))));
            this.sunburstControl.BorderOptions.Visible = false;
            this.sunburstControl.CenterLabel.BackgroundColor = System.Drawing.Color.White;
            this.sunburstControl.CenterLabel.TextFont = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.sunburstControl.CenterLabel.TextPattern = "Products Export";
            this.sunburstControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sunburstControl.Location = new System.Drawing.Point(0, 0);
            this.sunburstControl.Name = "sunburstControl";
            this.sunburstControl.Padding = new System.Windows.Forms.Padding(10);
            this.sunburstControl.Size = new System.Drawing.Size(486, 450);
            this.sunburstControl.StartAngle = 0D;
            this.sunburstControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 450);
            this.Controls.Add(this.sunburstControl);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.sunburstControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeMap.SunburstControl sunburstControl;
    }
}

