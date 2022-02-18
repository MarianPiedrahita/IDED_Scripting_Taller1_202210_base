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
            Stack<int> result = null;
            result = new Stack<int>();
            int[] preResultList = sourceStack.ToArray();
            int max = 0;
            
            for (int i = 0; i < sourceStack.Count; i++)
            {
                if (preResultList[i] >= max)
                {
                    max = preResultList[i];
                    preResultList[i] = -1;
                    //result.Push(-1);
                }
                else
                {
                    preResultList[i] = max;
                    //result.Push(max);
                }
            }

            int k = 0;
            int j = preResultList.Length - 1;
            while (k < j)
            {
                var temp = preResultList[k];
                preResultList[k] = preResultList[j];
                preResultList[j] = temp;
                k++;
                j--;
            }

            for (int i = 0; i < sourceStack.Count; i++) 
            {
                result.Push(preResultList[i]);
            }

            
            return result;
        }

        internal static Dictionary<int, EValueType> FillDictionaryFromSource(int[] sourceArr)
        {
            Dictionary<int, EValueType> result = null;
            result = new Dictionary<int, EValueType>();

            for (int i = 0; i < sourceArr.Length; i++)
            {
                if (sourceArr[i] % 2 == 0)
                {
                    result[sourceArr[i]] = EValueType.Two;
                }
                else if (sourceArr[i] % 3 == 0)
                {
                    result[sourceArr[i]] = EValueType.Three;
                }
                else if (sourceArr[i] % 5 == 0)
                {
                    result[sourceArr[i]] = EValueType.Five;
                }
                else if (sourceArr[i] % 7 == 0)
                {
                    result[sourceArr[i]] = EValueType.Seven;
                }
                else
                {
                    for (int j = 2; j < sourceArr[i]; j++)
                    {
                        if ((sourceArr[i] % i) == 0)
                        {
                          
                        }
                        else
                        {
                            result[sourceArr[i]] = EValueType.Prime;
                        }
                    }
                }
            }


            return result;
        }

        internal static int CountDictionaryRegistriesWithValueType(Dictionary<int, EValueType> sourceDict, EValueType type)
        {

            int contador = 0;

            if (type == EValueType.Two)
            {
                
                for (int i = 0; i < sourceDict.Count; i++)
                {
                    if (sourceDict[i] == EValueType.Two)
                    {
                        contador++;
                    }
                }
            }
            else if (type == EValueType.Three)
            {
                
                for (int i = 0; i < sourceDict.Count; i++)
                {
                    if (sourceDict[i] == EValueType.Three)
                    {
                        contador++;
                    }
                }
            }
            else if (type == EValueType.Five)
            {
                
                for (int i = 0; i < sourceDict.Count; i++)
                {
                    if (sourceDict[i] == EValueType.Five)
                    {
                        contador++;
                    }
                }
            }
            else if (type == EValueType.Seven)
            {
                
                for (int i = 0; i < sourceDict.Count; i++)
                {
                    if (sourceDict[i] == EValueType.Seven)
                    {
                        contador++;
                    }
                }
            }
            else if (type == EValueType.Prime)
            {
                
                for (int i = 0; i < sourceDict.Count; i++)
                {
                    if (sourceDict[i] == EValueType.Prime)
                    {
                        contador++;
                    }
                }
            }




            return contador;
        }

        internal static Dictionary<int, EValueType> SortDictionaryRegistries(Dictionary<int, EValueType> sourceDict)
        {
            Dictionary<int, EValueType> result = null;
            /*
            int[] organizar;

            for (int i = 0; i < sourceDict.Count; i++)
            {
                for (int j = 0; j < sourceDict.Count - 1; j++)
                {

                }
            }
            */

            return result;
        }

        internal static Queue<Ticket>[] ClassifyTickets(List<Ticket> sourceList)
        {
            Queue<Ticket>[] result = null;

            result = new Queue<Ticket>[3];



            Queue<Ticket> payments = new Queue<Ticket>();
            Queue<Ticket> subscriptions = new Queue<Ticket>();
            Queue<Ticket> cancelations = new Queue<Ticket>();


           

            for (int i = 0; i < sourceList.Count; i++)
            {
                Ticket ticket = sourceList[i];
                if (ticket.RequestType == Ticket.ERequestType.Payment)
                {
                    payments.Enqueue(ticket);
                }
                else if (ticket.RequestType == Ticket.ERequestType.Subscription)
                {
                    subscriptions.Enqueue(ticket);
                }
                else if (ticket.RequestType == Ticket.ERequestType.Cancellation)
                {
                    cancelations.Enqueue(ticket);
                }
            }

            result[0] = payments;
            result[1] = subscriptions;
            result[2] = cancelations;



            return result;
        }

        internal static bool AddNewTicket(Queue<Ticket> targetQueue, Ticket ticket)
        {
            bool result = false;

            if (ticket.RequestType != Ticket.ERequestType.Payment || ticket.RequestType != Ticket.ERequestType.Subscription || ticket.RequestType != Ticket.ERequestType.Cancellation)
            {
                result = false;
            }
            else
            {
                result = true;
            }

            
            
            
            



            return result;
        }        
    }
}