using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Modulo1.Conteudo
{
    public class RestriçõesCSharp
    {
        /*  NÃO PODE COMEÇAR COM DÍGITO: use uma letra ou _
            NÃO PODE USAR ACENTOS OU TIL
            NÃO PODE TER ESPAÇO EM BRANCO
            USE NOMES QUE TENHAM SIGNIFICADO 

        CONVENÇÕES: 

        CAMEL CASE: lastName (parâmetro de métodos, variáveis dentro de métodos)

        PASCAL CASE: LastName (namespaces, classe, properties e métodos)

        PADRÃO _lastName (atributos "internos" da classe
        EXEMPLO:

        */

    }

    public class ContaBancaria
    {
        public string Titular { get; set; }
        public double _saldo { get; set; }

        public void Deposito(double quantia)
        {
            _saldo = quantia;
        }
        public double GetSaldo()
        {
            return _saldo;
        }

    }
}