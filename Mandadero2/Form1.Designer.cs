namespace Mandadero2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnSn1h = new System.Windows.Forms.Button();
            this.btnSn1d = new System.Windows.Forms.Button();
            this.btnOKplus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(936, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "¿Qué estás haciendo?";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(8, 26);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(919, 22);
            this.txtDesc.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(852, 95);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 28);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.toolTip1.SetToolTip(this.btnOK, "Guardar");
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnSn1h
            // 
            this.btnSn1h.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnSn1h.Location = new System.Drawing.Point(644, 95);
            this.btnSn1h.Margin = new System.Windows.Forms.Padding(4);
            this.btnSn1h.Name = "btnSn1h";
            this.btnSn1h.Size = new System.Drawing.Size(108, 28);
            this.btnSn1h.TabIndex = 3;
            this.btnSn1h.Text = "Snooze 1&h";
            this.toolTip1.SetToolTip(this.btnSn1h, "No me molestes por una hora");
            this.btnSn1h.UseVisualStyleBackColor = true;
            // 
            // btnSn1d
            // 
            this.btnSn1d.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btnSn1d.Location = new System.Drawing.Point(523, 95);
            this.btnSn1d.Margin = new System.Windows.Forms.Padding(4);
            this.btnSn1d.Name = "btnSn1d";
            this.btnSn1d.Size = new System.Drawing.Size(113, 28);
            this.btnSn1d.TabIndex = 4;
            this.btnSn1d.Text = "Snooze 1&d";
            this.toolTip1.SetToolTip(this.btnSn1d, "No me molestes hasta mañana");
            this.btnSn1d.UseVisualStyleBackColor = true;
            this.btnSn1d.Click += new System.EventHandler(this.btnSn1d_Click);
            // 
            // btnOKplus
            // 
            this.btnOKplus.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnOKplus.Location = new System.Drawing.Point(760, 95);
            this.btnOKplus.Margin = new System.Windows.Forms.Padding(4);
            this.btnOKplus.Name = "btnOKplus";
            this.btnOKplus.Size = new System.Drawing.Size(84, 28);
            this.btnOKplus.TabIndex = 2;
            this.btnOKplus.Text = "O&K+";
            this.toolTip1.SetToolTip(this.btnOKplus, "Estoy on fire, guardar esta y preguntar de nuevo");
            this.btnOKplus.UseVisualStyleBackColor = true;
            this.btnOKplus.Click += new System.EventHandler(this.btnOKplus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(20, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter = OK | Esc = Snooze 1h | ...";
            this.toolTip1.SetToolTip(this.label1, "Ctrl + Enter = OK+\r\nAlt + D = Snooze 1d\r\nCtrl + Alt + F10 = Abrir Mandadero manua" +
        "lmente\r\nCtrl + Alt + F9 = Abrir la carpeta de log");
            // 
            // Form1
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSn1h;
            this.ClientSize = new System.Drawing.Size(968, 138);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOKplus);
            this.Controls.Add(this.btnSn1d);
            this.Controls.Add(this.btnSn1h);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mandadero";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnSn1h;
        private System.Windows.Forms.Button btnSn1d;
        private System.Windows.Forms.Button btnOKplus;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
    }
}

