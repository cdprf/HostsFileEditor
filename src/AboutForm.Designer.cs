﻿// <copyright file="AboutForm.Designer.cs" company="N/A">
// Copyright 2025 Scott M. Lerch
// 
// This file is part of HostsFileEditor.
// 
// HostsFileEditor is free software: you can redistribute it and/or modify it 
// under the terms of the GNU General Public License as published by the Free 
// Software Foundation, either version 2 of the License, or (at your option)
// any later version.
// 
// HostsFileEditor is distributed in the hope that it will be useful, but 
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
// or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for
// more details.
// 
// You should have received a copy of the GNU General Public   License along
// with HostsFileEditor. If not, see http://www.gnu.org/licenses/.
// </copyright>

namespace HostsFileEditor;

/// <summary>
/// The about dialog.
/// </summary>
partial class AboutForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
        this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
        this.logoPictureBox = new System.Windows.Forms.PictureBox();
        this.labelProductName = new System.Windows.Forms.Label();
        this.labelVersion = new System.Windows.Forms.Label();
        this.labelCopyright = new System.Windows.Forms.Label();
        this.textBoxDescription = new System.Windows.Forms.TextBox();
        this.okButton = new System.Windows.Forms.Button();
        this.githubLink = new System.Windows.Forms.LinkLabel();
        this.tableLayoutPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
        this.SuspendLayout();
        // 
        // tableLayoutPanel
        // 
        this.tableLayoutPanel.ColumnCount = 2;
        this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
        this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
        this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
        this.tableLayoutPanel.Controls.Add(this.labelProductName, 1, 0);
        this.tableLayoutPanel.Controls.Add(this.labelVersion, 1, 1);
        this.tableLayoutPanel.Controls.Add(this.labelCopyright, 1, 2);
        this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 1, 4);
        this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
        this.tableLayoutPanel.Controls.Add(this.githubLink, 1, 3);
        this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tableLayoutPanel.Location = new System.Drawing.Point(9, 9);
        this.tableLayoutPanel.Name = "tableLayoutPanel";
        this.tableLayoutPanel.RowCount = 6;
        this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
        this.tableLayoutPanel.Size = new System.Drawing.Size(417, 265);
        this.tableLayoutPanel.TabIndex = 0;
        // 
        // logoPictureBox
        // 
        this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
        this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
        this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
        this.logoPictureBox.Name = "logoPictureBox";
        this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
        this.logoPictureBox.Size = new System.Drawing.Size(131, 259);
        this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        this.logoPictureBox.TabIndex = 12;
        this.logoPictureBox.TabStop = false;
        // 
        // labelProductName
        // 
        this.labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
        this.labelProductName.Location = new System.Drawing.Point(143, 0);
        this.labelProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
        this.labelProductName.MaximumSize = new System.Drawing.Size(0, 17);
        this.labelProductName.Name = "labelProductName";
        this.labelProductName.Size = new System.Drawing.Size(271, 17);
        this.labelProductName.TabIndex = 19;
        this.labelProductName.Text = "Product Name";
        this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // labelVersion
        // 
        this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
        this.labelVersion.Location = new System.Drawing.Point(143, 26);
        this.labelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
        this.labelVersion.MaximumSize = new System.Drawing.Size(0, 17);
        this.labelVersion.Name = "labelVersion";
        this.labelVersion.Size = new System.Drawing.Size(271, 17);
        this.labelVersion.TabIndex = 0;
        this.labelVersion.Text = "Version";
        this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // labelCopyright
        // 
        this.labelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
        this.labelCopyright.Location = new System.Drawing.Point(143, 52);
        this.labelCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
        this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 17);
        this.labelCopyright.Name = "labelCopyright";
        this.labelCopyright.Size = new System.Drawing.Size(271, 17);
        this.labelCopyright.TabIndex = 21;
        this.labelCopyright.Text = "Copyright";
        this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        // 
        // textBoxDescription
        // 
        this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
        this.textBoxDescription.Location = new System.Drawing.Point(143, 107);
        this.textBoxDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
        this.textBoxDescription.Multiline = true;
        this.textBoxDescription.Name = "textBoxDescription";
        this.textBoxDescription.ReadOnly = true;
        this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        this.textBoxDescription.Size = new System.Drawing.Size(271, 126);
        this.textBoxDescription.TabIndex = 23;
        this.textBoxDescription.TabStop = false;
        this.textBoxDescription.Text = "Description";
        // 
        // okButton
        // 
        this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.okButton.Location = new System.Drawing.Point(339, 239);
        this.okButton.Name = "okButton";
        this.okButton.Size = new System.Drawing.Size(75, 23);
        this.okButton.TabIndex = 24;
        this.okButton.Text = "&OK";
        // 
        // githubLink
        // 
        this.githubLink.AutoSize = true;
        this.githubLink.Location = new System.Drawing.Point(143, 78);
        this.githubLink.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
        this.githubLink.Name = "githubLink";
        this.githubLink.Size = new System.Drawing.Size(221, 13);
        this.githubLink.TabIndex = 25;
        this.githubLink.TabStop = true;
        this.githubLink.Text = "https://github.com/scottlerch/HostsFileEditor";
        this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLinkClicked);
        // 
        // AboutForm
        // 
        this.AcceptButton = this.okButton;
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(435, 283);
        this.Controls.Add(this.tableLayoutPanel);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "AboutForm";
        this.Padding = new System.Windows.Forms.Padding(9);
        this.ShowIcon = false;
        this.ShowInTaskbar = false;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "AboutForm";
        this.tableLayoutPanel.ResumeLayout(false);
        this.tableLayoutPanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    private System.Windows.Forms.PictureBox logoPictureBox;
    private System.Windows.Forms.Label labelProductName;
    private System.Windows.Forms.Label labelVersion;
    private System.Windows.Forms.Label labelCopyright;
    private System.Windows.Forms.TextBox textBoxDescription;
    private System.Windows.Forms.Button okButton;
    private System.Windows.Forms.LinkLabel githubLink;
}
