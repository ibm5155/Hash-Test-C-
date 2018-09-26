using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    public static class md5
    {
        public static string GetMd5AsString(string input)
        {
            //Como criar MD5 no C# vindo de https://pt.stackoverflow.com/questions/17181/como-criptografar-e-descriptografar-dados-em-md5-utilizando-c

            MD5 md5Hash = MD5.Create();
            // Converter a String para array de bytes, que é como a biblioteca trabalha.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Cria-se um StringBuilder para recompôr a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop para formatar cada byte como uma String em hexadecimal
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }



        public static string CrackMd5(string input)
        {
            //https://sourceforge.net/projects/minimd5cracker/
            return BruteForceProcess(input);


        }

        private static string BruteForceProcess(string archivo)
        {
            string cadeias = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,y,x,z, ,-,_,+,=,0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,Y,X,Z";
            string array_3 = cadeias;
            string encontrado = "";
            string[] h = array_3.Split(new char[] { ',' });

            int desde = 1;
            int hasta = 4;
            string ac = archivo;

            int a = h.Count();
            //digitos variables
            int b = 0;
            int c_1 = 0;
            int c_2 = 0;
            int c_3 = 0;
            int c_4 = 0;
            int c_5 = 0;
            int c_6 = 0;


            bool hola = false;


            //1 digito
            if (desde == 1)
            {
                while (b < a && hola != true && encontrado == "")
                {
                    string palabras = h[b];


                    if (GetMd5AsString(palabras) == ac)
                    {
                        encontrado = palabras;
                        hola = true;

                    }
                    b++;



                }
                b = 0;
            }
            //fin 1 digito
            //2 digitos
            if (desde <= 2 && hasta >= 2)
            {
                while (b < a && hola != true && encontrado == "")
                {
                    c_1 = 0;
                    while (c_1 < a && hola != true && encontrado == "")
                    {

                        string palabras = h[b] + h[c_1];

                        if (GetMd5AsString(palabras) == ac)
                        {
                            encontrado = palabras;
                            hola = true;
                        }
                        c_1++;

                    }
                    b++;

                }
                b = 0;
                c_1 = 0;
            }
            //fin 2 digitos
            //3 digitos
            if (desde <= 3 && hasta >= 3)
            {
                while (b < a && hola != true && encontrado == "")
                {
                    c_1 = 0;
                    while (c_1 < a && hola != true && encontrado == "")
                    {
                        c_2 = 0;
                        while (c_2 < a && hola != true && encontrado == "")
                        {

                            string palabras = h[b] + h[c_1] + h[c_2];



                            if (GetMd5AsString(palabras) == ac)
                            { 
                                encontrado = palabras;
                                hola = true;
                            }
                            c_2++;
                        }
                        c_1++;

                    }
                    b++;

                }
                b = 0;
                c_1 = 0;
                c_2 = 0;
            }

            //fin 3 digitos
            // inicio 4 digitos
            if (desde <= 4 && hasta >= 4)
            {
                while (b < a && hola != true && encontrado == "")
                {
                    c_1 = 0;
                    while (c_1 < a && hola != true && encontrado == "")
                    {
                        c_2 = 0;
                        while (c_2 < a && hola != true && encontrado == "")
                        {
                            c_3 = 0;
                            while (c_3 < a && hola != true && encontrado == "")
                            {

                                string palabras = h[b] + h[c_1] + h[c_2] + h[c_3];

                                if (GetMd5AsString(palabras) == ac)
                                {

                                    encontrado = palabras;
                                    hola = true;

                                }


                                c_3++;
                            }
                            c_2++;
                        }
                        c_1++;

                    }
                    b++;

                }
                b = 0;
                c_1 = 0;
                c_2 = 0;
                c_3 = 0;

            }
            //fin 4 digitos
            return encontrado;
        }
    }
}
