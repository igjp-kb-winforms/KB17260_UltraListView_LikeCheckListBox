using Infragistics.Win.UltraWinListView;

namespace KB17260_WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // View を List に、チェックボックスを有効化
            ultraListView1.View = UltraListViewStyle.List;
            ultraListView1.ViewSettingsList.CheckBoxStyle = CheckBoxStyle.CheckBox;  // :contentReference[oaicite:0]{index=0}

            // アイコンを非表示にするため、ImageSize を空に設定
            ultraListView1.ViewSettingsList.ImageSize = Size.Empty;

            // サンプルデータ（キー＋表示名）
            var customers = new[]
            {
                new { Key = "ALFKI", Name = "Alfreds Futterkiste" },
                new { Key = "ANATR", Name = "Ana Trujillo Emparedados y helados" },
                new { Key = "ANTON", Name = "Antonio Moreno Taquería" }
            };

            // UltraListView に項目を追加
            foreach (var cust in customers)
                ultraListView1.Items.Add(cust.Key, cust.Name);

        }

        private void ultraListView1_ItemCheckStateChanged(object sender, ItemCheckStateChangedEventArgs e)
        {
            var checkState = e.Item.CheckState;
            MessageBox.Show($"“{e.Item.Value}” が {checkState} になりました");
        }
    }
}
