using System.Collections.Generic;

namespace TestProject1
{
    internal class TestMethods
    {
        internal enum EValueType
        {
            Two,
            Three,
            Five,
            Seven,
            Prime
        }

        internal static Stack<int> GetNextGreaterValue(Stack<int> sourceStack)
        {
             Stack<int> result;
            

            int[] arreglo = new int[sourceStack.Count];
            for(int i =0; sourceStack.Count >0; i++)
            {
                arreglo[i] = sourceStack.Pop;                
            }

            for (int i = 0; i <= arreglo.Length - 1; i++)
            {
                int comparar = arreglo[arreglo.Length - i];
                int resultado;
                int numeromayor = 0; 

                for(int i=arreglo.Length; i<=1; i--)
                {
                    if(comparar> arreglo[i- 1])
                    {
                        if(comparar< numeromayor)
                        {
                            resultado = numeromayor;
                        }
                        else
                        {
                            resultado = -1;
                        }
                        
                        
                    }
                    else if ( comparar < arreglo[i - 1])
                    {
                        numeromayor = arreglo[i - 1];
                        resultado = numeromayor;

                    }
                }
                result.Push(resultado);

            }

            result.Push(-1);
            return result;
        }

        internal static Dictionary<int, EValueType> FillDictionaryFromSource(int[] sourceArr)
        {
            Dictionary<int, EValueType> result = new Dictionary<int, EValueType>();
            

            for (int i= 0; i>= sourceArr.Length; i++)
            {
                if ((sourceArr[i - 1] % 2) == 0)
                {
                    Dictionary.Add(sourceArr[i - 1], EValueType.Two);
                }
                else if ((sourceArr[i-1]%3)==0)
                {
                    Dictionary.Add(sourceArr[i - 1], EValueType.Three);
                }
                else if ((sourceArr[i - 1] % 5) == 0)
                {
                    Dictionary.Add(sourceArr[i - 1], EValueType.Five);
                }
                else if ((sourceArr[i - 1] % 7) == 0)
                {
                    Dictionary.Add(sourceArr[i - 1], EValueType.Seven);
                }
                else if(EsPrimo(sourceArr[i-1]))
                {
                    Dictionary.Add(sourceArr[i - 1], EValueType.Prime);
                }
            }




            return result;
        }

        internal static bool EsPrimo(int numero)
        {

            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {                  
                    return false;
                }
            }

            return true;
        }

        internal static int CountDictionaryRegistriesWithValueType(Dictionary<int, EValueType> sourceDict, EValueType type)
        {
            int count=0;
            foreach (var entry in sourceDict)
            {
                if (entry.Value == type) count++;
            }
            return count;
        }

        internal static Dictionary<int, EValueType> SortDictionaryRegistries(Dictionary<int, EValueType> sourceDict)
        {
            Dictionary<int, EValueType> result = null;

            return result;
        }

        internal static Queue<Ticket>[] ClassifyTickets(List<Ticket> sourceList)
        {
            Queue<Ticket>[] result = null;

            return result;
        }

        internal static bool AddNewTicket(Queue<Ticket> targetQueue, Ticket ticket)
        {
            bool result = false;

            return result;
        }        
    }
}
