using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsomeWSCEP {
    using System.Net;
    using ConsultaCEP;
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("CEP: ");
            var cep = Console.ReadLine();

            var obj = new BuscaCEP();
            ConsultaCEP.WebServiceCEP.enderecoERP endereco = obj.ConsultaCEP(cep);
            string logradouro = endereco.end;
            string bairro = endereco.bairro;
            string cidade = endereco.cidade;
            string uf = endereco.uf;

            Console.WriteLine("Endereço: "+logradouro+"\nBairro: "+bairro+"\nCidade: "+cidade+"\nEstado: "+uf);
            Console.ReadKey();
        }
    }
}
