namespace WM__Notapad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.filebutton = new System.Windows.Forms.ToolStripSplitButton();
            this.new_ = new System.Windows.Forms.ToolStripMenuItem();
            this.open_ = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.ToolStripMenuItem();
            this.saveas = new System.Windows.Forms.ToolStripMenuItem();
            this.close_ = new System.Windows.Forms.ToolStripMenuItem();
            this.windowbutton = new System.Windows.Forms.ToolStripSplitButton();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colortekst = new System.Windows.Forms.ToolStripMenuItem();
            this.photoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tools_ = new System.Windows.Forms.ToolStripSplitButton();
            this.copy = new System.Windows.Forms.ToolStripMenuItem();
            this.paste = new System.Windows.Forms.ToolStripMenuItem();
            this.clear = new System.Windows.Forms.ToolStripMenuItem();
            this.redo = new System.Windows.Forms.ToolStripMenuItem();
            this.undo = new System.Windows.Forms.ToolStripMenuItem();
            this.Font1 = new System.Windows.Forms.ToolStripButton();
            this.aboutbutton = new System.Windows.Forms.ToolStripButton();
            this.hidebutton = new System.Windows.Forms.ToolStripButton();
            this.tekst = new System.Windows.Forms.RichTextBox();
            this.fontdlg = new System.Windows.Forms.FontDialog();
            this.colorchoose = new System.Windows.Forms.ColorDialog();
            this.showhide = new System.Windows.Forms.Button();
            this.locationlabel1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Teal;
            this.toolStrip1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filebutton,
            this.windowbutton,
            this.tools_,
            this.Font1,
            this.aboutbutton,
            this.hidebutton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // filebutton
            // 
            this.filebutton.BackColor = System.Drawing.Color.Teal;
            this.filebutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.filebutton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.new_,
            this.open_,
            this.save,
            this.saveas,
            this.close_});
            this.filebutton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filebutton.Image = ((System.Drawing.Image)(resources.GetObject("filebutton.Image")));
            this.filebutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.filebutton.Name = "filebutton";
            this.filebutton.Size = new System.Drawing.Size(47, 22);
            this.filebutton.Text = "File";
            // 
            // new_
            // 
            this.new_.BackColor = System.Drawing.Color.Teal;
            this.new_.Name = "new_";
            this.new_.Size = new System.Drawing.Size(180, 22);
            this.new_.Text = "New";
            // 
            // open_
            // 
            this.open_.BackColor = System.Drawing.Color.Teal;
            this.open_.Name = "open_";
            this.open_.Size = new System.Drawing.Size(180, 22);
            this.open_.Text = "Open";
            this.open_.Click += new System.EventHandler(this.open__Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Teal;
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(180, 22);
            this.save.Text = "Save";
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // saveas
            // 
            this.saveas.BackColor = System.Drawing.Color.Teal;
            this.saveas.Name = "saveas";
            this.saveas.Size = new System.Drawing.Size(180, 22);
            this.saveas.Text = "Save as";
            this.saveas.Click += new System.EventHandler(this.saveas_Click);
            // 
            // close_
            // 
            this.close_.BackColor = System.Drawing.Color.Teal;
            this.close_.Name = "close_";
            this.close_.Size = new System.Drawing.Size(180, 22);
            this.close_.Text = "Close";
            this.close_.Click += new System.EventHandler(this.close__Click);
            // 
            // windowbutton
            // 
            this.windowbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.windowbutton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sizeToolStripMenuItem,
            this.backgroundColorToolStripMenuItem});
            this.windowbutton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.windowbutton.Image = ((System.Drawing.Image)(resources.GetObject("windowbutton.Image")));
            this.windowbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.windowbutton.Name = "windowbutton";
            this.windowbutton.Size = new System.Drawing.Size(77, 22);
            this.windowbutton.Text = "Window";
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.sizeToolStripMenuItem.Text = "Size";
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.backgroundColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colortekst,
            this.photoToolStripMenuItem});
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background Color";
            // 
            // colortekst
            // 
            this.colortekst.BackColor = System.Drawing.Color.Teal;
            this.colortekst.Name = "colortekst";
            this.colortekst.Size = new System.Drawing.Size(112, 22);
            this.colortekst.Text = "Color";
            this.colortekst.Click += new System.EventHandler(this.colortekst_Click);
            // 
            // photoToolStripMenuItem
            // 
            this.photoToolStripMenuItem.BackColor = System.Drawing.Color.Teal;
            this.photoToolStripMenuItem.Name = "photoToolStripMenuItem";
            this.photoToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.photoToolStripMenuItem.Text = "Photo";
            // 
            // tools_
            // 
            this.tools_.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tools_.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copy,
            this.paste,
            this.clear,
            this.redo,
            this.undo});
            this.tools_.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tools_.Image = ((System.Drawing.Image)(resources.GetObject("tools_.Image")));
            this.tools_.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tools_.Name = "tools_";
            this.tools_.Size = new System.Drawing.Size(52, 22);
            this.tools_.Text = "Text";
            // 
            // copy
            // 
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(177, 22);
            this.copy.Text = "Copy (ctrl + c)";
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // paste
            // 
            this.paste.Name = "paste";
            this.paste.Size = new System.Drawing.Size(177, 22);
            this.paste.Text = "Paste (ctrl + v)";
            this.paste.Click += new System.EventHandler(this.paste_Click);
            // 
            // clear
            // 
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(177, 22);
            this.clear.Text = "Clear (ctrl + x)";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // redo
            // 
            this.redo.Name = "redo";
            this.redo.Size = new System.Drawing.Size(177, 22);
            this.redo.Text = "Redo (ctrl + y)";
            this.redo.Click += new System.EventHandler(this.redo_Click);
            // 
            // undo
            // 
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(177, 22);
            this.undo.Text = "Undo (ctrl + z)";
            this.undo.Click += new System.EventHandler(this.undo_Click);
            // 
            // Font1
            // 
            this.Font1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Font1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Font1.Image = ((System.Drawing.Image)(resources.GetObject("Font1.Image")));
            this.Font1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Font1.Name = "Font1";
            this.Font1.Size = new System.Drawing.Size(40, 22);
            this.Font1.Text = "Font";
            // 
            // aboutbutton
            // 
            this.aboutbutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aboutbutton.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.aboutbutton.Image = ((System.Drawing.Image)(resources.GetObject("aboutbutton.Image")));
            this.aboutbutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutbutton.Name = "aboutbutton";
            this.aboutbutton.Size = new System.Drawing.Size(49, 22);
            this.aboutbutton.Text = "About";
            this.aboutbutton.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // hidebutton
            // 
            this.hidebutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.hidebutton.Image = ((System.Drawing.Image)(resources.GetObject("hidebutton.Image")));
            this.hidebutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.hidebutton.Name = "hidebutton";
            this.hidebutton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hidebutton.Size = new System.Drawing.Size(41, 22);
            this.hidebutton.Text = "Hide";
            this.hidebutton.Click += new System.EventHandler(this.hidebutton_Click);
            // 
            // tekst
            // 
            this.tekst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tekst.BackColor = System.Drawing.Color.DarkGray;
            this.tekst.Font = new System.Drawing.Font("Segoe Fluent Icons", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tekst.Location = new System.Drawing.Point(0, 28);
            this.tekst.Name = "tekst";
            this.tekst.Size = new System.Drawing.Size(800, 421);
            this.tekst.TabIndex = 1;
            this.tekst.Text = "";
            this.tekst.TextChanged += new System.EventHandler(this.tekst_TextChanged);
            // 
            // showhide
            // 
            this.showhide.BackColor = System.Drawing.Color.Teal;
            this.showhide.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.showhide.Location = new System.Drawing.Point(264, 0);
            this.showhide.Name = "showhide";
            this.showhide.Size = new System.Drawing.Size(67, 23);
            this.showhide.TabIndex = 2;
            this.showhide.Text = "Show";
            this.showhide.UseVisualStyleBackColor = false;
            this.showhide.Visible = false;
            this.showhide.Click += new System.EventHandler(this.showhide_Click);
            // 
            // locationlabel1
            // 
            this.locationlabel1.AutoSize = true;
            this.locationlabel1.BackColor = System.Drawing.Color.Transparent;
            this.locationlabel1.Location = new System.Drawing.Point(517, 5);
            this.locationlabel1.Name = "locationlabel1";
            this.locationlabel1.Size = new System.Drawing.Size(0, 13);
            this.locationlabel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.locationlabel1);
            this.Controls.Add(this.showhide);
            this.Controls.Add(this.tekst);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Wonder Notapad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton filebutton;
        private System.Windows.Forms.ToolStripMenuItem new_;
        private System.Windows.Forms.ToolStripMenuItem open_;
        private System.Windows.Forms.ToolStripMenuItem close_;
        private System.Windows.Forms.ToolStripSplitButton windowbutton;
        private System.Windows.Forms.ToolStripSplitButton tools_;
        private System.Windows.Forms.ToolStripButton aboutbutton;
        private System.Windows.Forms.RichTextBox tekst;
        private System.Windows.Forms.ToolStripMenuItem copy;
        private System.Windows.Forms.ToolStripMenuItem paste;
        private System.Windows.Forms.ToolStripMenuItem clear;
        private System.Windows.Forms.ToolStripMenuItem redo;
        private System.Windows.Forms.ToolStripMenuItem undo;
        private System.Windows.Forms.ToolStripMenuItem save;
        private System.Windows.Forms.ToolStripMenuItem saveas;
        private System.Windows.Forms.FontDialog fontdlg;
        private System.Windows.Forms.ToolStripButton Font1;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colortekst;
        private System.Windows.Forms.ToolStripMenuItem photoToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton hidebutton;
        private System.Windows.Forms.ColorDialog colorchoose;
        private System.Windows.Forms.Button showhide;
        private System.Windows.Forms.Label locationlabel1;
    }
}

