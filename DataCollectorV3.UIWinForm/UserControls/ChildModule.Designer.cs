namespace DataCollectorV3.UIWinForm.UserControls
{

    partial class ChildModule
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.KeyBox = new System.Windows.Forms.TextBox();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.BtnClose = new System.Windows.Forms.Button();
            this.lblCopied = new System.Windows.Forms.Label();
            this.ChkBoxContainer = new System.Windows.Forms.Panel();
            this.ChkBox = new System.Windows.Forms.CheckBox();
            this.ChkBoxContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // KeyBox
            // 
            this.KeyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.KeyBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeyBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.KeyBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyBox.ForeColor = System.Drawing.Color.White;
            this.KeyBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.KeyBox.Location = new System.Drawing.Point(25, 0);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.Size = new System.Drawing.Size(100, 25);
            this.KeyBox.TabIndex = 2;
            this.KeyBox.Text = " Manual Key";
            this.KeyBox.Click += new System.EventHandler(this.TbxEnter);
            this.KeyBox.Enter += new System.EventHandler(this.TbxEnter);
            this.KeyBox.Leave += new System.EventHandler(this.KeyBox_Leave);
            // 
            // PathBox
            // 
            this.PathBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.PathBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.PathBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathBox.ForeColor = System.Drawing.Color.White;
            this.PathBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.PathBox.Location = new System.Drawing.Point(225, 0);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(200, 25);
            this.PathBox.TabIndex = 3;
            this.PathBox.Text = " XPath";
            this.PathBox.Click += new System.EventHandler(this.TbxEnter);
            this.PathBox.Enter += new System.EventHandler(this.TbxEnter);
            this.PathBox.Leave += new System.EventHandler(this.PathBox_Leave);
            // 
            // ResultBox
            // 
            this.ResultBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ResultBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ResultBox.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultBox.ForeColor = System.Drawing.Color.White;
            this.ResultBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.ResultBox.Location = new System.Drawing.Point(125, 0);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ReadOnly = true;
            this.ResultBox.Size = new System.Drawing.Size(100, 25);
            this.ResultBox.TabIndex = 4;
            this.ResultBox.Text = " Result";
            this.ResultBox.Click += new System.EventHandler(this.ResultBox_Click);
            this.ResultBox.Enter += new System.EventHandler(this.TbxEnter);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Location = new System.Drawing.Point(425, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(25, 25);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.Text = "X";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // lblCopied
            // 
            this.lblCopied.Location = new System.Drawing.Point(125, 0);
            this.lblCopied.Name = "lblCopied";
            this.lblCopied.Size = new System.Drawing.Size(100, 25);
            this.lblCopied.TabIndex = 4;
            this.lblCopied.Text = "Copied";
            this.lblCopied.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChkBoxContainer
            // 
            this.ChkBoxContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChkBoxContainer.Controls.Add(this.ChkBox);
            this.ChkBoxContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.ChkBoxContainer.Location = new System.Drawing.Point(0, 0);
            this.ChkBoxContainer.Name = "ChkBoxContainer";
            this.ChkBoxContainer.Size = new System.Drawing.Size(25, 25);
            this.ChkBoxContainer.TabIndex = 0;
            // 
            // ChkBox
            // 
            this.ChkBox.AutoSize = true;
            this.ChkBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ChkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkBox.FlatAppearance.BorderSize = 0;
            this.ChkBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ChkBox.Location = new System.Drawing.Point(6, 6);
            this.ChkBox.Name = "ChkBox";
            this.ChkBox.Size = new System.Drawing.Size(13, 12);
            this.ChkBox.TabIndex = 1;
            this.ChkBox.UseVisualStyleBackColor = false;
            this.ChkBox.CheckStateChanged += new System.EventHandler(this.ChkBox_CheckStateChanged);
            // 
            // ChildModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.PathBox);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.KeyBox);
            this.Controls.Add(this.ChkBoxContainer);
            this.Controls.Add(this.lblCopied);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ChildModule";
            this.Size = new System.Drawing.Size(450, 25);
            this.ChkBoxContainer.ResumeLayout(false);
            this.ChkBoxContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label lblCopied;
        private System.Windows.Forms.Panel ChkBoxContainer;
        private System.Windows.Forms.CheckBox ChkBox;
        private System.Windows.Forms.TextBox KeyBox;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.TextBox ResultBox;
    }
}
