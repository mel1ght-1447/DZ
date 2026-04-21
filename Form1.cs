namespace Пример
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnstart_Click(object sender, EventArgs e)
        { 
            FairyTaleHero hero = new FairyTaleHero("Евгений ", "Выбивание долга ", "Злой ", "РПГ ", "Леший");
            hero.Speak();
            hero.GetInfo();
            FairyTaleHero hero1 = new FairyTaleHero("", "", "Злой ", "нож ", "человек");
            hero1.Speak();
            hero1.GetInfo();
        }
    }
}
