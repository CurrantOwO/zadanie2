using System;

namespace zadanie2
{
    class Program
    {
        static void One(string a)
        {
            int t = -2;
            for (int i = 0; i < a.Length; i++) {
                if (a[i] == 'f') {
                    t++;
                    if (t == 0) { t = i; break; }
                }
            }
            Console.WriteLine(t);
        }
        static void two(string a)
        {
            string z = "абвгдезийклмнопрстуфхцъыьэ";
            char[] ar = { 'a', 'b', 'v', 'g', 'd', 'e', 'z', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 't', 'u', 'f', 'h', 'c', '`', 'y', '"', 'e' };
            string h = "жчш", ha = "zcs";
            string y = "ёюя", ya = "oua";
            string ka = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == ' ') { ka += " "; i++; }
                if (a[i] == 'щ') { ka += "shh"; }
                for (int g = 0; g < h.Length; g++) {
                    if (a[i] == h[g]) { ka = ka + ha[g] + "h"; i++; }
                    if (a[i] == y[g]) { ka = ka + "y" + ya[g]; i++; }
                }
                for (int l = 0; l < z.Length; l++) {
                    if (a[i] == z[l]) { ka = ka + ar[l]; }
                }
            }
            Console.WriteLine(a + " ==> " + ka);
        }
        static void tri(string s)
        {
            int n = 0, k = 0, z = 0;
            for (int i = 0; i < s.Length; i++) {
                if (s[i] == 'h') { n++; k = i; }
                if (n == 1) { z = i; }
            }
            if (n > 2) {
                string y = "", f = "", inn;
                for (int i = 0; i < z; i++) { y += s[i]; }
                for (int i = k; i < s.Length; i++) { f += s[i]; }
                s = s.Substring(z, k);
                inn = s.Replace('h', 'H');
                s = y + inn + f;
            }
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            One("0f24");
            two("третий котел слева");
            tri("haahooo4gho7huuu9");
        }
    }
}
