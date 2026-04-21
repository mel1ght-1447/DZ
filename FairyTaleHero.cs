using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пример
{
    internal class FairyTaleHero: ICharacter
    {
        public string Name { get; set; } = "кто ты, герой";
        public string Target { get; set; } = "неопределился";
        string description = string.Empty; 
        string weapon = string.Empty;
        string type = string.Empty;
        public FairyTaleHero(string Name, string Target, string description, string weapon, string type)
        {
            this.Name = Name;
            this.Target = Target;
            this.description = description;
            this.weapon = weapon;
            this.type = type;
        }
        public void Speak()
        {
            MessageBox.Show("эээээээээ", "любая фраза",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void GetInfo() 
        {
            string msg = $"Имя персонажа: {Name}" + $"Цель: {Target}" + $"Описание: {description}"
                + $"Оружие: {weapon}" + $"Вид: {type}";
            MessageBox.Show(msg, $"Досье героя {Name}",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                
        }
    }
}
