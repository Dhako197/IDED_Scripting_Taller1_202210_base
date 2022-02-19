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

            List<int> temporal = new List<int>();
            int nroTemp;

            foreach (var entry in sourceDict)
            {
                temporal.Add(entry.key);
            }

            for (int i=0; i<= temporal.Length; i++)
            {
                for(int j=0; j<= temporal.Length; j++)
                {
                    if(temporal[j]< temporal[j + 1])
                    {
                        nroTemp = temporal[j + 1];
                        temporal[j + 1] = temporal[j];
                        temporal[j] = nroTemp;
                    }
                }

            }

            int[temporal.Length] arregloDes;
            for (int i=0; i<=temporal.Length;i++)
            {
                arregloDes[i] = temporal[i];
            }          

            Dictionary<int, EValueType> result= FillDictionaryFromSource(arregloDes);

            return result;
        }

       internal static Queue<Ticket>[] ClassifyTickets(List<Ticket> sourceList)
        {

            Queue<Ticket> payments = new Queue<Ticket>();
            Queue<Ticket> subscription = new Queue<Ticket>();
            Queue<Ticket> cancellation = new Queue<Ticket>();

            List<Ticket> ordenada = OrdenarListaTiquetes(sourceList);

            foreach(Ticket tiquete in ordenada)
            {
                if(tiquete.RequestType == Ticket.ERequestType.Payment)
                {
                    payments.Enqueue(tiquete);
                }
                else if(tiquete.RequestType== Ticket.ERequestType.Subscription)
                {
                    subscription.Enqueue(tiquete);
                }
                else if (tiquete.RequestType == Ticket.ERequestType.Cancellation)
                {
                    cancellation.Enqueue(tiquete);
                }
            }

            Queue<Ticket>[] result = new Queue<Ticket>(payments, subscription, cancellation);

            return result;
        }

        internal static List<Ticket> OrdenarListaTiquetes(List<Ticket> lista)
        {
            Ticket temp;
            for (int i = 0; i <= lista.Length; i++)
            {
                for (int j = 0; j <= lista.Length; j++)
                {
                    if (lista[j].Turn > lista[j + 1].Turn)
                    {
                       temp = lista[j + 1];
                       lista[j + 1] = lista[j];
                       lista[j] = temp;
                    }
                }

            }

            return lista;
        }
            

        internal static bool AddNewTicket(Queue<Ticket> targetQueue, Ticket ticket)
        {
            bool result;
            Ticket ultimoCola = targetQueue.Peek();
            if (ticket.RequestType == ultimoCola.RequestType)
            {
                result = true;

            }
            else result = false;

            return result;
        } 
    }
}
