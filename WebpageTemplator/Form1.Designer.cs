namespace WebpageTemplator {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.open_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.head_item = new System.Windows.Forms.ToolStripMenuItem();
            this.header_item = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_item = new System.Windows.Forms.ToolStripMenuItem();
            this.content_item = new System.Windows.Forms.ToolStripMenuItem();
            this.footer_item = new System.Windows.Forms.ToolStripMenuItem();
            this.separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.style_item = new System.Windows.Forms.ToolStripMenuItem();
            this.script_item = new System.Windows.Forms.ToolStripMenuItem();
            this.insert_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.nadpisyAOdstavceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heading_item = new System.Windows.Forms.ToolStripMenuItem();
            this.paragraph_item = new System.Windows.Forms.ToolStripMenuItem();
            this.bold_item = new System.Windows.Forms.ToolStripMenuItem();
            this.italic_item = new System.Windows.Forms.ToolStripMenuItem();
            this.tabulkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seznamyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberlist_item = new System.Windows.Forms.ToolStripMenuItem();
            this.list_item = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.image_item = new System.Windows.Forms.ToolStripMenuItem();
            this.link_item = new System.Windows.Forms.ToolStripMenuItem();
            this.break_item = new System.Windows.Forms.ToolStripMenuItem();
            this.separator_item = new System.Windows.Forms.ToolStripMenuItem();
            this.about_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.info_item = new System.Windows.Forms.ToolStripMenuItem();
            this.file_name = new System.Windows.Forms.Label();
            this.save_template_button = new System.Windows.Forms.Button();
            this.generate_button = new System.Windows.Forms.Button();
            this.text_area = new System.Windows.Forms.RichTextBox();
            this.theme_button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open_menu,
            this.insert_menu,
            this.about_menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1286, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // open_menu
            // 
            this.open_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.head_item,
            this.header_item,
            this.menu_item,
            this.content_item,
            this.footer_item,
            this.separator1,
            this.style_item,
            this.script_item});
            this.open_menu.Name = "open_menu";
            this.open_menu.Size = new System.Drawing.Size(100, 20);
            this.open_menu.Text = "Otevřít šablonu";
            // 
            // head_item
            // 
            this.head_item.Name = "head_item";
            this.head_item.Size = new System.Drawing.Size(180, 22);
            this.head_item.Text = "Hlavička";
            this.head_item.Click += new System.EventHandler(this.head_item_Click);
            // 
            // header_item
            // 
            this.header_item.Name = "header_item";
            this.header_item.Size = new System.Drawing.Size(180, 22);
            this.header_item.Text = "Záhlaví";
            this.header_item.Click += new System.EventHandler(this.header_item_Click);
            // 
            // menu_item
            // 
            this.menu_item.Name = "menu_item";
            this.menu_item.Size = new System.Drawing.Size(180, 22);
            this.menu_item.Text = "Menu";
            this.menu_item.Click += new System.EventHandler(this.menu_item_Click);
            // 
            // content_item
            // 
            this.content_item.Name = "content_item";
            this.content_item.Size = new System.Drawing.Size(180, 22);
            this.content_item.Text = "Obsah";
            this.content_item.Click += new System.EventHandler(this.content_item_Click);
            // 
            // footer_item
            // 
            this.footer_item.Name = "footer_item";
            this.footer_item.Size = new System.Drawing.Size(180, 22);
            this.footer_item.Text = "Zápatí";
            this.footer_item.Click += new System.EventHandler(this.footer_item_Click);
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(177, 6);
            // 
            // style_item
            // 
            this.style_item.Name = "style_item";
            this.style_item.Size = new System.Drawing.Size(180, 22);
            this.style_item.Text = "Styly (.css)";
            this.style_item.Click += new System.EventHandler(this.style_item_Click);
            // 
            // script_item
            // 
            this.script_item.Name = "script_item";
            this.script_item.Size = new System.Drawing.Size(180, 22);
            this.script_item.Text = "Skripty (.js)";
            this.script_item.Click += new System.EventHandler(this.script_item_Click);
            // 
            // insert_menu
            // 
            this.insert_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nadpisyAOdstavceToolStripMenuItem,
            this.tabulkaToolStripMenuItem,
            this.seznamyToolStripMenuItem,
            this.toolStripSeparator2,
            this.image_item,
            this.link_item,
            this.break_item,
            this.separator_item});
            this.insert_menu.Name = "insert_menu";
            this.insert_menu.Size = new System.Drawing.Size(48, 20);
            this.insert_menu.Text = "Vložit";
            // 
            // nadpisyAOdstavceToolStripMenuItem
            // 
            this.nadpisyAOdstavceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heading_item,
            this.paragraph_item,
            this.bold_item,
            this.italic_item});
            this.nadpisyAOdstavceToolStripMenuItem.Name = "nadpisyAOdstavceToolStripMenuItem";
            this.nadpisyAOdstavceToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.nadpisyAOdstavceToolStripMenuItem.Text = "Nadpisy a odstavce";
            // 
            // heading_item
            // 
            this.heading_item.Name = "heading_item";
            this.heading_item.Size = new System.Drawing.Size(211, 22);
            this.heading_item.Text = "Nadpis 1-6 (h1> -> <h6>)";
            // 
            // paragraph_item
            // 
            this.paragraph_item.Name = "paragraph_item";
            this.paragraph_item.Size = new System.Drawing.Size(211, 22);
            this.paragraph_item.Text = "Odstavec (<p>)";
            // 
            // bold_item
            // 
            this.bold_item.Name = "bold_item";
            this.bold_item.Size = new System.Drawing.Size(211, 22);
            this.bold_item.Text = "Ztučnění (<b>)";
            // 
            // italic_item
            // 
            this.italic_item.Name = "italic_item";
            this.italic_item.Size = new System.Drawing.Size(211, 22);
            this.italic_item.Text = "Kurzíva (<i>)";
            // 
            // tabulkaToolStripMenuItem
            // 
            this.tabulkaToolStripMenuItem.Name = "tabulkaToolStripMenuItem";
            this.tabulkaToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.tabulkaToolStripMenuItem.Text = "Tabulka";
            // 
            // seznamyToolStripMenuItem
            // 
            this.seznamyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numberlist_item,
            this.list_item});
            this.seznamyToolStripMenuItem.Name = "seznamyToolStripMenuItem";
            this.seznamyToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.seznamyToolStripMenuItem.Text = "Seznamy";
            // 
            // numberlist_item
            // 
            this.numberlist_item.Name = "numberlist_item";
            this.numberlist_item.Size = new System.Drawing.Size(138, 22);
            this.numberlist_item.Text = "Číslovaný";
            // 
            // list_item
            // 
            this.list_item.Name = "list_item";
            this.list_item.Size = new System.Drawing.Size(138, 22);
            this.list_item.Text = "Nečíslovaný";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(173, 6);
            // 
            // image_item
            // 
            this.image_item.Name = "image_item";
            this.image_item.Size = new System.Drawing.Size(176, 22);
            this.image_item.Text = "Obrázek (<img>)";
            // 
            // link_item
            // 
            this.link_item.Name = "link_item";
            this.link_item.Size = new System.Drawing.Size(176, 22);
            this.link_item.Text = "Odkaz (<a>)";
            // 
            // break_item
            // 
            this.break_item.Name = "break_item";
            this.break_item.Size = new System.Drawing.Size(176, 22);
            this.break_item.Text = "Odsazení (<br>)";
            // 
            // separator_item
            // 
            this.separator_item.Name = "separator_item";
            this.separator_item.Size = new System.Drawing.Size(176, 22);
            this.separator_item.Text = "Oddělovač (<hr>)";
            // 
            // about_menu
            // 
            this.about_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.info_item});
            this.about_menu.Name = "about_menu";
            this.about_menu.Size = new System.Drawing.Size(84, 20);
            this.about_menu.Text = "O programu";
            // 
            // info_item
            // 
            this.info_item.Name = "info_item";
            this.info_item.Size = new System.Drawing.Size(137, 22);
            this.info_item.Text = "Informace...";
            // 
            // file_name
            // 
            this.file_name.AutoSize = true;
            this.file_name.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.file_name.Location = new System.Drawing.Point(8, 31);
            this.file_name.Name = "file_name";
            this.file_name.Size = new System.Drawing.Size(130, 23);
            this.file_name.TabIndex = 1;
            this.file_name.Text = "Vyberte soubor";
            // 
            // save_template_button
            // 
            this.save_template_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_template_button.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.save_template_button.Location = new System.Drawing.Point(12, 506);
            this.save_template_button.Name = "save_template_button";
            this.save_template_button.Size = new System.Drawing.Size(219, 46);
            this.save_template_button.TabIndex = 3;
            this.save_template_button.Text = "Uložit šablonový soubor";
            this.save_template_button.UseVisualStyleBackColor = true;
            this.save_template_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // generate_button
            // 
            this.generate_button.BackColor = System.Drawing.SystemColors.Control;
            this.generate_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generate_button.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.generate_button.Location = new System.Drawing.Point(1065, 506);
            this.generate_button.Name = "generate_button";
            this.generate_button.Size = new System.Drawing.Size(209, 46);
            this.generate_button.TabIndex = 4;
            this.generate_button.Text = "Vygenerovat HTML";
            this.generate_button.UseVisualStyleBackColor = false;
            // 
            // text_area
            // 
            this.text_area.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_area.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text_area.Location = new System.Drawing.Point(0, 57);
            this.text_area.Name = "text_area";
            this.text_area.Size = new System.Drawing.Size(1286, 427);
            this.text_area.TabIndex = 5;
            this.text_area.Text = "";
            this.text_area.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.text_area.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_area_KeyPress);
            // 
            // theme_button
            // 
            this.theme_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.theme_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.theme_button.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.theme_button.ForeColor = System.Drawing.SystemColors.Control;
            this.theme_button.Location = new System.Drawing.Point(1162, 27);
            this.theme_button.Name = "theme_button";
            this.theme_button.Size = new System.Drawing.Size(112, 27);
            this.theme_button.TabIndex = 6;
            this.theme_button.Text = "DARK";
            this.theme_button.UseVisualStyleBackColor = false;
            this.theme_button.Click += new System.EventHandler(this.theme_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1286, 563);
            this.Controls.Add(this.theme_button);
            this.Controls.Add(this.text_area);
            this.Controls.Add(this.generate_button);
            this.Controls.Add(this.save_template_button);
            this.Controls.Add(this.file_name);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Webpage Templator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem open_menu;
        private System.Windows.Forms.ToolStripMenuItem insert_menu;
        private System.Windows.Forms.ToolStripMenuItem about_menu;
        private System.Windows.Forms.Label file_name;
        private System.Windows.Forms.Button save_template_button;
        private System.Windows.Forms.Button generate_button;
        private System.Windows.Forms.ToolStripMenuItem head_item;
        private System.Windows.Forms.ToolStripMenuItem header_item;
        private System.Windows.Forms.ToolStripMenuItem menu_item;
        private System.Windows.Forms.ToolStripMenuItem content_item;
        private System.Windows.Forms.ToolStripMenuItem footer_item;
        private System.Windows.Forms.ToolStripSeparator separator1;
        private System.Windows.Forms.ToolStripMenuItem style_item;
        private System.Windows.Forms.ToolStripMenuItem script_item;
        private System.Windows.Forms.ToolStripMenuItem nadpisyAOdstavceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heading_item;
        private System.Windows.Forms.ToolStripMenuItem paragraph_item;
        private System.Windows.Forms.ToolStripMenuItem bold_item;
        private System.Windows.Forms.ToolStripMenuItem italic_item;
        private System.Windows.Forms.ToolStripMenuItem tabulkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seznamyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberlist_item;
        private System.Windows.Forms.ToolStripMenuItem list_item;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem image_item;
        private System.Windows.Forms.ToolStripMenuItem link_item;
        private System.Windows.Forms.ToolStripMenuItem break_item;
        private System.Windows.Forms.ToolStripMenuItem separator_item;
        private System.Windows.Forms.ToolStripMenuItem info_item;
        private System.Windows.Forms.RichTextBox text_area;
        private System.Windows.Forms.Button theme_button;
    }
}

