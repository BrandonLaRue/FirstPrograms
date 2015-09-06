using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        public string words = "";
        public string replace;

        bool revUsed = false;
        bool used = false;

        List<string> list = new List<string>();
        List<string> newList = new List<string>();

        Dictionary<string, string> dict = new Dictionary<string, string>();
        Dictionary<string, string> revDict = new Dictionary<string, string>();




        private void button1_Click(object sender, EventArgs e)
        {
            words = textBox1.Text;
            textBox1.Text = "";

            InitDict(used);

            for (int i = 0; i < words.Length; i += 2)
            {
                if ((i + 2) < words.Length)
                    list.Add(words.Substring(i, 2));

                else
                    list.Add(words.Substring(i));
            }

            foreach (string s in list)
            {
                if (dict.ContainsKey(s))
                {
                    dict.TryGetValue(s, out replace);
                    newList.Add(replace);
                }
            }

            foreach (string s in newList)
            {
                textBox1.Text += s;
            }

            used = true;
            list.Clear();
            newList.Clear();
        }



        private void button2_Click(object sender, EventArgs e)
        {

            InitDictRev(revUsed);
            words = textBox1.Text;
            textBox1.Text = "";

            for (int i = 0; i < words.Length; i += 1)
            {
                if ((i + 1) < words.Length)
                    list.Add(words.Substring(i, 1));

                else
                    list.Add(words.Substring(i));
            }

            foreach (string s in list)
            {
                if (revDict.ContainsKey(s))
                {
                    revDict.TryGetValue(s, out replace);
                    newList.Add(replace);
                }
            }

            foreach (string s in newList)
            {
                textBox1.Text += s;
            }

            list.Clear();
            newList.Clear();
            revUsed = true;
        }


        public void InitDict(bool used)
        {

            if (used == false)
            {
                dict.Add("aa", "1");
                dict.Add("ab", "2");
                dict.Add("ac", "3");
                dict.Add("ad", "4");
                dict.Add("ae", "5");
                dict.Add("af", "6");
                dict.Add("ag", "7");
                dict.Add("ah", "8");
                dict.Add("ai", "9");
                dict.Add("aj", "0");
                dict.Add("ba", "-");
                dict.Add("bb", "=");
                dict.Add("bc", "+");
                dict.Add("bd", "_");
                dict.Add("be", ")");
                dict.Add("bf", "(");
                dict.Add("bg", "*");
                dict.Add("bh", "&");
                dict.Add("bi", "^");
                dict.Add("bj", "%");
                dict.Add("ca", "$");
                dict.Add("cb", "#");
                dict.Add("cc", "@");
                dict.Add("cd", "!");
                dict.Add("ce", "[");
                dict.Add("cf", "]");
                dict.Add("cg", "{");
                dict.Add("ch", "}");
                dict.Add("ci", ";");
                dict.Add("cj", "'");
                dict.Add("da", ":");
                dict.Add("db", "\"");
                dict.Add("dc", "<");
                dict.Add("dd", ">");
                dict.Add("de", ",");
                dict.Add("df", ".");
                dict.Add("dg", "?");
                dict.Add("dh", "/");
                dict.Add("di", "q");
                dict.Add("dj", "w");
                dict.Add("ea", "e");
                dict.Add("eb", "r");
                dict.Add("ec", "t");
                dict.Add("ed", "y");
                dict.Add("ee", "u");
                dict.Add("ef", "i");
                dict.Add("eg", "o");
                dict.Add("eh", "p");
                dict.Add("ei", "l");
                dict.Add("ej", "k");
                dict.Add("fa", "j");
                dict.Add("fb", "h");
                dict.Add("fc", "g");
                dict.Add("fd", "f");
                dict.Add("fe", "d");
                dict.Add("ff", "s");
                dict.Add("fg", "a");
                dict.Add("fh", "z");
                dict.Add("fi", "x");
                dict.Add("fj", "c");
                dict.Add("ga", "v");
                dict.Add("gb", "b");
                dict.Add("gc", "n");
                dict.Add("gd", "m");
                dict.Add("ge", "Q");
                dict.Add("gf", "W");
                dict.Add("gg", "E");
                dict.Add("gh", "R");
                dict.Add("gi", "T");
                dict.Add("gj", "Y");
                dict.Add("ha", "U");
                dict.Add("hb", "I");
                dict.Add("hc", "O");
                dict.Add("hd", "P");
                dict.Add("he", "L");
                dict.Add("hf", "K");
                dict.Add("hg", "J");
                dict.Add("hh", "H");
                dict.Add("hi", "G");
                dict.Add("hj", "F");
                dict.Add("ia", "D");
                dict.Add("ib", "S");
                dict.Add("ic", "A");
                dict.Add("id", "Z");
                dict.Add("ie", "X");
                dict.Add("if", "C");
                dict.Add("ig", "V");
                dict.Add("ih", "B");
                dict.Add("ii", "N");
                dict.Add("ij", "M");
                dict.Add("ja", " ");
            }
        }

        public void InitDictRev(bool used)
        {

            if (used == false)
            {
                revDict.Add("1", "aa");
                revDict.Add("2", "ab");
				revDict.Add("3", "ac");
                revDict.Add("4", "ad");
				revDict.Add("5", "ae");
                revDict.Add("6", "af");
				revDict.Add("7", "ag");
                revDict.Add("8", "ah");
				revDict.Add("9", "ai");
                revDict.Add("0", "aj");
				revDict.Add("-", "ba");
                revDict.Add("=", "bb");
				revDict.Add("+", "bc");
                revDict.Add("_", "bd");
				revDict.Add(")", "be");
                revDict.Add("(", "bf");
				revDict.Add("*", "bg");
                revDict.Add("&", "bh");
				revDict.Add("^", "bi");
                revDict.Add("%", "bj"); 
				revDict.Add("$", "ca");
                revDict.Add("#", "cb");
				revDict.Add("@", "cc");
                revDict.Add("!", "cd");
				revDict.Add("[", "ce");
                revDict.Add("]", "cf");
				revDict.Add("{", "cg");
                revDict.Add("}", "ch");
				revDict.Add(";", "ci");
                revDict.Add("'", "cj");
				revDict.Add(":", "da");
                revDict.Add("\"", "db");
				revDict.Add("<", "dc");
                revDict.Add(">", "dd");
				revDict.Add(",", "de");
                revDict.Add(".", "df");
				revDict.Add("?", "dg");
                revDict.Add("/", "dh");
				revDict.Add("q", "di");
                revDict.Add("w", "dj"); 
				revDict.Add("e", "ea");
                revDict.Add("r", "eb");
				revDict.Add("t", "ec");
                revDict.Add("y", "ed");
				revDict.Add("u", "ee");
                revDict.Add("i", "ef");
				revDict.Add("o", "eg");
                revDict.Add("p", "eh");
				revDict.Add("l", "ei");
                revDict.Add("k", "ej");
				revDict.Add("j", "fa");
                revDict.Add("h", "fb");
				revDict.Add("g", "fc");
                revDict.Add("f", "fd");
				revDict.Add("d", "fe");
                revDict.Add("s", "ff");
				revDict.Add("a", "fg");
                revDict.Add("z", "fh");
				revDict.Add("x", "fi");
                revDict.Add("c", "fj"); 
				revDict.Add("v", "ga");
                revDict.Add("b", "gb");
				revDict.Add("n", "gc");
                revDict.Add("m", "gd");
				revDict.Add("Q", "ge");
                revDict.Add("W", "gf");
				revDict.Add("E", "gg");
                revDict.Add("R", "gh");
				revDict.Add("T", "gi");
                revDict.Add("Y", "gj");
				revDict.Add("U", "ha");
                revDict.Add("I", "hb");
				revDict.Add("O", "hc");
                revDict.Add("P", "hd");
				revDict.Add("L", "he");
                revDict.Add("K", "hf");
				revDict.Add("J", "hg");
                revDict.Add("H", "hh");
				revDict.Add("G", "hi");
                revDict.Add("F", "hj"); 
				revDict.Add("D", "ia");
                revDict.Add("S", "ib");
				revDict.Add("A", "ic");
                revDict.Add("Z", "id");
				revDict.Add("X", "ie");
                revDict.Add("C", "if");
				revDict.Add("V", "ig");
                revDict.Add("B", "ih");
				revDict.Add("N", "ii");
                revDict.Add("M", "ij");
				revDict.Add(" ", "ja");
            }

        }
    }
}
