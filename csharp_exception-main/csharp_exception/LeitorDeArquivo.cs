﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exception
{
    public class LeitorDeArquivo //: IDisposable //Syntax Sugar 
    {
        public string Arquivo { get; }

        public LeitorDeArquivo(string arquivo)
        {
            Arquivo = arquivo;

            // throw new FileNotFoundException(); 

            Console.WriteLine("Abrindo arquivo: " + arquivo);
        }

        public string LerProximaLinha()
        {
            Console.WriteLine("Lendo linha. . .");
            throw new IOException(); 

            return "Linha do arquivo";
        }

        public void Fechar() //Dispose()
        {
            Console.WriteLine("Fechando arquivo.");
        }
    }
}
