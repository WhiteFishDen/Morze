using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morse
{
    internal class decryptor
    {
        char[] _letters = new char[] {'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И',
                                      'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
                                      'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ы', 'Ь',
                                      'Э', 'Ю', 'Я', '1', '2', '3', '4', '5', '6', '7',
                                      '8', '9', '0'};
        string[] _codeMorse = new string[] { "*_", "_***", "*__", "__*",
                                            "_**", "*", "***_", "__**",
                                             "**", "*___", "_*_", "*_**",
                                             "__", "_*", "___", "*__*",
                                             "*_*", "***", "_", "**_",
                                             "**_*", "****", "_*_*",
                                             "___*", "____", "__*_",
                                             "_*__", "_**_", "**_**",
                                             "**__", "*_*_", "*____",
                                             "**___", "***__", "****_",
                                             "*****", "_****", "__***",
                                             "___**", "____*", "_____"};
        public string ToMorse(string input)
        {
            input = input.ToUpper();
            string output="";
            int indexOfchar;
            foreach (var item in input)
            {
                if(item!=' ')
                {
                    indexOfchar = Array.IndexOf(_letters, item);
                    output += _codeMorse[indexOfchar] + " ";
                }
            }
            output = output.Remove(output.Length - 1);                   
            return output;
        }
        public string ToLetter(string input)
        {
            string[] splitInput = input.Split(' ');
            string output = " ";
            int indexOfchar;
            foreach (var item in splitInput)
            {
                indexOfchar = Array.IndexOf(_codeMorse, item);
                output += _letters[indexOfchar] + " ";
            }
            output = output.Remove(output.Length - 1);
            return output;
        }
    }
}
