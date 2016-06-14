using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Show_do_Pila
{
    public class questao
    {
        public string Pergunta;
        public int Id;
        public string AlternativaCorreta;
        public string Alternativa1;
        public string Alternativa2;

        public questao(int i, string p, string ac, string a1, string a2)
        {
            Pergunta = p;
            Id = i;
            AlternativaCorreta = ac;
            Alternativa1 = a1;
            Alternativa2 = a2;
        }
    }
}