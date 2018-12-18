﻿namespace TravelExperts
{
    partial class PackagesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackagesForm));
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.tpStartDate = new System.Windows.Forms.DateTimePicker();
            this.tpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.gbDates = new System.Windows.Forms.GroupBox();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.txtAgComm = new System.Windows.Forms.TextBox();
            this.lblAgComm = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAddProdSup = new System.Windows.Forms.ToolStripButton();
            this.tsbEditProdSup = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteProdSup = new System.Windows.Forms.ToolStripButton();
            this.dgvPackProdSuppl = new System.Windows.Forms.DataGridView();
            this.gbDates.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackProdSuppl)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(48, 56);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(120, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(174, 26);
            this.txtName.TabIndex = 1;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(16, 40);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(83, 20);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start Date";
            // 
            // tpStartDate
            // 
            this.tpStartDate.CustomFormat = "dd MMM yyyy";
            this.tpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpStartDate.Location = new System.Drawing.Point(129, 34);
            this.tpStartDate.Name = "tpStartDate";
            this.tpStartDate.Size = new System.Drawing.Size(144, 26);
            this.tpStartDate.TabIndex = 3;
            this.tpStartDate.Value = new System.DateTime(2000, 1, 1, 20, 11, 0, 0);
            // 
            // tpEndDate
            // 
            this.tpEndDate.CustomFormat = "dd MMM yyyy";
            this.tpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tpEndDate.Location = new System.Drawing.Point(129, 92);
            this.tpEndDate.Name = "tpEndDate";
            this.tpEndDate.Size = new System.Drawing.Size(144, 26);
            this.tpEndDate.TabIndex = 5;
            this.tpEndDate.Value = new System.DateTime(2000, 1, 1, 20, 13, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "End Date";
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesc.Location = new System.Drawing.Point(120, 198);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(492, 26);
            this.txtDesc.TabIndex = 7;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(13, 201);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(89, 20);
            this.lblDesc.TabIndex = 6;
            this.lblDesc.Text = "Description";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(120, 100);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(136, 26);
            this.txtId.TabIndex = 9;
            this.txtId.Visible = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(73, 105);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 20);
            this.lblId.TabIndex = 8;
            this.lblId.Text = "ID";
            this.lblId.Visible = false;
            // 
            // gbDates
            // 
            this.gbDates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDates.Controls.Add(this.lblStartDate);
            this.gbDates.Controls.Add(this.tpStartDate);
            this.gbDates.Controls.Add(this.label1);
            this.gbDates.Controls.Add(this.tpEndDate);
            this.gbDates.Location = new System.Drawing.Point(339, 12);
            this.gbDates.Name = "gbDates";
            this.gbDates.Size = new System.Drawing.Size(281, 131);
            this.gbDates.TabIndex = 10;
            this.gbDates.TabStop = false;
            this.gbDates.Text = "Dates";
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(120, 150);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(174, 26);
            this.txtBasePrice.TabIndex = 12;
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Location = new System.Drawing.Point(17, 153);
            this.lblBasePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(85, 20);
            this.lblBasePrice.TabIndex = 11;
            this.lblBasePrice.Text = "Base Price";
            // 
            // txtAgComm
            // 
            this.txtAgComm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAgComm.Location = new System.Drawing.Point(468, 147);
            this.txtAgComm.Name = "txtAgComm";
            this.txtAgComm.Size = new System.Drawing.Size(144, 26);
            this.txtAgComm.TabIndex = 14;
            // 
            // lblAgComm
            // 
            this.lblAgComm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAgComm.AutoSize = true;
            this.lblAgComm.Location = new System.Drawing.Point(317, 153);
            this.lblAgComm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgComm.Name = "lblAgComm";
            this.lblAgComm.Size = new System.Drawing.Size(144, 20);
            this.lblAgComm.TabIndex = 13;
            this.lblAgComm.Text = "Agency Commision";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(487, 433);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 36);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(339, 433);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 36);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvPackProdSuppl);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Location = new System.Drawing.Point(17, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 189);
            this.panel1.TabIndex = 17;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddProdSup,
            this.tsbEditProdSup,
            this.tsbDeleteProdSup});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(595, 35);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAddProdSup
            // 
            this.tsbAddProdSup.AutoSize = false;
            this.tsbAddProdSup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddProdSup.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddProdSup.Image")));
            this.tsbAddProdSup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddProdSup.Name = "tsbAddProdSup";
            this.tsbAddProdSup.Size = new System.Drawing.Size(32, 32);
            this.tsbAddProdSup.Text = "New";
            // 
            // tsbEditProdSup
            // 
            this.tsbEditProdSup.AutoSize = false;
            this.tsbEditProdSup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditProdSup.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditProdSup.Image")));
            this.tsbEditProdSup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditProdSup.Name = "tsbEditProdSup";
            this.tsbEditProdSup.Size = new System.Drawing.Size(32, 32);
            this.tsbEditProdSup.Text = "Change";
            // 
            // tsbDeleteProdSup
            // 
            this.tsbDeleteProdSup.AutoSize = false;
            this.tsbDeleteProdSup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeleteProdSup.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeleteProdSup.Image")));
            this.tsbDeleteProdSup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteProdSup.Name = "tsbDeleteProdSup";
            this.tsbDeleteProdSup.Size = new System.Drawing.Size(32, 32);
            this.tsbDeleteProdSup.Text = "toolStripButton3";
            // 
            // dgvPackProdSuppl
            // 
            this.dgvPackProdSuppl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPackProdSuppl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPackProdSuppl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackProdSuppl.Location = new System.Drawing.Point(0, 32);
            this.dgvPackProdSuppl.Name = "dgvPackProdSuppl";
            this.dgvPackProdSuppl.Size = new System.Drawing.Size(595, 156);
            this.dgvPackProdSuppl.TabIndex = 1;
            // 
            // PackagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 481);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAgComm);
            this.Controls.Add(this.lblAgComm);
            this.Controls.Add(this.txtBasePrice);
            this.Controls.Add(this.lblBasePrice);
            this.Controls.Add(this.gbDates);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(270, 70);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PackagesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PackagesForm";
            this.Load += new System.EventHandler(this.PackagesForm_Load);
            this.gbDates.ResumeLayout(false);
            this.gbDates.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackProdSuppl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker tpStartDate;
        private System.Windows.Forms.DateTimePicker tpEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.GroupBox gbDates;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.TextBox txtAgComm;
        private System.Windows.Forms.Label lblAgComm;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPackProdSuppl;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAddProdSup;
        private System.Windows.Forms.ToolStripButton tsbEditProdSup;
        private System.Windows.Forms.ToolStripButton tsbDeleteProdSup;
    }
}