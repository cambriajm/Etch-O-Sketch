namespace GraphicsExample
{
    partial class GraphicsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DisplayPictureBox = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            drawToolStripMenuItem = new ToolStripMenuItem();
            clearToolStripMenuItem = new ToolStripMenuItem();
            colorToolStripMenuItem = new ToolStripMenuItem();
            penToolStripMenuItem = new ToolStripMenuItem();
            backgroundToolStripMenuItem = new ToolStripMenuItem();
            penSizeToolStripMenuItem = new ToolStripMenuItem();
            PenSizeComboBox = new ToolStripComboBox();
            DrawButton = new Button();
            ExitButton = new Button();
            PenColorDialogue = new ColorDialog();
            ContextMenu = new MenuStrip();
            FileMenuItem = new ToolStripMenuItem();
            DrawMenuItem = new ToolStripMenuItem();
            ClearMenuItem = new ToolStripMenuItem();
            ExitMenuItem = new ToolStripMenuItem();
            HelpTopMenuItem = new ToolStripMenuItem();
            AboutMenuItem = new ToolStripMenuItem();
            ClearButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // DisplayPictureBox
            // 
            DisplayPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DisplayPictureBox.BackColor = SystemColors.ActiveCaption;
            DisplayPictureBox.ContextMenuStrip = contextMenuStrip1;
            DisplayPictureBox.Location = new Point(41, 38);
            DisplayPictureBox.Name = "DisplayPictureBox";
            DisplayPictureBox.Size = new Size(867, 314);
            DisplayPictureBox.TabIndex = 0;
            DisplayPictureBox.TabStop = false;
            DisplayPictureBox.Click += DisplayPictureBox_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { drawToolStripMenuItem, clearToolStripMenuItem, colorToolStripMenuItem, penSizeToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(133, 100);
            // 
            // drawToolStripMenuItem
            // 
            drawToolStripMenuItem.Name = "drawToolStripMenuItem";
            drawToolStripMenuItem.Size = new Size(132, 24);
            drawToolStripMenuItem.Text = "Draw";
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(132, 24);
            clearToolStripMenuItem.Text = "Clear";
            // 
            // colorToolStripMenuItem
            // 
            colorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { penToolStripMenuItem, backgroundToolStripMenuItem });
            colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            colorToolStripMenuItem.Size = new Size(132, 24);
            colorToolStripMenuItem.Text = "Color";
            // 
            // penToolStripMenuItem
            // 
            penToolStripMenuItem.Name = "penToolStripMenuItem";
            penToolStripMenuItem.Size = new Size(171, 26);
            penToolStripMenuItem.Text = "Pen";
            // 
            // backgroundToolStripMenuItem
            // 
            backgroundToolStripMenuItem.Name = "backgroundToolStripMenuItem";
            backgroundToolStripMenuItem.Size = new Size(171, 26);
            backgroundToolStripMenuItem.Text = "Background";
            // 
            // penSizeToolStripMenuItem
            // 
            penSizeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { PenSizeComboBox });
            penSizeToolStripMenuItem.Name = "penSizeToolStripMenuItem";
            penSizeToolStripMenuItem.Size = new Size(132, 24);
            penSizeToolStripMenuItem.Text = "Pen Size";
            // 
            // PenSizeComboBox
            // 
            PenSizeComboBox.Name = "PenSizeComboBox";
            PenSizeComboBox.Size = new Size(121, 28);
            PenSizeComboBox.Click += PenSizeComboBox_Click;
            // 
            // DrawButton
            // 
            DrawButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DrawButton.Location = new Point(588, 372);
            DrawButton.Name = "DrawButton";
            DrawButton.Size = new Size(150, 59);
            DrawButton.TabIndex = 1;
            DrawButton.Text = "Draw";
            DrawButton.UseVisualStyleBackColor = true;
            DrawButton.Click += DrawButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ExitButton.AutoSize = true;
            ExitButton.Location = new Point(758, 372);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(150, 59);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ContextMenu
            // 
            ContextMenu.ImageScalingSize = new Size(20, 20);
            ContextMenu.Items.AddRange(new ToolStripItem[] { FileMenuItem, HelpTopMenuItem });
            ContextMenu.Location = new Point(0, 0);
            ContextMenu.Name = "ContextMenu";
            ContextMenu.Size = new Size(950, 28);
            ContextMenu.TabIndex = 3;
            ContextMenu.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            FileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DrawMenuItem, ClearMenuItem, ExitMenuItem });
            FileMenuItem.Name = "FileMenuItem";
            FileMenuItem.Size = new Size(46, 24);
            FileMenuItem.Text = "&File";
            // 
            // DrawMenuItem
            // 
            DrawMenuItem.Name = "DrawMenuItem";
            DrawMenuItem.Size = new Size(127, 26);
            DrawMenuItem.Text = "&Draw";
            // 
            // ClearMenuItem
            // 
            ClearMenuItem.Name = "ClearMenuItem";
            ClearMenuItem.Size = new Size(127, 26);
            ClearMenuItem.Text = "&Clear";
            // 
            // ExitMenuItem
            // 
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.Size = new Size(127, 26);
            ExitMenuItem.Text = "E&xit";
            // 
            // HelpTopMenuItem
            // 
            HelpTopMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutMenuItem });
            HelpTopMenuItem.Name = "HelpTopMenuItem";
            HelpTopMenuItem.Size = new Size(55, 24);
            HelpTopMenuItem.Text = "&Help";
            // 
            // AboutMenuItem
            // 
            AboutMenuItem.Name = "AboutMenuItem";
            AboutMenuItem.Size = new Size(133, 26);
            AboutMenuItem.Text = "About";
            AboutMenuItem.Click += AboutMenuItem_Click;
            // 
            // ClearButton
            // 
            ClearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearButton.Location = new Point(417, 372);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(150, 59);
            ClearButton.TabIndex = 4;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // GraphicsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 443);
            Controls.Add(ClearButton);
            Controls.Add(ExitButton);
            Controls.Add(DrawButton);
            Controls.Add(DisplayPictureBox);
            Controls.Add(ContextMenu);
            MainMenuStrip = ContextMenu;
            Name = "GraphicsForm";
            Text = "Graphics";
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ContextMenu.ResumeLayout(false);
            ContextMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox DisplayPictureBox;
        private Button DrawButton;
        private Button ExitButton;
        private ColorDialog PenColorDialogue;
        private MenuStrip ContextMenu;
        private ToolStripMenuItem FileMenuItem;
        private ToolStripMenuItem HelpTopMenuItem;
        private ToolStripMenuItem DrawMenuItem;
        private ToolStripMenuItem ClearMenuItem;
        private ToolStripMenuItem ExitMenuItem;
        private ToolStripMenuItem AboutMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem drawToolStripMenuItem;
        private ToolStripMenuItem clearToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem penSizeToolStripMenuItem;
        private ToolStripMenuItem penToolStripMenuItem;
        private ToolStripMenuItem backgroundToolStripMenuItem;
        private Button ClearButton;
        private ToolStripComboBox PenSizeComboBox;
        private System.Windows.Forms.Timer timer1;
    }
}
