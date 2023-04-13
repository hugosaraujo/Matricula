using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matricula
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public bool status { get; set; }
        public string Curso { get; set; }

        private int matricula;
        public int Matricula 
        {
            get 
            { 
                return matricula; 
            }
            set 
            { 
                if (value <= 0) 
                {
                    Console.WriteLine("Valor da Matrícula é inválido");
                    Console.WriteLine("O valor precisa ser maior que 0");
                } 
                else
                {
                    matricula = value;
                }
            }
        }
    }
}
