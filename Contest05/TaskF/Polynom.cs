using System;
using System.Collections.Generic;

class Polynom
{

    public static bool TryParsePolynom(string line, out int[] arr)
    {

        bool flag = true;
        
        string[] a = line.Split();

        arr = new int[a.Length];

        Array.Reverse(a);
        for (int i = 0; i < a.Length; i++)
        {
            if (!int.TryParse(a[i], out arr[i]))
            {
                flag = false;
            }
            
        }
        return flag;
    }

    public static int[] Sum(int[] a, int[] b)
    {
        if (b.Length==1&&b[0]==0)
        {
            return a;
        }
        if (a.Length == 1 && a[0] == 0)
        {
            return b;
        }

        
        if (a.Length > b.Length)
        {
            Array.Reverse(b);
            int[] t = new int[a.Length];
            int[] d = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                if (i < b.Length)
                {
                    d[i] = b[i];
                }
                else
                {
                    d[i] = 0;
                }
            }
            Array.Reverse(b);
            Array.Reverse(d);
            for (int i = 0; i < a.Length; i++)
            {
                t[i] = a[i] + d[i];
            }
            return t;

        }
        else
        {
            Array.Reverse(a);
            int[] t = new int[b.Length];
            int[] d = new int[b.Length];
            for (int i = 0; i < b.Length; i++)
            {
                if (i < a.Length)
                {
                    d[i] = a[i];
                }
                else
                {
                    d[i] = 0;
                }
            }
            Array.Reverse(a);
            Array.Reverse(d);
            for (int i = 0; i < b.Length; i++)
            {
                t[i] = d[i] + b[i];
            }
            return t;

        }
    }

    public static int[] Dif(int[] a, int[] b)
    {
        if (b.Length == 1 && b[0] == 0)
        {
            return a;
        }
        if (a.Length == 1 && a[0] == 0)
        {
            int[] c = new int[b.Length];
            for (int i = 0; i < b.Length; i++)
            {
                c[i] = -b[i];
            }
            return c;
        }

        
        if (a.Length > b.Length)
        {
            Array.Reverse(b);
            int[] t = new int[a.Length];
            int[] d = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                if (i < b.Length)
                {
                    d[i] = b[i];
                }
                else
                {
                    d[i] = 0;
                }
            }
            Array.Reverse(b);

            Array.Reverse(d);
            for (int i = 0; i < a.Length; i++)
            {
                t[i] = a[i] - d[i];
            }
            return t;

        }
        else if(a.Length < b.Length)
        {
            Array.Reverse(a);

            int[] t = new int[b.Length];
            int[] d = new int[b.Length];
            for (int i = 0; i < b.Length; i++)
            {
                if (i < a.Length)
                {
                    d[i] = a[i];
                }
                else
                {
                    d[i] = 0;
                }
                
            }
            Array.Reverse(a);
            Array.Reverse(d);
            for (int i = 0; i < b.Length; i++)
            {
                t[i] = d[i] - b[i];
            }
            return t;

        }
        else
        {
            


            int[] t = new int[a.Length];
            
            for (int i = 0; i < b.Length; i++)
            {
                

                t[i] = a[i] - b[i];
            }
            
            return t;
        }
    }

    public static int[] MultiplyByNumber(int[] a, int n)
    {
        
        int[] t = new int[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            t[i] = a[i] * n;
            
        }
        
        return t;
    }

    public static int[] MultiplyByPolynom(int[] a, int[] b)
    {

        //int h = 2 * (a.Length - 1);
        //int[] v = new int[h + 1];
        //v[0] = a[0] * b[0];
        //v[h] = a[a.Length - 1] * b[b.Length - 1];
        //for (int y = 1; y < h; y++)
        //{
        //  int g = 0;
        //    for (int i = 0; i < a.Length; i++)
        //  {
        //        for (int j = 0; j < b.Length; j++)
        //        {
        //            if (i + j == h - y)
        //            {
        //                g += a[i] * b[j];
        //            }
        //       }
        //   }
        //    v[y] = g;
        //}
        //return v;

        int k = a.Length - 1;
        int h = 2 * (a.Length - 1);
        int[] v = new int[h + 1];

        if ((a.Length == 1 && a[0] == 0) || (b.Length == 1 && b[0] == 0)) 
        {
            int[] j = new int[1] { 0 };
            return j;
        }

        if (a.Length > b.Length)
        {

            Array.Reverse(b);
            int[] d = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                if (i < b.Length)
                {
                    d[i] = b[i];
                }
                else
                {
                    d[i] = 0;
                }
            }
            Array.Reverse(b);
            Array.Reverse(d);

            k = a.Length - 1;
            h = 2 * (a.Length - 1);
            v = new int[h + 1];
            v[0] = a[0] * d[0];
            v[h] = a[a.Length - 1] * d[d.Length - 1];
            for (int p = 0; p < h; p++)
            {
                if (p <= k)
                {
                    int s = 0;
                    for (int i = 0; i <= p; i++)
                    {
                        s += a[p - i] * d[i];
                    }
                    v[p] = s;
                }
                else
                {
                    int s = 0;
                    int z = p - k;
                    for (int i = 0; i <= k - z; i++)
                    {
                        s += a[a.Length - 1 - i] * d[i + z];
                    }
                    v[p] = s;
                }
            }
            


        }
        else if (a.Length<b.Length)
        {
            Array.Reverse(a);
            
            int[] d = new int[b.Length];
            for (int i = 0; i < b.Length; i++)
            {
                if (i < a.Length)
                {
                    d[i] = a[i];
                }
                else
                {
                    d[i] = 0;
                }
            }
            Array.Reverse(a);

            Array.Reverse(d);

            k = d.Length - 1;
            h = 2 * (d.Length - 1);
            v = new int[h + 1];
            v[0] = d[0] * b[0];
            v[h] = d[d.Length - 1] * b[b.Length - 1];
            for (int p = 0; p < h; p++)
            {
                if (p <= k)
                {
                    int s = 0;
                    for (int i = 0; i <= p; i++)
                    {
                        s += d[p - i] * b[i];
                    }
                    v[p] = s;
                }
                else
                {
                    int s = 0;
                    int z = p - k;
                    for (int i = 0; i <= k - z; i++)
                    {
                        s += d[d.Length - 1 - i] * b[i + z];
                    }
                    v[p] = s;
                }
            }
            



        }
        else
        {
            k = a.Length - 1;
            h = 2 * (a.Length - 1);
            v = new int[h + 1];
            v[0] = a[0] * b[0];
            v[h] = a[a.Length - 1] * b[b.Length - 1];
            for (int p = 0; p < h; p++)
            {
                if (p <= k)
                {
                    int s = 0;
                    for (int i = 0; i <= p; i++)
                    {
                        s += a[p - i] * b[i];
                    }
                    v[p] = s;
                }
                else
                {
                    int s = 0;
                    int z = p - k;
                    for (int i = 0; i <= k - z; i++)
                    {
                        s += a[a.Length - 1 - i] * b[i + z];
                    }
                    v[p] = s;
                }
                
            }
            
        }
        
        return v;
       


       
    }

    public static string PolynomToString(int[] polynom)
    {
        bool flag = false;
        for(int i = 0; i < polynom.Length; i++)
        {
            if (polynom[i] != 0)
            {
                flag = true;
            }
        }
        if (flag == false)
        {
            return 0.ToString();
          
        }
        int d = polynom.Length;
        List<string> l = new List<string>();
       
        for(int i = 0; i < d ; i++)
        {
            
            if (polynom[i] != 0)
            {
                if (d - i - 1 == 0)
                {
                    l.Add(polynom[i].ToString());
                }
                else
                {
                    if (d - i - 1 == 1)
                    {
                        if (polynom[i] != 1 && polynom[i] != -1)
                        {
                            l.Add(polynom[i] + "x");
                        }

                        else
                        {
                            if (polynom[i] == -1)
                            {
                                l.Add("-x");
                            }
                            else
                            {
                                l.Add("x");
                            }
                        }

                    }
                    else
                    {
                        if (polynom[i] != 1 && polynom[i] != -1)
                        {
                            l.Add(polynom[i] + "x" + (d - 1 - i));
                        }
                        else
                        {
                            if (polynom[i] == -1)
                            {
                                l.Add("-x"+ (d - 1 - i));
                            }
                            else
                            {
                                l.Add("x" + (d - 1 - i));
                            }
                            
                        }
                    }
                }
            }
        }
        
        return string.Join(" + ", l);
        
    }
}
