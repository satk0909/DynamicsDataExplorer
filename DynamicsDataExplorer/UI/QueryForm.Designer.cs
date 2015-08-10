﻿namespace DynamicsDataExplorer.UI
{
    partial class QueryForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.btnSaveConnectSetting = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.tabQuery = new System.Windows.Forms.TabPage();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.cmbAttributes = new System.Windows.Forms.ComboBox();
            this.txtCondValue = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btnQuery = new System.Windows.Forms.Button();
            this.cmbEntities = new System.Windows.Forms.ComboBox();
            this.btnGetAttributes = new System.Windows.Forms.Button();
            this.tabColumnSetting = new System.Windows.Forms.TabPage();
            this.btnLoadColumnSetting = new System.Windows.Forms.Button();
            this.btnSaveColumnSetting = new System.Windows.Forms.Button();
            this.btnColumnSettingBottom = new System.Windows.Forms.Button();
            this.btnColumnSettingDown = new System.Windows.Forms.Button();
            this.btnColumnSettingUp = new System.Windows.Forms.Button();
            this.btnColumnSettingTop = new System.Windows.Forms.Button();
            this.lblColumnSettingNotice = new System.Windows.Forms.Label();
            this.lstColumnSetting = new System.Windows.Forms.ListBox();
            this.tabCtrl.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.tabColumnSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tabLogin);
            this.tabCtrl.Controls.Add(this.tabQuery);
            this.tabCtrl.Controls.Add(this.tabColumnSetting);
            this.tabCtrl.Location = new System.Drawing.Point(3, 2);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(1181, 750);
            this.tabCtrl.TabIndex = 4;
            // 
            // tabLogin
            // 
            this.tabLogin.BackColor = System.Drawing.Color.LightGray;
            this.tabLogin.Controls.Add(this.btnSaveConnectSetting);
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Controls.Add(this.lblUrl);
            this.tabLogin.Controls.Add(this.lblPass);
            this.tabLogin.Controls.Add(this.lblUser);
            this.tabLogin.Controls.Add(this.txtPass);
            this.tabLogin.Controls.Add(this.txtUrl);
            this.tabLogin.Controls.Add(this.txtUser);
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(1173, 724);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "ログイン";
            // 
            // btnSaveConnectSetting
            // 
            this.btnSaveConnectSetting.Location = new System.Drawing.Point(233, 137);
            this.btnSaveConnectSetting.Name = "btnSaveConnectSetting";
            this.btnSaveConnectSetting.Size = new System.Drawing.Size(100, 23);
            this.btnSaveConnectSetting.TabIndex = 4;
            this.btnSaveConnectSetting.Text = "接続情報を保存";
            this.btnSaveConnectSetting.UseVisualStyleBackColor = true;
            this.btnSaveConnectSetting.Click += new System.EventHandler(this.btnSaveConnectSetting_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(133, 137);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "ログイン";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(91, 95);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(27, 12);
            this.lblUrl.TabIndex = 5;
            this.lblUrl.Text = "URL";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(66, 60);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(52, 12);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "パスワード";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(83, 25);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(35, 12);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "ユーザ";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(133, 60);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(300, 19);
            this.txtPass.TabIndex = 1;
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(133, 95);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(450, 19);
            this.txtUrl.TabIndex = 2;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(133, 25);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(300, 19);
            this.txtUser.TabIndex = 0;
            // 
            // tabQuery
            // 
            this.tabQuery.BackColor = System.Drawing.Color.LightGray;
            this.tabQuery.Controls.Add(this.cmbOperator);
            this.tabQuery.Controls.Add(this.cmbAttributes);
            this.tabQuery.Controls.Add(this.txtCondValue);
            this.tabQuery.Controls.Add(this.dataGrid);
            this.tabQuery.Controls.Add(this.btnQuery);
            this.tabQuery.Controls.Add(this.cmbEntities);
            this.tabQuery.Controls.Add(this.btnGetAttributes);
            this.tabQuery.Location = new System.Drawing.Point(4, 22);
            this.tabQuery.Name = "tabQuery";
            this.tabQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuery.Size = new System.Drawing.Size(1173, 724);
            this.tabQuery.TabIndex = 1;
            this.tabQuery.Text = "データ";
            // 
            // cmbOperator
            // 
            this.cmbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Location = new System.Drawing.Point(745, 18);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(121, 20);
            this.cmbOperator.TabIndex = 4;
            // 
            // cmbAttributes
            // 
            this.cmbAttributes.FormattingEnabled = true;
            this.cmbAttributes.Location = new System.Drawing.Point(470, 18);
            this.cmbAttributes.Name = "cmbAttributes";
            this.cmbAttributes.Size = new System.Drawing.Size(269, 20);
            this.cmbAttributes.TabIndex = 3;
            // 
            // txtCondValue
            // 
            this.txtCondValue.Location = new System.Drawing.Point(873, 18);
            this.txtCondValue.Name = "txtCondValue";
            this.txtCondValue.Size = new System.Drawing.Size(269, 19);
            this.txtCondValue.TabIndex = 5;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToOrderColumns = true;
            this.dataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(10, 83);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 21;
            this.dataGrid.Size = new System.Drawing.Size(1157, 614);
            this.dataGrid.TabIndex = 9;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(1005, 43);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(137, 23);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "データ取得（F10）";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // cmbEntities
            // 
            this.cmbEntities.FormattingEnabled = true;
            this.cmbEntities.Location = new System.Drawing.Point(16, 15);
            this.cmbEntities.Name = "cmbEntities";
            this.cmbEntities.Size = new System.Drawing.Size(375, 20);
            this.cmbEntities.TabIndex = 1;
            // 
            // btnGetAttributes
            // 
            this.btnGetAttributes.Location = new System.Drawing.Point(316, 41);
            this.btnGetAttributes.Name = "btnGetAttributes";
            this.btnGetAttributes.Size = new System.Drawing.Size(75, 23);
            this.btnGetAttributes.TabIndex = 2;
            this.btnGetAttributes.Text = "定義取得";
            this.btnGetAttributes.UseVisualStyleBackColor = true;
            this.btnGetAttributes.Click += new System.EventHandler(this.btnGetAttributes_Click);
            // 
            // tabColumnSetting
            // 
            this.tabColumnSetting.BackColor = System.Drawing.Color.LightGray;
            this.tabColumnSetting.Controls.Add(this.btnLoadColumnSetting);
            this.tabColumnSetting.Controls.Add(this.btnSaveColumnSetting);
            this.tabColumnSetting.Controls.Add(this.btnColumnSettingBottom);
            this.tabColumnSetting.Controls.Add(this.btnColumnSettingDown);
            this.tabColumnSetting.Controls.Add(this.btnColumnSettingUp);
            this.tabColumnSetting.Controls.Add(this.btnColumnSettingTop);
            this.tabColumnSetting.Controls.Add(this.lblColumnSettingNotice);
            this.tabColumnSetting.Controls.Add(this.lstColumnSetting);
            this.tabColumnSetting.Location = new System.Drawing.Point(4, 22);
            this.tabColumnSetting.Name = "tabColumnSetting";
            this.tabColumnSetting.Size = new System.Drawing.Size(1173, 724);
            this.tabColumnSetting.TabIndex = 0;
            this.tabColumnSetting.Text = "カラム設定";
            // 
            // btnLoadColumnSetting
            // 
            this.btnLoadColumnSetting.Location = new System.Drawing.Point(470, 318);
            this.btnLoadColumnSetting.Name = "btnLoadColumnSetting";
            this.btnLoadColumnSetting.Size = new System.Drawing.Size(177, 23);
            this.btnLoadColumnSetting.TabIndex = 7;
            this.btnLoadColumnSetting.Text = "保存した設定を復元（F11）";
            this.btnLoadColumnSetting.UseVisualStyleBackColor = true;
            this.btnLoadColumnSetting.Click += new System.EventHandler(this.btnLoadColumnSetting_Click);
            // 
            // btnSaveColumnSetting
            // 
            this.btnSaveColumnSetting.Location = new System.Drawing.Point(470, 279);
            this.btnSaveColumnSetting.Name = "btnSaveColumnSetting";
            this.btnSaveColumnSetting.Size = new System.Drawing.Size(139, 23);
            this.btnSaveColumnSetting.TabIndex = 6;
            this.btnSaveColumnSetting.Text = "設定を保存（F12）";
            this.btnSaveColumnSetting.UseVisualStyleBackColor = true;
            this.btnSaveColumnSetting.Click += new System.EventHandler(this.btnSaveColumnSetting_Click);
            // 
            // btnColumnSettingBottom
            // 
            this.btnColumnSettingBottom.Location = new System.Drawing.Point(470, 170);
            this.btnColumnSettingBottom.Name = "btnColumnSettingBottom";
            this.btnColumnSettingBottom.Size = new System.Drawing.Size(75, 23);
            this.btnColumnSettingBottom.TabIndex = 5;
            this.btnColumnSettingBottom.Text = "一番下";
            this.btnColumnSettingBottom.UseVisualStyleBackColor = true;
            this.btnColumnSettingBottom.Click += new System.EventHandler(this.btnColumnSettingBottom_Click);
            // 
            // btnColumnSettingDown
            // 
            this.btnColumnSettingDown.Location = new System.Drawing.Point(470, 130);
            this.btnColumnSettingDown.Name = "btnColumnSettingDown";
            this.btnColumnSettingDown.Size = new System.Drawing.Size(75, 23);
            this.btnColumnSettingDown.TabIndex = 4;
            this.btnColumnSettingDown.Text = "下";
            this.btnColumnSettingDown.UseVisualStyleBackColor = true;
            this.btnColumnSettingDown.Click += new System.EventHandler(this.btnColumnSettingDown_Click);
            // 
            // btnColumnSettingUp
            // 
            this.btnColumnSettingUp.Location = new System.Drawing.Point(470, 90);
            this.btnColumnSettingUp.Name = "btnColumnSettingUp";
            this.btnColumnSettingUp.Size = new System.Drawing.Size(75, 23);
            this.btnColumnSettingUp.TabIndex = 3;
            this.btnColumnSettingUp.Text = "上";
            this.btnColumnSettingUp.UseVisualStyleBackColor = true;
            this.btnColumnSettingUp.Click += new System.EventHandler(this.btnColumnSettingUp_Click);
            // 
            // btnColumnSettingTop
            // 
            this.btnColumnSettingTop.Location = new System.Drawing.Point(470, 50);
            this.btnColumnSettingTop.Name = "btnColumnSettingTop";
            this.btnColumnSettingTop.Size = new System.Drawing.Size(75, 23);
            this.btnColumnSettingTop.TabIndex = 2;
            this.btnColumnSettingTop.Text = "一番上";
            this.btnColumnSettingTop.UseVisualStyleBackColor = true;
            this.btnColumnSettingTop.Click += new System.EventHandler(this.btnColumnSettingTop_Click);
            // 
            // lblColumnSettingNotice
            // 
            this.lblColumnSettingNotice.AutoSize = true;
            this.lblColumnSettingNotice.Location = new System.Drawing.Point(603, 51);
            this.lblColumnSettingNotice.Name = "lblColumnSettingNotice";
            this.lblColumnSettingNotice.Size = new System.Drawing.Size(200, 48);
            this.lblColumnSettingNotice.TabIndex = 1;
            this.lblColumnSettingNotice.Text = "各ボタンでカラムを移動します。\r\nDrag&&Dropで入れ替えることもできます。\r\n\r\n設定後はデータを取得しなおしてください。";
            // 
            // lstColumnSetting
            // 
            this.lstColumnSetting.AllowDrop = true;
            this.lstColumnSetting.FormattingEnabled = true;
            this.lstColumnSetting.ItemHeight = 12;
            this.lstColumnSetting.Location = new System.Drawing.Point(18, 27);
            this.lstColumnSetting.Name = "lstColumnSetting";
            this.lstColumnSetting.Size = new System.Drawing.Size(428, 688);
            this.lstColumnSetting.TabIndex = 0;
            this.lstColumnSetting.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstColumnSetting_DragDrop);
            this.lstColumnSetting.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstColumnSetting_DragEnter);
            this.lstColumnSetting.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstColumnSetting_MouseDown);
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 762);
            this.Controls.Add(this.tabCtrl);
            this.KeyPreview = true;
            this.Name = "QueryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dynamicsデータ";
            this.Load += new System.EventHandler(this.QueryForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.QueryForm_KeyDown);
            this.tabCtrl.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabQuery.ResumeLayout(false);
            this.tabQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.tabColumnSetting.ResumeLayout(false);
            this.tabColumnSetting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.TabPage tabQuery;
        private System.Windows.Forms.Button btnGetAttributes;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ComboBox cmbEntities;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtCondValue;
        private System.Windows.Forms.ComboBox cmbAttributes;
        private System.Windows.Forms.Button btnSaveConnectSetting;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.TabPage tabColumnSetting;
        private System.Windows.Forms.ListBox lstColumnSetting;
        private System.Windows.Forms.Label lblColumnSettingNotice;
        private System.Windows.Forms.Button btnColumnSettingBottom;
        private System.Windows.Forms.Button btnColumnSettingDown;
        private System.Windows.Forms.Button btnColumnSettingUp;
        private System.Windows.Forms.Button btnColumnSettingTop;
        private System.Windows.Forms.Button btnSaveColumnSetting;
        private System.Windows.Forms.Button btnLoadColumnSetting;
    }
}

