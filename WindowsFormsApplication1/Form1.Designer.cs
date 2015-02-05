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
            this._rd = new VncSharp.RemoteDesktop();
            this.SuspendLayout();
            // 
            // _rd
            // 
            this._rd.AutoScroll = true;
            this._rd.AutoScrollMinSize = new System.Drawing.Size(608, 427);
            this._rd.Dock = System.Windows.Forms.DockStyle.Fill;
            this._rd.Location = new System.Drawing.Point(0, 0);
            this._rd.Name = "_rd";
            this._rd.Size = new System.Drawing.Size(1022, 703);
            this._rd.TabIndex = 0;
            this._rd.ConnectComplete += new VncSharp.ConnectCompleteHandler(this._rd_ConnectComplete);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 703);
            this.Controls.Add(this._rd);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private VncSharp.RemoteDesktop _rd;
    }
}

