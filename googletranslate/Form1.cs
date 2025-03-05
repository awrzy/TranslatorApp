using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;

namespace TranslatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBoxOutput.Text = translate(TextBoxInput.Text, ComboBoxFrom.Text, ComboBoxTo.Text);
        }
        public String translate(String input, string from, string to)
        {
            var fromLanguage = from;
            var toLanguage = to;
            var url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl={fromLanguage}&tl={toLanguage}&dt=t&q={HttpUtility.UrlEncode(input)}";
            var webclient = new WebClient
            {
                Encoding = System.Text.Encoding.UTF8
            };
            var result = webclient.DownloadString(url);
            try
            {
                result = result.Substring(4, result.IndexOf("\"", 4
                    , StringComparison.Ordinal) - 4);
                return result;
            }
            catch (Exception e1)
            {
                return "error";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBoxFrom.Items.AddRange(new string[] { "en","ru", "es", "fr", "de", "zh" });
            ComboBoxTo.Items.AddRange(new string[] { "en", "ru", "es", "fr", "de", "zh" });
            ComboBoxFrom.SelectedIndex = 0;
            ComboBoxTo.SelectedIndex = 1;
        }
    }
}
