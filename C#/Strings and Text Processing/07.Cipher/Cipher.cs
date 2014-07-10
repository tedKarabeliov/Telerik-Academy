using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Cipher
{
    static void Main()
    {
        Console.WriteLine("Enter text:");
        string text = Console.ReadLine();
        Console.WriteLine("Enter cipher:");
        string cipher = Console.ReadLine();
        for (int i = 0, k = 0; i < text.Length; i++, k++)
        {
            if (k == cipher.Length)
            {
                k = 0;
            }
            Console.Write(String.Format("\\u{0:x4}",text[i] ^ cipher[k]));
        }
        
    }
}

