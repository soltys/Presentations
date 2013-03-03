using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryApp.Service
{
    static class LoremIpsumService
    {
        static Random _randomGenerator = new Random();
        private static string _textLine =
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras feugiat fringilla sem, eu iaculis nisl suscipit at. Integer euismod, metus sed egestas fermentum, justo mauris malesuada lorem, at volutpat lacus massa eget est. Suspendisse eget convallis nisi. Cras quis laoreet sem. Nunc ut lacus quis quam facilisis pulvinar. Ut eu dolor turpis. Fusce vulputate, felis et sagittis fermentum, ante ipsum pulvinar orci, id blandit nisl dui in turpis. Duis tellus lacus, feugiat vitae mollis sed, interdum vitae tortor. Mauris vel est ut diam elementum suscipit ac sodales felis. Nullam consectetur cursus ligula nec dictum. Pellentesque nibh libero, mattis quis vulputate id, interdum in lacus. Vestibulum in urna leo. Ut eu tortor nec arcu feugiat tincidunt eget lobortis massa. Donec tincidunt porta purus quis sodales. Nunc et quam sit amet orci volutpat convallis.";

        private static string[] _words;
        static LoremIpsumService()
        {
            _textLine = _textLine.Replace(",", "");
            _textLine = _textLine.Replace(".", "");
            _words = _textLine.Split(' ');
        }

        public static string GetWords(int count)
        {
            string words = "";
            for (int i = 0; i < count; i++)
            {
                words += _words[_randomGenerator.Next(_words.Length)] + " ";
            }
            return words;
        }

    }
}
