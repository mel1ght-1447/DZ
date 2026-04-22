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
            FairyTaleHero hero = new FairyTaleHero("Евгений ", "отсутствует", "дружелюбный", "человек");
            hero.Speak();
            hero.GetInfo();
            FairyTaleHero hero1 = new FairyTaleHero("", "", "", "человек");
            hero1.Speak();
            hero1.GetInfo();
           ForestSpirit spirit = new ForestSpirit("Лесной дух", "помогать заблудшим", "загадочный и могущественный", "дружелюбный", "200", "человекоподобный, но с элементами природы", "Леший");
            spirit.Speak();
            spirit.GetInfo();
        }
    }
}
