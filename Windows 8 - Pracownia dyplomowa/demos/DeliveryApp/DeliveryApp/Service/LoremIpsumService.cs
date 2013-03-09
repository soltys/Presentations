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
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras feugiat fringilla sem, eu iaculis nisl suscipit at. Integer euismod, metus sed egestas fermentum, justo mauris malesuada lorem, at volutpat lacus massa eget est. Suspendisse eget convallis nisi. Cras quis laoreet sem. Nunc ut lacus quis quam facilisis pulvinar. Ut eu dolor turpis. Fusce vulputate, felis et sagittis fermentum, ante ipsum pulvinar orci, id blandit nisl dui in turpis. Duis tellus lacus, feugiat vitae mollis sed, interdum vitae tortor. Mauris vel est ut diam elementum suscipit ac sodales felis. Nullam consectetur cursus ligula nec dictum. Pellentesque nibh libero, mattis quis vulputate id, interdum in lacus. Vestibulum in urna leo. Ut eu tortor nec arcu feugiat tincidunt eget lobortis massa. Donec tincidunt porta purus quis sodales. Nunc et quam sit amet orci volutpat convallis." +
            "Nulla facilisi. Aliquam lacus nulla, vulputate eu vehicula quis, condimentum nec quam. Maecenas est purus, facilisis sit amet vulputate vel, consequat sed massa. Donec eu nibh ante, et tincidunt justo. Sed viverra interdum augue ac rutrum. Donec dui magna, eleifend in luctus a, mollis id magna. Etiam nibh ipsum, lacinia vel volutpat ut, porttitor vitae lorem. Vivamus molestie odio tortor, non commodo felis. Maecenas consequat commodo mauris. Mauris vitae tellus nisl. Suspendisse blandit rutrum lacus, non venenatis massa consectetur non. Nulla tempor, nunc sed lacinia lacinia, odio risus facilisis quam, ut volutpat lectus erat faucibus leo. Quisque vulputate pulvinar enim, eu luctus arcu lacinia vestibulum. Fusce non sapien felis, cursus pretium turpis. Praesent sed tortor augue. " +
            "Duis tincidunt odio nec magna interdum laoreet. Donec volutpat ante ac justo feugiat volutpat. Aliquam pulvinar semper tincidunt. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin vel sem vel mi imperdiet mattis. Fusce eu congue nisl. Nunc at lorem mi, vel consequat tortor. Donec vulputate lectus enim. Integer turpis augue, tempor sed sollicitudin id, adipiscing nec nunc. Proin mollis, velit a auctor commodo, ante lacus consectetur est, non dignissim augue risus tristique mauris. Aenean diam nunc, feugiat sed venenatis eu, posuere a nulla. Sed ut massa ut nulla scelerisque tempus nec ut turpis. Integer ac viverra orci. ";
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
