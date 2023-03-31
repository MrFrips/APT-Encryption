namespace encryption
{
    partial class Encryption
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encryption));
            this.GoEncryption = new System.Windows.Forms.Button();
            this.OutResult = new System.Windows.Forms.TextBox();
            this.ToolMenuAll = new System.Windows.Forms.ToolStrip();
            this.MenuButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.открытьФайлСТекстомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ввестиКлючToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.StripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.ProgressTimer = new System.Windows.Forms.Timer(this.components);
            this.StringKeyMenu = new System.Windows.Forms.Label();
            this.TrytoEncryptLabel = new System.Windows.Forms.Label();
            this.ToolMenuAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // GoEncryption
            // 
            this.GoEncryption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.GoEncryption.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GoEncryption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoEncryption.ForeColor = System.Drawing.Color.White;
            this.GoEncryption.Location = new System.Drawing.Point(685, 326);
            this.GoEncryption.Name = "GoEncryption";
            this.GoEncryption.Size = new System.Drawing.Size(103, 23);
            this.GoEncryption.TabIndex = 0;
            this.GoEncryption.Text = "Зашифровать?";
            this.GoEncryption.UseVisualStyleBackColor = false;
            this.GoEncryption.Click += new System.EventHandler(this.GoEncryption_Click);
            // 
            // OutResult
            // 
            this.OutResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.OutResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.OutResult.ForeColor = System.Drawing.Color.White;
            this.OutResult.Location = new System.Drawing.Point(12, 355);
            this.OutResult.Multiline = true;
            this.OutResult.Name = "OutResult";
            this.OutResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutResult.Size = new System.Drawing.Size(776, 83);
            this.OutResult.TabIndex = 1;
            // 
            // ToolMenuAll
            // 
            this.ToolMenuAll.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolMenuAll.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuButton,
            this.toolStripSeparator1,
            this.StripProgressBar});
            this.ToolMenuAll.Location = new System.Drawing.Point(0, 0);
            this.ToolMenuAll.Name = "ToolMenuAll";
            this.ToolMenuAll.Size = new System.Drawing.Size(800, 25);
            this.ToolMenuAll.TabIndex = 4;
            this.ToolMenuAll.Text = "ToolMenuAll";
            // 
            // MenuButton
            // 
            this.MenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьФайлСТекстомToolStripMenuItem,
            this.ToolMenu,
            this.ввестиКлючToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.MenuButton.Image = global::encryption.Properties.Resources.Button_C_;
            this.MenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(29, 22);
            this.MenuButton.Text = "Menu";
            this.MenuButton.ToolTipText = "ButtonMenu";
            // 
            // открытьФайлСТекстомToolStripMenuItem
            // 
            this.открытьФайлСТекстомToolStripMenuItem.Name = "открытьФайлСТекстомToolStripMenuItem";
            this.открытьФайлСТекстомToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.открытьФайлСТекстомToolStripMenuItem.Text = "Открыть файл?";
            this.открытьФайлСТекстомToolStripMenuItem.Click += new System.EventHandler(this.открытьФайлСТекстомToolStripMenuItem_Click);
            // 
            // ToolMenu
            // 
            this.ToolMenu.Name = "ToolMenu";
            this.ToolMenu.Size = new System.Drawing.Size(190, 22);
            this.ToolMenu.Text = "Сохранить в файл?";
            this.ToolMenu.Click += new System.EventHandler(this.ToolMenu_Click);
            // 
            // ввестиКлючToolStripMenuItem
            // 
            this.ввестиКлючToolStripMenuItem.Name = "ввестиКлючToolStripMenuItem";
            this.ввестиКлючToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.ввестиКлючToolStripMenuItem.Text = "Ввести ключ";
            this.ввестиКлючToolStripMenuItem.Click += new System.EventHandler(this.ввестиКлючToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.exitToolStripMenuItem.Text = "Закрыть";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // StripProgressBar
            // 
            this.StripProgressBar.ForeColor = System.Drawing.Color.Orange;
            this.StripProgressBar.Name = "StripProgressBar";
            this.StripProgressBar.Size = new System.Drawing.Size(100, 22);
            // 
            // StringKeyMenu
            // 
            this.StringKeyMenu.AutoSize = true;
            this.StringKeyMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.StringKeyMenu.ForeColor = System.Drawing.Color.White;
            this.StringKeyMenu.Location = new System.Drawing.Point(9, 29);
            this.StringKeyMenu.Name = "StringKeyMenu";
            this.StringKeyMenu.Size = new System.Drawing.Size(41, 18);
            this.StringKeyMenu.TabIndex = 5;
            this.StringKeyMenu.Text = "Key: ";
            // 
            // TrytoEncryptLabel
            // 
            this.TrytoEncryptLabel.AutoSize = true;
            this.TrytoEncryptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.TrytoEncryptLabel.ForeColor = System.Drawing.Color.White;
            this.TrytoEncryptLabel.Location = new System.Drawing.Point(610, 29);
            this.TrytoEncryptLabel.Name = "TrytoEncryptLabel";
            this.TrytoEncryptLabel.Size = new System.Drawing.Size(178, 18);
            this.TrytoEncryptLabel.TabIndex = 5;
            this.TrytoEncryptLabel.Text = "Попытки зашифровать: ";
            // 
            // Encryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TrytoEncryptLabel);
            this.Controls.Add(this.StringKeyMenu);
            this.Controls.Add(this.ToolMenuAll);
            this.Controls.Add(this.OutResult);
            this.Controls.Add(this.GoEncryption);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Encryption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encryption";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Encryption_FormClosing);
            this.Load += new System.EventHandler(this.Encryption_Load);
            this.ToolMenuAll.ResumeLayout(false);
            this.ToolMenuAll.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoEncryption;
        private System.Windows.Forms.TextBox OutResult;
        private System.Windows.Forms.ToolStrip ToolMenuAll;
        private System.Windows.Forms.ToolStripDropDownButton MenuButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripProgressBar StripProgressBar;
        private System.Windows.Forms.ToolStripMenuItem ToolMenu;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлСТекстомToolStripMenuItem;
        private System.Windows.Forms.Timer ProgressTimer;
        private System.Windows.Forms.ToolStripMenuItem ввестиКлючToolStripMenuItem;
        private System.Windows.Forms.Label StringKeyMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label TrytoEncryptLabel;
    }
}

