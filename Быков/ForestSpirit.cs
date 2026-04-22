using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Пример
{
    internal class ForestSpirit: ICharacter
    {
        public string Name { get; set; } = "неизвестно";
        public string Target { get; set; } = "неопределился";
           
        string description = string.Empty;
        string attitudeTowardsPeople = string.Empty;
        string height = string.Empty;
        string appearance = string.Empty;
        string type = string.Empty;
        public ForestSpirit(string Name, string Target, string description, string attitudeTowardsPeople, string height, string appearance, string type)
        {
            this.Name = Name;
            this.Target = Target;
            this.description = description;
            this.attitudeTowardsPeople = attitudeTowardsPeople;
            this.height = height;
            this.appearance = appearance;
            this.type = type;
        }
        public void Speak()
        {
            MessageBox.Show("Следуй за мной", "любая фраза",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void GetInfo()
        {
            string msg = $"Имя персонажа: {Name}\n" + $"Цель: {Target}\n" + $"Описание: {description}\n" + $"Отношение к людям: {attitudeTowardsPeople}\n" + $"Рост: {height} см\n" + $"Облик: {appearance}\n"
                 + $"Вид: {type}\n";
            MessageBox.Show(msg, $"Досье лешего",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
