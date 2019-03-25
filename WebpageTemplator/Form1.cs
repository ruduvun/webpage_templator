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
        int text_changed = 0;
        private char[] keys = "ABCDEFGHIJKLMNOPQRSTUVWXYZ 0123456789-+*/,.-<>?:-_ů\"§!¨'()ú%=éíáýžřčšě;°&@#{}][\"|€$ß¤˝´˙`˛˘^ˇ~".ToCharArray();
        private string[] html_marks = new string[28]{ "<div", "<a", "<img", "<link", "<html", "<head", "<title", "<meta", "<h1", "<h2", "<h3", "<h4", "<h5", "<h6", "<nav", "<button", "<span", "<ul", "<li", "<ol", "<table", "<tr", "<td", "<th", "<thead", "<tbody", "<script", "<body" };
        private string current_file;
        private string current_path;
        private Color cinder = ColorTranslator.FromHtml("#232B30");
        private Color cinder_back = ColorTranslator.FromHtml("#1C2226");
        private Color gray = ColorTranslator.FromHtml("#DCDCDC");
        public string theme_state;

        public Form1() {
            InitializeComponent();
            save_template_button.FlatAppearance.BorderSize = 0;
            generate_button.FlatAppearance.BorderSize = 0;
            theme_button.FlatAppearance.BorderSize = 0;
            text_area.BorderStyle = BorderStyle.None;
            save_template_button.BackColor = gray;
            generate_button.BackColor = gray;
            theme_state = "light";
            menuStrip1.Renderer = new MyRenderer();
        }

        private void head_item_Click(object sender, EventArgs e)
        {
            if (text_changed == 1)
                close_save();
            current_path = "./src/head.txt";
            open_file();
            file_name.Text = "Hlavička:";
            current_file = "head";
            render_text();
        }

        private void header_item_Click(object sender, EventArgs e)
        {
            if (text_changed == 1)
                close_save();
            current_path = "./src/header.txt";
            open_file();
            file_name.Text = "Záhlaví:";
            current_file = "header";
            render_text();
        }

        private void menu_item_Click(object sender, EventArgs e)
        {
            if (text_changed == 1)
                close_save();
            current_path = "./src/menus.txt";
            open_file();
            file_name.Text = "Menu:";
            current_file = "menu";
            render_text();
        }

        private void content_item_Click(object sender, EventArgs e)
        {
            if (text_changed == 1)
                close_save();
            current_path = "./src/content.txt";
            open_file();
            file_name.Text = "Obsah:";
            current_file = "content";
            render_text();
        }

        private void footer_item_Click(object sender, EventArgs e)
        {
            if (text_changed == 1)
                close_save();
            current_path = "./src/footer.txt";
            open_file();
            file_name.Text = "Zápatí:";
            current_file = "footer";
            render_text();
        }

        private void text_area_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void style_item_Click(object sender, EventArgs e)
        {
            if (text_changed == 1)
                close_save();
            current_path = "./src/css/styles.css";
            open_file();
            file_name.Text = "Styly (.css):";
            current_file = "style";
            render_text();
        }

        private void script_item_Click(object sender, EventArgs e)
        {
            if (text_changed == 1)
                close_save();
            current_path = "./src/js/script.js";
            open_file();
            file_name.Text = "Skripty (.js):";
            current_file = "script";
            render_text();
        }

        private void open_file()
        {
            text_area.SelectAll();
            if (theme_state == "light")
                text_area.SelectionColor = Color.Black;
            else
                text_area.SelectionColor = Color.White;
            text_area.Text = System.IO.File.ReadAllText(current_path);
        }

        private void close_save() {
            DialogResult dr = MessageBox.Show("Neuložené změny budou ztraceny!\nPřejete si soubor uložit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dr == DialogResult.Yes)
            {
                button1_Click(this, EventArgs.Empty);

            }
            text_changed = 0;
        }

        private void render_text() {
            
                //HTML ZNAČKY
                if (is_html()) {
                    if(theme_button.Text == "DARK")
                        check_keyword(html_marks, Color.Blue, 0);
                    if (theme_button.Text == "LIGHT")
                        check_keyword(html_marks, Color.OrangeRed, 0);
                }
        }

        private void check_keyword(string[] key_words, Color color, int startIndex)
        {
            for (int i = 0; i < key_words.Length; i++) { 
                if (text_area.Text.Contains(key_words[i]))
                {
                    int index = -1;
                    //vybraný text
                    int selectStart = text_area.SelectionStart;
                    //koncový zobáček
                    int ending_bracket = 0;
                    //indexOf vrací index shodujícího se s key_word
                    while ((index = text_area.Text.IndexOf(key_words[i], (index + 1))) != -1)
                    {
                        //označení vybrané části shodující se
                        text_area.Select((index + startIndex), key_words[i].Length);
                        //index koncové závorky začíná na začátku key_word
                        ending_bracket = index + startIndex + key_words[i].Length-1;
                        //obarvení key_word
                        text_area.SelectionColor = color;
                        //Dokud na indexu není '>' a zároveň index došel na konec textového pole
                        while(text_area.Text.ElementAt(ending_bracket) != '>' && ending_bracket < text_area.Text.Length)
                        {
                            
                            ending_bracket++;
                            
                        }
                        if(ending_bracket >= (index + startIndex + key_words[i].Length))
                        {
                            text_area.Select(ending_bracket, 1);
                            text_area.SelectionColor = color;
                        }
                        text_area.Select(selectStart, 0);
                        if (theme_button.Text == "DARK")
                            text_area.SelectionColor = Color.Black;
                        else
                            text_area.SelectionColor = Color.White;
                    }
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (current_file) {
                case "head":
                    try
                    {
                        System.IO.File.WriteAllText(current_path, text_area.Text);
                    }
                    catch (System.IO.IOException)
                    {
                        MessageBox.Show("Šablonový soubor se nepodařilo správně zapsat!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    catch(System.UnauthorizedAccessException) {
                        MessageBox.Show("Program nemá oprávnění ke zapisování do souboru!\nSpusťte program jako správce pro zapsání změn.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    MessageBox.Show(string.Concat("Šablona hlavičky byla uložena!\nByla uložena do ", System.IO.Path.GetFullPath(current_path)), "Upozornění", MessageBoxButtons.OK);
                    break;

                case "header":
                    try
                    {
                        System.IO.File.WriteAllText(current_path, text_area.Text);
                    }
                    catch (System.IO.IOException)
                    {
                        MessageBox.Show("Šablonový soubor se nepodařilo správně zapsat!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    catch (System.UnauthorizedAccessException)
                    {
                        MessageBox.Show("Program nemá oprávnění ke zapisování do souboru!\nSpusťte program jako správce pro zapsání změn.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    MessageBox.Show(string.Concat("Šablona záhlaví byla uložena!\nByla uložena do ", System.IO.Path.GetFullPath(current_path)), "Upozornění", MessageBoxButtons.OK);
                    break;

                case "menu":
                    try
                    {
                        System.IO.File.WriteAllText(current_path, text_area.Text);
                    }
                    catch (System.IO.IOException)
                    {
                        MessageBox.Show("Šablonový soubor se nepodařilo správně zapsat!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    catch (System.UnauthorizedAccessException)
                    {
                        MessageBox.Show("Program nemá oprávnění ke zapisování do souboru!\nSpusťte program jako správce pro zapsání změn.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    MessageBox.Show(string.Concat("Šablona menu byla uložena!\nByla uložena do ", System.IO.Path.GetFullPath(current_path)), "Upozornění", MessageBoxButtons.OK);
                    break;

                case "content":
                    try {
                        System.IO.File.WriteAllText(current_path, text_area.Text);
                    }
                    catch (System.IO.IOException)
                    {
                        MessageBox.Show("Šablonový soubor se nepodařilo správně zapsat!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    catch (System.UnauthorizedAccessException)
                    {
                        MessageBox.Show("Program nemá oprávnění ke zapisování do souboru!\nSpusťte program jako správce pro zapsání změn.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    MessageBox.Show(string.Concat("Šablona obsahu byla uložena!\nByla uložena do ", System.IO.Path.GetFullPath(current_path)), "Upozornění", MessageBoxButtons.OK);
                    break;

                case "footer":
                    try
                    {
                        System.IO.File.WriteAllText(current_path, text_area.Text);
                    }
                    catch (System.IO.IOException)
                    {
                        MessageBox.Show("Šablonový soubor se nepodařilo správně zapsat!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    catch (System.UnauthorizedAccessException)
                    {
                        MessageBox.Show("Program nemá oprávnění ke zapisování do souboru!\nSpusťte program jako správce pro zapsání změn.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    MessageBox.Show(string.Concat("Šablona zápatí byla uložena!\nByla uložena do ", System.IO.Path.GetFullPath(current_path)), "Upozornění", MessageBoxButtons.OK);
                    break;

                default:
                    MessageBox.Show("Nebylo možné uložit soubor!", "Chyba", MessageBoxButtons.OK);
                    break;
            }
        }

        private void theme_button_Click(object sender, EventArgs e)
        {
            if (theme_state == "light") { 
                theme_button.Text = "LIGHT";
                this.BackColor = cinder_back;
                file_name.ForeColor = Color.White;
                save_template_button.BackColor = cinder;
                save_template_button.ForeColor = Color.White;
                generate_button.BackColor = cinder;
                generate_button.ForeColor = Color.White;
                theme_button.BackColor = Color.White;
                theme_button.ForeColor = cinder;
                text_area.BackColor = cinder;
                text_area.ForeColor = Color.White;
                menuStrip1.BackColor = cinder_back;
                menuStrip1.ForeColor = SystemColors.Control;
                header_item.BackColor = cinder_back;
                head_item.BackColor = cinder_back;
                menu_item.BackColor = cinder_back;
                content_item.BackColor = cinder_back;
                footer_item.BackColor = cinder_back;
                style_item.BackColor = cinder_back;
                script_item.BackColor = cinder_back;
                header_item.ForeColor = Color.White;
                head_item.ForeColor = Color.White;
                menu_item.ForeColor = Color.White;
                content_item.ForeColor = Color.White;
                footer_item.ForeColor = Color.White;
                style_item.ForeColor = Color.White;
                script_item.ForeColor = Color.White;
                theme_state = "dark";
                render_text();
            }
            else
            {
                theme_button.Text = "DARK";
                this.BackColor = SystemColors.Control;
                file_name.ForeColor = Color.Black;
                save_template_button.BackColor = gray;
                save_template_button.ForeColor = Color.Black;
                generate_button.BackColor = gray;
                generate_button.ForeColor = Color.Black;
                theme_button.BackColor = Color.Black;
                theme_button.ForeColor = Color.White;
                text_area.BackColor = Color.White;
                text_area.ForeColor = Color.Black;
                menuStrip1.BackColor = SystemColors.Control;
                menuStrip1.ForeColor = Color.Black;
                header_item.BackColor = SystemColors.Control;
                head_item.BackColor = SystemColors.Control;
                menu_item.BackColor = SystemColors.Control;
                content_item.BackColor = SystemColors.Control;
                footer_item.BackColor = SystemColors.Control;
                style_item.BackColor = SystemColors.Control;
                script_item.BackColor = SystemColors.Control;
                header_item.ForeColor = Color.Black;
                head_item.ForeColor = Color.Black;
                menu_item.ForeColor = Color.Black;
                content_item.ForeColor = Color.Black;
                footer_item.ForeColor = Color.Black;
                style_item.ForeColor = Color.Black;
                script_item.ForeColor = Color.Black;
                theme_state = "light";
                render_text();
            }
        }
        private class MyRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                if (!e.Item.Selected) base.OnRenderMenuItemBackground(e);
                else
                {
                    Color clr = ColorTranslator.FromHtml("#1C2226");
                    Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                    if (e.Item.BackColor == clr)
                    {
                        e.Graphics.FillRectangle(Brushes.DarkSlateGray, rc);
                        e.Graphics.DrawRectangle(Pens.White, 1, 0, rc.Width - 2, rc.Height - 1);
                    }
                    else
                    {
                        e.Graphics.FillRectangle(Brushes.White, rc);
                        e.Graphics.DrawRectangle(Pens.Black, 1, 0, rc.Width - 2, rc.Height - 1);
                    }
                }
            }
        }

        private void text_area_KeyPress(object sender, KeyPressEventArgs e)
        {
            text_changed = 1;
            if (is_html()) {
                if (e.KeyChar == '>') { 
                    
                    render_text();
                }
            }
        }

        private bool is_html()
        {
            if (current_file == "header" || current_file == "head" || current_file == "menu" || current_file == "content" || current_file == "footer")
                return true;
            else
                return false;
        }
    }
}
