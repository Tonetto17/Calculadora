using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalc
{
    /*Uma classe contém variáveis/atributos/propriedades e métodos/ funções que emprestara 
    Para os forms tudo que for PUBLIC aqui na classe*/
    public class Operacoes
    {
        //Declaração de variáveis 
        int total;

        //Declaração de métodos/ função

        // Criar a função soma
        public int somar (int x, int y) //x-> val1 e y->val2
        {
            total= x + y;
            return total;
        }
        public int subtrair (int x, int y)
        {
            total = x - y;
            return total;
        }
        public int dividir (int x, int y)
        {
            total = x / y;
            return total;
        }
        public int multiplicar (int x, int y)
        {
            total = x * y;
            return total;
        }

    }
}
