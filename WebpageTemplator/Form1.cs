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
        private string[] html_marks = new string[28]{ "<div", "<a", "<img", "<link", "<html", "<head", "<title", "<meta", "<h1", "<h2", "<h3", "<h4", "<h5", "<h6", "<nav", "<button", "<span", "<ul", "<li", "<ol", "<table", "<tr", "<td", "<th", "<thead", "<tbody", "<script", "<body" };
        private string current_file;
        private string current_path;

        public Form1() {
            InitializeComponent();
        }

        private void head_item_Click(object sender, EventArgs e)
        {
            current_path = "./src/head.txt";
            text_area.Text = System.IO.File.ReadAllText(current_path);
            file_name.Text = "Hlavička:";
            current_file = "head";
            text_area.ForeColor = Color.Black;
        }

        private void header_item_Click(object sender, EventArgs e)
        {
            current_path = "./src/header.txt";
            text_area.Text = System.IO.File.ReadAllText(current_path);
            file_name.Text = "Záhlaví:";
            current_file = "header";
            text_area.ForeColor = Color.Black;
        }

        private void menu_item_Click(object sender, EventArgs e)
        {
            current_path = "./src/menus.txt";
            text_area.Text = System.IO.File.ReadAllText(current_path);
            file_name.Text = "Menu:";
            current_file = "menu";
            text_area.ForeColor = Color.Black;
        }

        private void content_item_Click(object sender, EventArgs e)
        {
            current_path = "./src/content.txt";
            text_area.Text = System.IO.File.ReadAllText(current_path);
            file_name.Text = "Obsah:";
            current_file = "content";
            text_area.ForeColor = Color.Black;
        }

        private void footer_item_Click(object sender, EventArgs e)
        {
            current_path = "./src/footer.txt";
            text_area.Text = System.IO.File.ReadAllText(current_path);
            file_name.Text = "Zápatí:";
            current_file = "footer";
            text_area.ForeColor = Color.Black;
        }

        private void text_area_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void style_item_Click(object sender, EventArgs e)
        {
            text_area.Text = System.IO.File.ReadAllText("./src/css/styles.css");
            file_name.Text = "Styly (.css):";
            current_file = "style";
        }

        private void script_item_Click(object sender, EventArgs e)
        {
            text_area.Text = System.IO.File.ReadAllText("./src/js/script.js");
            file_name.Text = "Skripty (.js):";
            current_file = "script";
        }

        private void render_text() {
            List<string> lines = text_area.Text.Split('\n').ToList();
            foreach(var line in lines)
            {
                //HTML ZNAČKY
                if(current_file == "head" || current_file == "header" || current_file == "menu" || current_file == "content" || current_file == "footer")
                    check_keyword(line, html_marks, Color.Blue, 0);
            }
        }

        private void check_keyword(string line,string[] key_words, Color color, int startIndex)
        {
            for (int i = 0; i < key_words.Length; i++) { 
                if (text_area.Text.Contains(key_words[i]))
                {
                    int index = -1;
                    int selectStart = text_area.SelectionStart;

                    while ((index = text_area.Text.IndexOf(key_words[i], (index + 1))) != -1)
                    {
                        text_area.Select((index + startIndex), key_words[i].Length);
                        text_area.SelectionColor = color;
                        text_area.Select(selectStart, 0);
                        text_area.SelectionColor = Color.Black;
                    }
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            render_text();
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
    }
}
