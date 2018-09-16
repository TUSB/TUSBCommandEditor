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

namespace TUSBCommandEditor.Tool
{
    public partial class JsonGenerator : Form
    {
        private Dictionary<string, Color> ColorList = new Dictionary<string, Color>();
        private string input = "";
        public string JSON = "";
        
        public JsonGenerator(string input = "")
        {
            this.input = input;
            InitializeComponent();
        }

        /// <summary>
        /// フォームを表示しJSON文字列を返す、OKされなかった場合にはnullを返すので注意
        /// </summary>
        /// <param name="input">あればJSON文字列(省略可)</param>
        static public string ShowForm(string input = "")
        {
            JsonGenerator json = new JsonGenerator(input);
            string ReturnValue = null;
            if (json.ShowDialog() == DialogResult.OK)
            {
                ReturnValue = json.JSON;
            }
            json.Dispose();
            return ReturnValue;
        }

        private int StyleToNumber(bool? style)
        {
            return style == null ? 0 : (bool)style ? 1 : 2;
        }

        private void ItemAllClear()
        {
            TextValue.Clear();
            Selector.Clear();
            ScoreSelector.Clear();
            ScoreScoreboard.Clear();
            TranslateText.Clear();
            TranslateWith.Clear();
            TranslateWithList.Items.Clear();
            Keybind.Clear();
            ColorSelect.SelectedIndex = 0;
            Bold.SelectedIndex = 0;
            Italic.SelectedIndex = 0;
            Underlined.SelectedIndex = 0;
            Strikethrough.SelectedIndex = 0;
            Obfuscated.SelectedIndex = 0;
            ClickAction.SelectedIndex = 0;
            ClickValue.Clear();
            HoverAction.SelectedIndex = 0;
            HoverValue.Clear();
            return;
        }

        private void JsonMake_Load(object sender, EventArgs e)
        {
            JSON = "";
            if (!ColorList.TryGetValue("black", out var dummy))
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
            ItemAllClear();
            if (input != "")
            {
                try
                {
                    var Item = JsonConvert.DeserializeObject<List<object>>(input);
                    foreach(var tmp in Item)
                    {
                        if (tmp is Newtonsoft.Json.Linq.JObject)
                        {
                            ListJsonItems.Items.Add(JsonConvert.SerializeObject(JsonConvert.DeserializeObject<JsonData>(tmp.ToString()), new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }));
                        }
                    }
                    Preview_Show();
                }
                catch (Exception)
                {
                    try
                    {
                        var Item = JsonConvert.DeserializeObject<JsonData>(input);
                        ListJsonItems.Items.Add(JsonConvert.SerializeObject(Item, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("読み込めませんでした", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void Preview_Show()
        {
            Preview.Clear();
            Color color = Preview.ForeColor;
            List<TextData> textdata = new List<TextData>();
            bool bold = false;
            bool italic = false;
            bool underlined = false;
            bool strikethrough = false;
            foreach (var item in ListJsonItems.Items)
            {
                var Item = JsonConvert.DeserializeObject<JsonData>((string)item);
                string add_text = "";
                if (Item.text != null)
                {
                    add_text = Item.text;
                }
                else if (Item.selector != null)
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
                    color = Item.color == "reset" ? Preview.ForeColor : ColorList[Item.color];
                }
                if (Item.bold != null) bold = (bool)Item.bold;
                if (Item.italic != null) italic = (bool)Item.italic;
                if (Item.underlined != null) underlined = (bool)Item.underlined;
                if (Item.strikethrough != null) strikethrough = (bool)Item.strikethrough;

                FontStyle style = new FontStyle();
                if (bold) style = style | FontStyle.Bold;
                if (italic) style = style | FontStyle.Italic;
                if (underlined) style = style | FontStyle.Underline;
                if (strikethrough) style = style | FontStyle.Strikeout;

                var data = new TextData();
                data.Start = Preview.Text.Length;
                data.Length = add_text.Length;
                data.Color = color;
                data.Style = style;
                textdata.Add(data);

                Preview.Text += add_text;
            }
            foreach(var data in textdata)
            {
                Preview.Select(data.Start, data.Length);
                Preview.SelectionColor = data.Color;
                if (data.Style != new FontStyle())
                {
                    Font fnt = new Font(Preview.Font.FontFamily, Preview.Font.Size, data.Style);
                    Preview.SelectionFont = fnt;
                    fnt.Dispose();
                }
            }
            Preview.Select(0, 0);
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
            if ((string)ColorSelect.SelectedItem != "未指定") { Item.color = (string)ColorSelect.SelectedItem; }
            if (Bold.SelectedIndex > 0) { Item.bold = (string)Bold.SelectedItem == "T"; }
            if (Italic.SelectedIndex > 0) { Item.italic = (string)Italic.SelectedItem == "T"; }
            if (Underlined.SelectedIndex > 0) { Item.underlined = (string)Underlined.SelectedItem == "T"; }
            if (Strikethrough.SelectedIndex > 0) { Item.strikethrough = (string)Strikethrough.SelectedItem == "T"; }
            if (Obfuscated.SelectedIndex > 0) { Item.obfuscated = (string)Obfuscated.SelectedItem == "T"; }

            //click&hover
            if ((string)ClickAction.SelectedItem != "使用しない")
            {
                JsonData.ClickEvent clickEvent = new JsonData.ClickEvent();
                clickEvent.action = (string)ClickAction.SelectedItem;
                clickEvent.value = ClickValue.Text;
                Item.clickEvent = clickEvent;
            }
            if ((string)HoverAction.SelectedItem != "使用しない")
            {
                JsonData.HoverEvent hoverEvent = new JsonData.HoverEvent();
                hoverEvent.action = (string)HoverAction.SelectedItem;
                hoverEvent.value = HoverValue.Text;
                Item.hoverEvent = hoverEvent;
            }
            ListJsonItems.Items.Add(JsonConvert.SerializeObject(Item, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }));

            Preview_Show();
        }

        private void ColorSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((string)ColorSelect.SelectedItem)
            {
                case "未指定": ColorShow.BackColor = Color.FromName("Control"); break;
                case "reset": ColorShow.BackColor = Color.FromName("Control"); break;
                default: ColorShow.BackColor = ColorList[(string)ColorSelect.SelectedItem]; break;
            }
        }

        private void TranslateWithAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var with = JsonConvert.DeserializeObject<JsonData>(TranslateWith.Text);
                TranslateWithList.Items.Add(JsonConvert.SerializeObject(with, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }));
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

        private void ItemClear_Click(object sender, EventArgs e)
        {
            ItemAllClear();
        }

        private void ListItemUp_Click(object sender, EventArgs e)
        {
            if (ListJsonItems.SelectedIndex > 0)
            {
                int index = ListJsonItems.SelectedIndex;
                var tmp = ListJsonItems.Items[index];
                ListJsonItems.Items[index] = ListJsonItems.Items[index - 1];
                ListJsonItems.Items[index - 1] = tmp;
            }
        }

        private void ListItemDown_Click(object sender, EventArgs e)
        {
            if (ListJsonItems.SelectedIndex > -1 && ListJsonItems.SelectedIndex < ListJsonItems.Items.Count)
            {
                int index = ListJsonItems.SelectedIndex;
                var tmp = ListJsonItems.Items[index];
                ListJsonItems.Items[index] = ListJsonItems.Items[index + 1];
                ListJsonItems.Items[index + 1] = tmp;
            }
        }

        private void ListRemove_Click(object sender, EventArgs e)
        {
            if (ListJsonItems.SelectedIndex > -1) ListJsonItems.Items.RemoveAt(ListJsonItems.SelectedIndex);
        }

        private void ListClear_Click(object sender, EventArgs e)
        {
            ListJsonItems.Items.Clear();
        }

        private void ListResetting_Click(object sender, EventArgs e)
        {
            if (ListJsonItems.SelectedIndex > -1)
            {
                ItemAllClear();
                var Item = JsonConvert.DeserializeObject<JsonData>(ListJsonItems.Items[ListJsonItems.SelectedIndex].ToString());
                if (Item.text != null) { TabSetting.SelectedIndex = 0; TextValue.Text = Item.text; }
                if (Item.selector != null) { TabSetting.SelectedIndex = 1; Selector.Text = Item.selector; }
                if (Item.score != null) { TabSetting.SelectedIndex = 2; ScoreSelector.Text = Item.score.name; ScoreScoreboard.Text = Item.score.objective; }
                if (Item.translate != null)
                {
                    TabSetting.SelectedIndex = 3;
                    TranslateText.Text = Item.translate;
                    foreach (var with in Item.with) TranslateWithList.Items.Add(with.ToString());
                }
                if (Item.keybind != null) { TabSetting.SelectedIndex = 4; Keybind.Text = Item.keybind; }
                switch (Item.color)
                {
                    case null: ColorSelect.SelectedIndex = 0; break;
                    case "reset": ColorSelect.SelectedIndex = 1; break;
                    case "black": ColorSelect.SelectedIndex = 2; break;
                    case "dark_blue": ColorSelect.SelectedIndex = 3; break;
                    case "dark_green": ColorSelect.SelectedIndex = 4; break;
                    case "dark_aqua": ColorSelect.SelectedIndex = 5; break;
                    case "dark_red": ColorSelect.SelectedIndex = 6; break;
                    case "dark_purple": ColorSelect.SelectedIndex = 7; break;
                    case "gold": ColorSelect.SelectedIndex = 8; break;
                    case "gray": ColorSelect.SelectedIndex = 9; break;
                    case "dark_gray": ColorSelect.SelectedIndex = 10; break;
                    case "blue": ColorSelect.SelectedIndex = 11; break;
                    case "green": ColorSelect.SelectedIndex = 12; break;
                    case "aqua": ColorSelect.SelectedIndex = 13; break;
                    case "red": ColorSelect.SelectedIndex = 14; break;
                    case "light_purple": ColorSelect.SelectedIndex = 15; break;
                    case "yellow": ColorSelect.SelectedIndex = 16; break;
                    case "white": ColorSelect.SelectedIndex = 17; break;
                }
                Bold.SelectedIndex = StyleToNumber(Item.bold);
                Italic.SelectedIndex = StyleToNumber(Item.italic);
                Underlined.SelectedIndex = StyleToNumber(Item.underlined);
                Strikethrough.SelectedIndex = StyleToNumber(Item.strikethrough);
                Obfuscated.SelectedIndex = StyleToNumber(Item.obfuscated);
                if (Item.clickEvent != null)
                {
                    switch (Item.clickEvent.action)
                    {
                        case "open_url": ClickAction.SelectedIndex = 1; break;
                        case "run_command": ClickAction.SelectedIndex = 2; break;
                        case "change_page": ClickAction.SelectedIndex = 3; break;
                        case "suggest_command": ClickAction.SelectedIndex = 4; break;
                    }
                    ClickValue.Text = Item.clickEvent.value ?? "";
                }
                if (Item.hoverEvent != null)
                {
                    switch (Item.hoverEvent.action)
                    {
                        case "show_text": HoverAction.SelectedIndex = 1; break;
                        case "show_item": HoverAction.SelectedIndex = 2; break;
                        case "show_entity": HoverAction.SelectedIndex = 3; break;
                    }
                    HoverValue.Text = Item.hoverEvent.value ?? "";
                }
                ListJsonItems.Items.RemoveAt(ListJsonItems.SelectedIndex);
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            List<string> item = new List<string>();
            foreach (var tmp in ListJsonItems.Items)
            {
                item.Add((string)tmp);
            }
            switch (item.Count) {
                case 0: JSON = ""; break;
                case 1: JSON = item[0]; break;
                default: JSON = $"[\"\",{string.Join(",", item)}]"; break;
        }
            DialogResult = DialogResult.OK;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }

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

    public class TextData
    {
        public int Start { get; set; }
        public int Length { get; set; }
        public Color Color { get; set; }
        public FontStyle Style { get; set; }
    }
}
