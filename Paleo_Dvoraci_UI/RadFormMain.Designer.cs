namespace Paleo_Dvoraci_UI
{
    partial class RadFormMain
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.fluentThemeMain = new Telerik.WinControls.Themes.FluentTheme();
            this.fluentDarkThemeMain = new Telerik.WinControls.Themes.FluentDarkTheme();
            this.radPanelDown = new Telerik.WinControls.UI.RadPanel();
            this.radPanelMiddle = new Telerik.WinControls.UI.RadPanel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.radGridViewUsers = new Telerik.WinControls.UI.RadGridView();
            this.radLabelUsers = new Telerik.WinControls.UI.RadLabel();
            this.radPanelUsersLeft = new Telerik.WinControls.UI.RadPanel();
            this.radScrollablePanelUsersRight = new Telerik.WinControls.UI.RadScrollablePanel();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelMiddle)).BeginInit();
            this.radPanelMiddle.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewUsers.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelUsersLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radScrollablePanelUsersRight)).BeginInit();
            this.radScrollablePanelUsersRight.PanelContainer.SuspendLayout();
            this.radScrollablePanelUsersRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanelDown
            // 
            this.radPanelDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.radPanelDown.Location = new System.Drawing.Point(0, 390);
            this.radPanelDown.Name = "radPanelDown";
            this.radPanelDown.Size = new System.Drawing.Size(795, 57);
            this.radPanelDown.TabIndex = 1;
            this.radPanelDown.ThemeName = "Fluent";
            // 
            // radPanelMiddle
            // 
            this.radPanelMiddle.Controls.Add(this.tabControl);
            this.radPanelMiddle.Controls.Add(this.radLabelUsers);
            this.radPanelMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radPanelMiddle.Location = new System.Drawing.Point(0, 0);
            this.radPanelMiddle.Name = "radPanelMiddle";
            this.radPanelMiddle.Size = new System.Drawing.Size(795, 390);
            this.radPanelMiddle.TabIndex = 4;
            this.radPanelMiddle.ThemeName = "Fluent";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageMain);
            this.tabControl.Controls.Add(this.tabPageUsers);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(795, 390);
            this.tabControl.TabIndex = 2;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabPageMain.Location = new System.Drawing.Point(4, 32);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(1348, 401);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Hlavní strana";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageUsers.Controls.Add(this.radScrollablePanelUsersRight);
            this.tabPageUsers.Controls.Add(this.radPanelUsersLeft);
            this.tabPageUsers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabPageUsers.Location = new System.Drawing.Point(4, 32);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsers.Size = new System.Drawing.Size(787, 354);
            this.tabPageUsers.TabIndex = 1;
            this.tabPageUsers.Text = "Uživatelé";
            this.tabPageUsers.Enter += new System.EventHandler(this.tabPageUsers_Enter);
            // 
            // radGridViewUsers
            // 
            this.radGridViewUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.radGridViewUsers.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radGridViewUsers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radGridViewUsers.ForeColor = System.Drawing.Color.Black;
            this.radGridViewUsers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridViewUsers.Location = new System.Drawing.Point(0, 0);
            this.radGridViewUsers.Margin = new System.Windows.Forms.Padding(6);
            // 
            // 
            // 
            this.radGridViewUsers.MasterTemplate.AllowAddNewRow = false;
            this.radGridViewUsers.MasterTemplate.AllowColumnChooser = false;
            this.radGridViewUsers.MasterTemplate.AllowColumnReorder = false;
            this.radGridViewUsers.MasterTemplate.AllowColumnResize = false;
            this.radGridViewUsers.MasterTemplate.AllowDragToGroup = false;
            this.radGridViewUsers.MasterTemplate.AllowRowResize = false;
            this.radGridViewUsers.MasterTemplate.AutoGenerateColumns = false;
            this.radGridViewUsers.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn2.AllowGroup = false;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Name";
            gridViewTextBoxColumn2.HeaderText = "Jméno";
            gridViewTextBoxColumn2.MinWidth = 10;
            gridViewTextBoxColumn2.Name = "Name";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.VisibleInColumnChooser = false;
            gridViewTextBoxColumn2.Width = 298;
            this.radGridViewUsers.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn2});
            this.radGridViewUsers.MasterTemplate.EnableGrouping = false;
            this.radGridViewUsers.MasterTemplate.ShowRowHeaderColumn = false;
            this.radGridViewUsers.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.radGridViewUsers.Name = "radGridViewUsers";
            this.radGridViewUsers.ReadOnly = true;
            this.radGridViewUsers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridViewUsers.ShowGroupPanel = false;
            this.radGridViewUsers.Size = new System.Drawing.Size(300, 346);
            this.radGridViewUsers.TabIndex = 0;
            this.radGridViewUsers.ThemeName = "Fluent";
            // 
            // radLabelUsers
            // 
            this.radLabelUsers.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.radLabelUsers.Location = new System.Drawing.Point(996, 4);
            this.radLabelUsers.Name = "radLabelUsers";
            this.radLabelUsers.Size = new System.Drawing.Size(186, 21);
            this.radLabelUsers.TabIndex = 1;
            this.radLabelUsers.Text = "Seznam uživatelů v jídelníčku:";
            // 
            // radPanelUsersLeft
            // 
            this.radPanelUsersLeft.AutoSize = true;
            this.radPanelUsersLeft.BackColor = System.Drawing.Color.Transparent;
            this.radPanelUsersLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.radPanelUsersLeft.Location = new System.Drawing.Point(3, 3);
            this.radPanelUsersLeft.Name = "radPanelUsersLeft";
            this.radPanelUsersLeft.Size = new System.Drawing.Size(2, 348);
            this.radPanelUsersLeft.TabIndex = 1;
            this.radPanelUsersLeft.ThemeName = "ControlDefault";
            // 
            // radScrollablePanelUsersRight
            // 
            this.radScrollablePanelUsersRight.AutoSize = true;
            this.radScrollablePanelUsersRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.radScrollablePanelUsersRight.Location = new System.Drawing.Point(482, 3);
            this.radScrollablePanelUsersRight.Name = "radScrollablePanelUsersRight";
            // 
            // radScrollablePanelUsersRight.PanelContainer
            // 
            this.radScrollablePanelUsersRight.PanelContainer.Controls.Add(this.radGridViewUsers);
            this.radScrollablePanelUsersRight.PanelContainer.Size = new System.Drawing.Size(300, 346);
            this.radScrollablePanelUsersRight.Size = new System.Drawing.Size(302, 348);
            this.radScrollablePanelUsersRight.TabIndex = 2;
            // 
            // RadFormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 447);
            this.Controls.Add(this.radPanelMiddle);
            this.Controls.Add(this.radPanelDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RadFormMain";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Paleo strava | Dvořákovi";
            this.ThemeName = "Fluent";
            ((System.ComponentModel.ISupportInitialize)(this.radPanelDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelMiddle)).EndInit();
            this.radPanelMiddle.ResumeLayout(false);
            this.radPanelMiddle.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageUsers.ResumeLayout(false);
            this.tabPageUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewUsers.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabelUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanelUsersLeft)).EndInit();
            this.radScrollablePanelUsersRight.PanelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radScrollablePanelUsersRight)).EndInit();
            this.radScrollablePanelUsersRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.FluentTheme fluentThemeMain;
        private Telerik.WinControls.Themes.FluentDarkTheme fluentDarkThemeMain;
        private Telerik.WinControls.UI.RadPanel radPanelDown;
        private Telerik.WinControls.UI.RadPanel radPanelMiddle;
        private Telerik.WinControls.UI.RadLabel radLabelUsers;
        private Telerik.WinControls.UI.RadGridView radGridViewUsers;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageUsers;
        private Telerik.WinControls.UI.RadScrollablePanel radScrollablePanelUsersRight;
        private Telerik.WinControls.UI.RadPanel radPanelUsersLeft;
    }
}