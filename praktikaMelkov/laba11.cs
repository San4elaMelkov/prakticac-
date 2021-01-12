using System;
using System.Collections.Generic;
using System.Text;

namespace praktikaMelkov
{
    class laba11
    {
        public static void print()
        {
            Bit_String m1, m2, m3;
            m1 = Bit_String.Pinning("0000000000000110001");
            m2 = Bit_String.Pinning("0000000000000011001");
            m1 = Bit_String.dopCode(m1);
            m3 = m1 + m2;
            if (m2 == m1)
                Console.WriteLine("Строки равны");
            else
                Console.WriteLine("Строки не равны");
            Console.WriteLine($"Строка1: {m1.stringer}\n" +
                $"Строка2: {m2.stringer}\n" +
                $"Строка3: {m3.stringer}\n");
        }
        class String
        {
            private string[] str = new string[20];
            private int len { get; set;}
            public String(string[] str)
            {
                this.str = str;
            }
            public String(char a)
            {
                this.str[0] = Convert.ToString(a);
            }
            public String()
            {
                this.str = null;
            }
            public int  Len()
            {
                return this.len;
            }
            public void Clear()
            {
                this.str = null;
                this.len = 0;
            }

        }
        class Bit_String : String
        {

            public bool znak;
            public string stringer;
            public Bit_String(string str)
            {
                stringer = str;
            }
            ~Bit_String()
            {
            }
            public static Bit_String operator +(Bit_String m1, Bit_String m2)
            {
                Bit_String str = new Bit_String("0000000000000000000");
                char[] a = str.stringer.ToCharArray();
                for (int i = m1.stringer.Length - 1; i >= 0; i--)
                    a[i] = Convert.ToString(Convert.ToInt32(Convert.ToString(m1.stringer[i])) + Convert.ToInt32(Convert.ToString(m2.stringer[i])))[0];
                for (int i = m1.stringer.Length - 1; i > 0; i--)
                {

                    if (a[i] == '2')
                    {
                        a[i - 1] = Convert.ToString(Convert.ToInt32(Convert.ToString(a[i - 1])) + 1)[0];
                        a[i] = '0';
                    }
                    if (a[i] == '3')
                    {
                        a[i - 1] = Convert.ToString(Convert.ToInt32(Convert.ToString(a[i - 1])) + 1)[0];
                        a[i] = '1';
                    }


                }
                string g = "";
                for (int i = 0; i < a.Length; i++)
                    g += a[i];
                str.stringer = g;
                return str;
            }
            public static bool operator ==(Bit_String m1, Bit_String m2)
            {
                return m1.stringer == m2.stringer;
            }
            public static bool operator !=(Bit_String m1, Bit_String m2)
            {
                return m1.stringer != m2.stringer;
            }
            public static Bit_String dopCode(Bit_String m1)
            {
                char[] a = m1.stringer.ToCharArray();
                if (m1.znak == false)
                {
                    for (int i = a.Length - 1; i >= 0; i--)
                    {
                        if (a[i] == '0')
                            a[i] = '1';
                        else
                            a[i] = '0';
                    }
                    a[0] = Convert.ToChar(Convert.ToInt32(a[a.Length - 1]) + 1);
                    for (int i = a.Length - 1; i >= 0; i--)
                    {
                        if (a[i] == '2')
                        {
                            a[i - 1] = Convert.ToChar(Convert.ToInt32(a[i]) + 1);
                            a[i] = '0';
                        }
                        if (a[i] == '3')
                        {
                            a[i - 1] = Convert.ToChar(Convert.ToInt32(a[i]) + 1);
                            a[i] = '1';
                        }
                    }


                    m1.znak = true;
                }
                string g = "";
                for (int i = 0; i < a.Length; i++)
                    g += a[i];
                m1.stringer = g;
                return m1;
            }
            public static Bit_String Pinning(string str)
            {
                Bit_String m1 = new Bit_String(str);
                return m1;
            }


        }
    }
}
