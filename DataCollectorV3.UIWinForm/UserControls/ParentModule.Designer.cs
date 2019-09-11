namespace DataCollectorV3.UIWinForm.UserControls
{
    partial class ParentModule
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.ChildContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.PnlHeader = new System.Windows.Forms.Panel();
            this.PnlFooter = new System.Windows.Forms.Panel();
            this.TbxEnd = new System.Windows.Forms.TextBox();
            this.TbxSeconds = new System.Windows.Forms.TextBox();
            this.RbPer = new System.Windows.Forms.RadioButton();
            this.TbxCtPage = new System.Windows.Forms.TextBox();
            this.TbxStart = new System.Windows.Forms.TextBox();
            this.TbxSep = new System.Windows.Forms.TextBox();
            this.LblStart = new System.Windows.Forms.Label();
            this.LblControl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RbSeq = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxUrl = new System.Windows.Forms.TextBox();
            this.LblWeb = new System.Windows.Forms.Label();
            this.PnlOptions = new System.Windows.Forms.Panel();
            this.PnlOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(48)))));
            this.BtnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(0, 160);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(500, 30);
            this.BtnAdd.TabIndex = 10;
            this.BtnAdd.Text = "+ Add New Field";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // ChildContainer
            // 
            this.ChildContainer.AllowDrop = true;
            this.ChildContainer.AutoScroll = true;
            this.ChildContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(8)))));
            this.ChildContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ChildContainer.Location = new System.Drawing.Point(0, 205);
            this.ChildContainer.Name = "ChildContainer";
            this.ChildContainer.Size = new System.Drawing.Size(500, 10);
            this.ChildContainer.TabIndex = 9;
            this.ChildContainer.WrapContents = false;
            this.ChildContainer.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.Resizing);
            this.ChildContainer.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.Resizing);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Blue;
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(0, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(500, 30);
            this.BtnClose.TabIndex = 12;
            this.BtnClose.Text = "Close Form";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnStart.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnStart.FlatAppearance.BorderSize = 0;
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStart.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.ForeColor = System.Drawing.Color.White;
            this.BtnStart.Location = new System.Drawing.Point(0, 130);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(500, 30);
            this.BtnStart.TabIndex = 11;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = false;
            // 
            // PnlHeader
            // 
            this.PnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(8)))));
            this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlHeader.Location = new System.Drawing.Point(0, 190);
            this.PnlHeader.Name = "PnlHeader";
            this.PnlHeader.Size = new System.Drawing.Size(500, 15);
            this.PnlHeader.TabIndex = 18;
            // 
            // PnlFooter
            // 
            this.PnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(8)))));
            this.PnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFooter.Location = new System.Drawing.Point(0, 215);
            this.PnlFooter.Name = "PnlFooter";
            this.PnlFooter.Size = new System.Drawing.Size(500, 15);
            this.PnlFooter.TabIndex = 19;
            // 
            // TbxEnd
            // 
            this.TbxEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TbxEnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxEnd.Font = new System.Drawing.Font("Nirmala UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxEnd.ForeColor = System.Drawing.Color.Gainsboro;
            this.TbxEnd.Location = new System.Drawing.Point(173, 74);
            this.TbxEnd.Name = "TbxEnd";
            this.TbxEnd.Size = new System.Drawing.Size(41, 16);
            this.TbxEnd.TabIndex = 6;
            this.TbxEnd.Text = "10";
            this.TbxEnd.Enter += new System.EventHandler(this.TbxEnter);
            this.TbxEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxKeyPress);
            // 
            // TbxSeconds
            // 
            this.TbxSeconds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TbxSeconds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxSeconds.Font = new System.Drawing.Font("Nirmala UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxSeconds.ForeColor = System.Drawing.Color.Gainsboro;
            this.TbxSeconds.Location = new System.Drawing.Point(368, 74);
            this.TbxSeconds.Name = "TbxSeconds";
            this.TbxSeconds.Size = new System.Drawing.Size(40, 16);
            this.TbxSeconds.TabIndex = 8;
            this.TbxSeconds.Text = "10";
            this.TbxSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbxSeconds.Enter += new System.EventHandler(this.TbxEnter);
            this.TbxSeconds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxKeyPress);
            // 
            // RbPer
            // 
            this.RbPer.AutoSize = true;
            this.RbPer.Font = new System.Drawing.Font("Nirmala UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbPer.ForeColor = System.Drawing.Color.Gainsboro;
            this.RbPer.Location = new System.Drawing.Point(269, 53);
            this.RbPer.Name = "RbPer";
            this.RbPer.Size = new System.Drawing.Size(106, 19);
            this.RbPer.TabIndex = 7;
            this.RbPer.Text = "Periodic work : ";
            this.RbPer.UseVisualStyleBackColor = true;
            this.RbPer.CheckedChanged += new System.EventHandler(this.RbChanged);
            // 
            // TbxCtPage
            // 
            this.TbxCtPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TbxCtPage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxCtPage.Font = new System.Drawing.Font("Nirmala UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxCtPage.ForeColor = System.Drawing.Color.Gainsboro;
            this.TbxCtPage.Location = new System.Drawing.Point(297, 27);
            this.TbxCtPage.Name = "TbxCtPage";
            this.TbxCtPage.Size = new System.Drawing.Size(71, 16);
            this.TbxCtPage.TabIndex = 2;
            this.TbxCtPage.Text = "1";
            this.TbxCtPage.Enter += new System.EventHandler(this.TbxEnter);
            // 
            // TbxStart
            // 
            this.TbxStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TbxStart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxStart.Font = new System.Drawing.Font("Nirmala UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxStart.ForeColor = System.Drawing.Color.Gainsboro;
            this.TbxStart.Location = new System.Drawing.Point(102, 74);
            this.TbxStart.Name = "TbxStart";
            this.TbxStart.Size = new System.Drawing.Size(41, 16);
            this.TbxStart.TabIndex = 5;
            this.TbxStart.Text = "0";
            this.TbxStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TbxStart.Enter += new System.EventHandler(this.TbxEnter);
            this.TbxStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxKeyPress);
            // 
            // TbxSep
            // 
            this.TbxSep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TbxSep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxSep.Font = new System.Drawing.Font("Nirmala UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxSep.ForeColor = System.Drawing.Color.Gainsboro;
            this.TbxSep.Location = new System.Drawing.Point(381, 27);
            this.TbxSep.Name = "TbxSep";
            this.TbxSep.Size = new System.Drawing.Size(97, 16);
            this.TbxSep.TabIndex = 3;
            this.TbxSep.Text = ":";
            this.TbxSep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbxSep.Enter += new System.EventHandler(this.TbxEnter);
            // 
            // LblStart
            // 
            this.LblStart.AutoSize = true;
            this.LblStart.Font = new System.Drawing.Font("Nirmala UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStart.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblStart.Location = new System.Drawing.Point(38, 73);
            this.LblStart.Name = "LblStart";
            this.LblStart.Size = new System.Drawing.Size(131, 15);
            this.LblStart.TabIndex = 16;
            this.LblStart.Text = "Start from                    to";
            // 
            // LblControl
            // 
            this.LblControl.AutoSize = true;
            this.LblControl.Font = new System.Drawing.Font("Nirmala UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblControl.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblControl.Location = new System.Drawing.Point(294, 11);
            this.LblControl.Name = "LblControl";
            this.LblControl.Size = new System.Drawing.Size(76, 15);
            this.LblControl.TabIndex = 14;
            this.LblControl.Text = "Control Page";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(378, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Separator";
            // 
            // RbSeq
            // 
            this.RbSeq.AutoSize = true;
            this.RbSeq.Font = new System.Drawing.Font("Nirmala UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbSeq.ForeColor = System.Drawing.Color.Gainsboro;
            this.RbSeq.Location = new System.Drawing.Point(17, 53);
            this.RbSeq.Name = "RbSeq";
            this.RbSeq.Size = new System.Drawing.Size(170, 19);
            this.RbSeq.TabIndex = 4;
            this.RbSeq.Text = "Work on stated sub pages : ";
            this.RbSeq.UseVisualStyleBackColor = true;
            this.RbSeq.CheckedChanged += new System.EventHandler(this.RbChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(285, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Refresh every                     seconds";
            // 
            // TbxUrl
            // 
            this.TbxUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TbxUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxUrl.Font = new System.Drawing.Font("Nirmala UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxUrl.ForeColor = System.Drawing.Color.Gainsboro;
            this.TbxUrl.Location = new System.Drawing.Point(17, 27);
            this.TbxUrl.Name = "TbxUrl";
            this.TbxUrl.Size = new System.Drawing.Size(269, 16);
            this.TbxUrl.TabIndex = 1;
            this.TbxUrl.Text = "https://www.techpowerup.com/cpudb/";
            this.TbxUrl.Enter += new System.EventHandler(this.TbxEnter);
            // 
            // LblWeb
            // 
            this.LblWeb.AutoSize = true;
            this.LblWeb.Font = new System.Drawing.Font("Nirmala UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWeb.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblWeb.Location = new System.Drawing.Point(14, 11);
            this.LblWeb.Name = "LblWeb";
            this.LblWeb.Size = new System.Drawing.Size(99, 15);
            this.LblWeb.TabIndex = 13;
            this.LblWeb.Text = "Web page adress ";
            // 
            // PnlOptions
            // 
            this.PnlOptions.BackColor = System.Drawing.Color.Navy;
            this.PnlOptions.Controls.Add(this.TbxCtPage);
            this.PnlOptions.Controls.Add(this.TbxSep);
            this.PnlOptions.Controls.Add(this.TbxEnd);
            this.PnlOptions.Controls.Add(this.LblWeb);
            this.PnlOptions.Controls.Add(this.TbxUrl);
            this.PnlOptions.Controls.Add(this.RbSeq);
            this.PnlOptions.Controls.Add(this.label1);
            this.PnlOptions.Controls.Add(this.LblControl);
            this.PnlOptions.Controls.Add(this.TbxStart);
            this.PnlOptions.Controls.Add(this.RbPer);
            this.PnlOptions.Controls.Add(this.TbxSeconds);
            this.PnlOptions.Controls.Add(this.LblStart);
            this.PnlOptions.Controls.Add(this.label2);
            this.PnlOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlOptions.Location = new System.Drawing.Point(0, 30);
            this.PnlOptions.Name = "PnlOptions";
            this.PnlOptions.Size = new System.Drawing.Size(500, 100);
            this.PnlOptions.TabIndex = 0;
            // 
            // ParentModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.ChildContainer);
            this.Controls.Add(this.PnlHeader);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.PnlOptions);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.PnlFooter);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "ParentModule";
            this.Size = new System.Drawing.Size(500, 230);
            this.PnlOptions.ResumeLayout(false);
            this.PnlOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.FlowLayoutPanel ChildContainer;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Panel PnlHeader;
        private System.Windows.Forms.Panel PnlFooter;
        private System.Windows.Forms.Panel PnlOptions;
        private System.Windows.Forms.Label LblWeb;
        private System.Windows.Forms.TextBox TbxUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RbSeq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblControl;
        private System.Windows.Forms.Label LblStart;
        private System.Windows.Forms.TextBox TbxSep;
        private System.Windows.Forms.TextBox TbxStart;
        private System.Windows.Forms.TextBox TbxCtPage;
        private System.Windows.Forms.RadioButton RbPer;
        private System.Windows.Forms.TextBox TbxSeconds;
        private System.Windows.Forms.TextBox TbxEnd;
    }
}
