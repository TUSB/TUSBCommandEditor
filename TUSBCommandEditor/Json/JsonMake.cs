using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace HaruCommandEditor.Json
{
    public class JsonData
    {
        public class Score
        {
            public string name { get; set; }
            public string objective { get; set; }
        }
        public class ClickEvent
        {
            public string action { get; set; }
            public string value { get; set; }
        }
        public class HoverEvent
        {
            public string action { get; set; }
            public string value { get; set; }
        }
        public string text { get; set; }
        public string selector { get; set; }
        public Score score { get; set; }
        public string translate { get; set; }
        public List<JsonData> with { get; set; }
        public string keybind { get; set; }
        public string color { get; set; }
        public bool? bold { get; set; }
        public bool? italic { get; set; }
        public bool? underlined { get; set; }
        public bool? strikethrough { get; set; }
        public bool? obfuscated { get; set; }
        public ClickEvent clickEvent { get; set; }
        public HoverEvent hoverEvent { get; set; }
    }

    public partial class JsonMake : Form
    {
        private Dictionary<string, Color> ColorList = new Dictionary<string, Color>();
        public string JSON = "";

        public JsonMake()
        {
            InitializeComponent();
        }

        private void JsonMake_Load(object sender, EventArgs e)
        {
            JSON = "";
            if(!ColorList.TryGetValue("black",out var tmp))
            {
                ColorList.Add("black", Color.FromArgb(0, 0, 0));
                ColorList.Add("dark_blue", Color.FromArgb(0, 0, 170));
                ColorList.Add("dark_green", Color.FromArgb(0, 170, 0));
                ColorList.Add("dark_aqua", Color.FromArgb(0, 170, 170));
                ColorList.Add("dark_red", Color.FromArgb(170, 0, 0));
                ColorList.Add("dark_purple", Color.FromArgb(170, 0, 170));
                ColorList.Add("gold", Color.FromArgb(255, 170, 0));
                ColorList.Add("gray", Color.FromArgb(170, 170, 170));
                ColorList.Add("dark_gray", Color.FromArgb(85, 85, 85));
                ColorList.Add("blue", Color.FromArgb(85, 85, 255));
                ColorList.Add("green", Color.FromArgb(85, 255, 85));
                ColorList.Add("aqua", Color.FromArgb(85, 255, 255));
                ColorList.Add("red", Color.FromArgb(255, 85, 85));
                ColorList.Add("light_purple", Color.FromArgb(255, 85, 255));
                ColorList.Add("yellow", Color.FromArgb(255, 255, 85));
                ColorList.Add("white", Color.FromArgb(255, 255, 255));
            }
        }

        private void Preview_Show()
        {
            Preview.Clear();
            Color text_color = Preview.ForeColor;
            bool bold = false;
            bool italic = false;
            bool underlined = false;
            bool strikethrough = false;
            bool obfuscated = false;
            foreach (var item in ListJsonItems.Items)
            {
                var Item = JsonConvert.DeserializeObject<JsonData>(item.ToString());
                string add_text = "";
                if (Item.text != "")
                {
                    add_text = Item.text;
                }
                else if (Item.selector != "")
                {
                    add_text = $"[selector:{Item.selector}]";
                }
                else if (Item.score != null)
                {
                    add_text = $"[score name:{Item.score.name},objective:{Item.score.objective}]";
                }
                else if (Item.translate != null)
                {
                    add_text = $"[translate:{Item.translate}]";
                }
                else if (Item.keybind != null)
                {
                    add_text = $"[keybind:{Item.keybind}]";
                }

                if (Item.color != null)
                {
                    text_color = Item.color == "reset" ? Preview.ForeColor : ColorList[Item.color];
                }

            }
            return;
        }

        private void ListAdd_Click(object sender, EventArgs e)
        {
            var Item = new JsonData();
            //基礎
            switch (TabSetting.SelectedTab.Text)
            {
                case "text":
                    Item.text = TextValue.Text;
                    break;
                case "selector":
                    Item.selector = Selector.Text;
                    break;
                case "score":
                    Item.score.name = ScoreSelector.Text;
                    Item.score.objective = ScoreScoreboard.Text;
                    break;
                case "translate":
                    Item.translate = TranslateText.Text;
                    List<JsonData> with = new List<JsonData>();
                    foreach(var withitem in TranslateWithList.Items)
                    {
                        with.Add(JsonConvert.DeserializeObject<JsonData>(withitem.ToString()));
                    }
                    Item.with = with;
                    break;
                case "keybind":
                    Item.keybind = Keybind.Text;
                    break;
            }
            
            //装飾
            if (ColorSelect.SelectedText != "未指定") { Item.color = ColorSelect.SelectedText; }
            if (Bold.SelectedIndex > 0) { Item.bold = Bold.SelectedText == "T"; }
            if (Italic.SelectedIndex > 0) { Item.italic = Italic.SelectedText == "T"; }
            if (Underlined.SelectedIndex > 0) { Item.underlined = Underlined.SelectedText == "T"; }
            if (Strikethrough.SelectedIndex > 0) { Item.strikethrough = Strikethrough.SelectedText == "T"; }
            if (Obfuscated.SelectedIndex > 0) { Item.obfuscated = Obfuscated.SelectedText == "T"; }

            //click&hover
            if (ClickAction.SelectedText != "使用しない")
            {
                Item.clickEvent.action = ClickAction.SelectedText;
                Item.clickEvent.value = ClickValue.Text;
            }
            if (HoverAction.SelectedText != "使用しない")
            {
                Item.hoverEvent.action = HoverAction.SelectedText;
                Item.hoverEvent.value = HoverValue.Text;
            }
            ListJsonItems.Items.Add(JsonConvert.SerializeObject(Item));
        }

        private void ColorSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ColorSelect.SelectedText)
            {
                case "未指定": ColorShow.BackColor = Color.FromName("Control"); break;
                case "reset": ColorShow.BackColor = Color.FromName("Control"); break;
                default: ColorShow.BackColor = ColorList[ColorSelect.SelectedText]; break;
            }
        }

        private void TranslateWithAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var with = JsonConvert.DeserializeObject<JsonData>(TranslateWith.Text);
                TranslateWithList.Items.Add(JsonConvert.SerializeObject(with));
            }
            catch (Exception)
            {
                MessageBox.Show("追加できませんでした", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TranslateWithRemove_Click(object sender, EventArgs e)
        {
            if (TranslateWithList.SelectedIndex > -1)
            {
                TranslateWithList.Items.RemoveAt(TranslateWithList.SelectedIndex);
            }
        }

        private void TranslateWithUp_Click(object sender, EventArgs e)
        {
            if (TranslateWithList.SelectedIndex > 0)
            {
                var index = TranslateWithList.SelectedIndex;
                var tmp = TranslateWithList.Items[index];
                TranslateWithList.Items[index] = TranslateWithList.Items[index - 1];
                TranslateWithList.Items[index - 1] = tmp;
            }
        }

        private void TranslateWithDown_Click(object sender, EventArgs e)
        {
            if (TranslateWithList.SelectedIndex > -1 && TranslateWithList.SelectedIndex < TranslateWithList.Items.Count - 1)
            {
                var index = TranslateWithList.SelectedIndex;
                var tmp = TranslateWithList.Items[index];
                TranslateWithList.Items[index] = TranslateWithList.Items[index + 1];
                TranslateWithList.Items[index + 1] = tmp;
            }
        }

        private void PreviewResetColor_Click(object sender, EventArgs e)
        {
            if (PreviewResetColorSet.ShowDialog() == DialogResult.OK)
            {
                Preview.ForeColor = PreviewResetColorSet.Color;
            }
        }

        private void PreviewBGColor_Click(object sender, EventArgs e)
        {
            if (PreviewBGColorSet.ShowDialog() == DialogResult.OK)
            {
                Preview.BackColor = PreviewBGColorSet.Color;
            }
        }
    }
}
