using System;
using System.Collections.Generic;
using System.Windows;

namespace InspirationalQuotes
{
    public partial class MainWindow : Window
    {
        private List<string> zitati = new List<string>()
        {
            "Кто рано встаёт — тому весь день спать хочется.",
            "Мама учила не ругаться матом, но жизнь научила не ругаться матом при маме",
            "Секрет жизни в том, чтобы падать семь раз и подниматься восемь.",
            "Если ты не идешь вперед, ты идешь назад.",
            "Позвоночник знаешь? Я позвонил.",
            "Делай, как надо. Как не надо, не делай.",
            "Сила не в бабках. Ведь бабки уже старые и слабые.",
            "В жизни всегда есть две дороги: одна — первая, а другая — вторая.",
            "Заблудился в лесу — иди домой.",
            "Победители не сдаются, а сдающиеся не побеждают.",
            "Упал - вставай , встал - упай! 👆"
        };
        private Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetZitataButton_Click(object sender, RoutedEventArgs e)
        {
            int randomIndex = random.Next(zitati.Count);
            string randomZitata = zitati[randomIndex];
            zitataText.Text = randomZitata;
        }
    }
}