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

            for (int i = 0; i >= arreglo.Length - 1; i++)
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

            return result;
        }

        internal static Dictionary<int, EValueType> FillDictionaryFromSource(int[] sourceArr)
        {
            Dictionary<int, EValueType> result = null;

            return result;
        }

        internal static int CountDictionaryRegistriesWithValueType(Dictionary<int, EValueType> sourceDict, EValueType type)
        {
            return 0;
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
