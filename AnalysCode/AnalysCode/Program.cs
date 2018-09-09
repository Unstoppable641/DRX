using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalysCode
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        /*
         * 
        Func1 
            -рекурсивно вызывает себя каждый раз, когда не попадает в if'ы
            -возврашает low в первом ифе, рекурсивно вызывает себя если значение кея больше значения в массиве
             
        Func2
            -заполняет массив <Ключ, значение>
            -если массив пуст заполняет его по умолчанию
            -если значение Кеу меньше длинны массива ключей, то в позицию(pos) запишется 0
            -если введеное значение Кеу больше длинны массива, то в пос запишется текущая длинна массива
            -в любом другом случае будет записано значение из Func1 и выполнится 
            следующий код который увеличит максимальную длинну массива на 1 и в цикле
            выполнится условие того, что каждый элемент массива будет смещен на 1 значение массива влево
            до тех пор пока (длинна массива - 1) < текущей позиции записанной выше
        */

        static int Func1(KeyValuePair<int, string>[] a, int low, int high, int key)
        {
            int middle = low + ((high - low) / 2);
            if (low == high)
                return low;

            if (key > a[middle].Key)
                return Func1(a, middle + 1, high, key);

            return Func1(a, low, middle, key);
        }

        static void Func2(ref KeyValuePair<int, string>[] a, int key, string value)
        {
            int pos;

            KeyValuePair<int, string> keyValuePair;

            if (a.Length == 0)
            {
                Array.Resize(ref a, 1);
                keyValuePair = new KeyValuePair<int, string>(key, value);
                a[0] = keyValuePair;
                return;
            }

            if (key < a[0].Key)
                pos = 0;

            else if (key > a[a.Length - 1].Key)
                pos = a.Length;
            else
                pos = Func1(a, 0, a.Length - 1, key);

            Array.Resize(ref a, a.Length + 1);
            for (int i = a.Length - 1; i > pos; i--)
                a[i] = a[i - 1];

            keyValuePair = new KeyValuePair<int, string>(key, value);
            a[pos] = keyValuePair;
        }
    }
}
