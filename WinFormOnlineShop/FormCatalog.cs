using OnlineShop;

namespace WinFormOnlineShop
{
    public partial class FormCatalog : Form
    {
        Catalog catalog = new Catalog();
        public FormCatalog()
        {
            InitializeComponent();
            catalog.Add(new Product("Вертолет", 100, "Игрушка веселая"));
            catalog.Add(new Product("Майка", 1005, "С принтом"));
            catalog.Add(new Product("Тапки", 250, "Пляжные"));
            catalog.Add(new Product("Тетрадь", 17, "По информатике"));
            ShowCatalog();
        }

        void ShowCatalog()
        {
            int i = 0;
            foreach (Product product in catalog.getAll())
                listBoxCatalog.Items.Add($"{++i} {product}");
        }

        private void listBoxCatalog_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
