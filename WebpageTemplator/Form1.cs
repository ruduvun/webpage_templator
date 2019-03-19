using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebpageTemplator {
    public partial class Form1 : Form {
        int text_changed;
        String[] html_marks = ["div", "a", "img", "link", "html", "head", "title", "meta", "h1", "h2", "h3", "h4", "h5", "h6", "nav", "button", "span", "ul", "li", "ol", "table", "tr", "td", "th", "thead", "tbody", "script", "body"];
        public Form1() {
            InitializeComponent();
            text_changed = 0;
        }

        private void head_item_Click(object sender, EventArgs e)
        {
            text_area.Text = System.IO.File.ReadAllText("./src/head.txt");
            file_name.Text = "Hlavička:";
        }

        private void header_item_Click(object sender, EventArgs e)
        {
            text_area.Text = System.IO.File.ReadAllText("./src/header.txt");
            file_name.Text = "Záhlaví:";
        }

        private void menu_item_Click(object sender, EventArgs e)
        {
            text_area.Text = System.IO.File.ReadAllText("./src/menus.txt");
            file_name.Text = "Menu:";
        }

        private void content_item_Click(object sender, EventArgs e)
        {
            text_area.Text = System.IO.File.ReadAllText("./src/content.txt");
            file_name.Text = "Obsah:";
        }

        private void footer_item_Click(object sender, EventArgs e)
        {
            text_area.Text = System.IO.File.ReadAllText("./src/footer.txt");
            file_name.Text = "Zápatí:";
        }

        private void text_area_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void style_item_Click(object sender, EventArgs e)
        {
            text_area.Text = System.IO.File.ReadAllText("./src/css/styles.css");
            file_name.Text = "Styly (.css):";
        }

        private void script_item_Click(object sender, EventArgs e)
        {
            text_area.Text = System.IO.File.ReadAllText("./src/js/script.js");
            file_name.Text = "Skript (.js):";
        }

        private void render_html() {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            text_changed = 1;
        }
    }
}
