using C1.Win.Themes;

namespace ThemeTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            C1ThemeController.ApplyThemeToControlTree(this, C1ThemeController.GetThemeByName("Office365White", false), null, true);

        }
    }
}
