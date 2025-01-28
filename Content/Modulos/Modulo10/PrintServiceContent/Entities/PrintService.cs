using System;


namespace Course.Entities
{
    internal class PrintService<T> // PARAMETRIZADO COM O TIPO T (Pode ser qualquer letra, desde que seja a msm letra p todos
    {

        private T[] _values = new T[10]; // criei uma variavel interna q armazenará 10 numeros inteiros
        private int _count = 0; // contar desde o 0

        public void AddValue(T value)
        {
            if (_count == 10) // se o count for igual a dez, então o vetor já está cheio
            {
                throw new InvalidOperationException("PrintService is Full");
            }
            _values[_count] = value; // vou na posição 0 do VETOR e armazeno a posição lá dentro do value
            _count++; // atualizar o valor do count p 1,2,3,4..
        }

        public T FirstElement()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("Print service is empty");
            }
            return _values[0];
        }
        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            if (_count > 0)
            {
                Console.Write(_values[_count - 1]);
            }
            Console.WriteLine("]");
        }
    }
}
