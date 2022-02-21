using System.Collections.Generic;
using System;
using System.Linq;

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
                int temp = preResultList[k];
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
                    result.Add((int)sourceArr[i], EValueType.Two);
                }
                else if (sourceArr[i] % 3 == 0)
                {
                    result.Add((int)sourceArr[i], EValueType.Three);
                }
                else if (sourceArr[i] % 5 == 0)
                {
                    result.Add((int)sourceArr[i], EValueType.Five);
                }
                else if (sourceArr[i] % 7 == 0)
                {
                    result.Add((int)sourceArr[i], EValueType.Seven);
                }
                else
                {
                    bool resultado = false;
                    int multiplos = 0;

                    for (int k = 1; k <= sourceArr[i]; k++)
                    {
                        if (sourceArr[i] % k == 0)
                            multiplos++;
                    }

                    if (multiplos == 2)
                     resultado = true;
                     result.Add((int)sourceArr[i], EValueType.Prime);
                        
                            
                    
                    
                }
            }

            return result;
        }

        internal static int CountDictionaryRegistriesWithValueType(Dictionary<int, EValueType> sourceDict, EValueType type)
        {

            int Contador = 0;
            EValueType Value;


            for (int i = 0; i < sourceDict.Count; i++)
            {

                Value = sourceDict.ElementAt(i).Value;


                if (Value == type)
                {

                    Contador++;

                }

            }



            return Contador;
        }

        internal static Dictionary<int, EValueType> SortDictionaryRegistries(Dictionary<int, EValueType> sourceDict)
        {
            Dictionary<int, EValueType> result = null;
            result = new Dictionary<int, EValueType>();


            List<int> keys = new List<int>();
            


            foreach (var key in sourceDict.Keys) 
            {

                keys.Add(key);

            }
            int[] keyArray = keys.ToArray();
            
            Array.Sort(keyArray);
            Array.Reverse(keyArray);


            for (int i = 0; i < keyArray.Length; i++)
            {
                if (keyArray[i] % 2 == 0)
                {
                    result.Add((int)keyArray[i], EValueType.Two);
                }
                else if (keyArray[i] % 3 == 0)
                {
                    result.Add((int)keyArray[i], EValueType.Three);
                }
                else if (keyArray[i] % 5 == 0)
                {
                    result.Add((int)keyArray[i], EValueType.Five);
                }
                else if (keyArray[i] % 7 == 0)
                {
                    result.Add((int)keyArray[i], EValueType.Seven);
                }
                else
                {
                    bool resultado = false;
                    int multiplos = 0;

                    for (int k = 1; k <= keyArray[i]; k++)
                    {
                        if (keyArray[i] % k == 0)
                            multiplos++;
                    }

                    if (multiplos == 2)
                        resultado = true;
                    result.Add((int)keyArray[i], EValueType.Prime);




                }
            }



            return result;             
        }

        internal static Queue<Ticket>[] ClassifyTickets(List<Ticket> sourceList)
        {
            Queue<Ticket>[] result = new Queue<Ticket>[3] { new Queue<Ticket>(), new Queue<Ticket>(), new Queue<Ticket>() };
            sourceList.Sort((a, b) => a.Turn - b.Turn);

            foreach (Ticket ticket in sourceList)
            {

                switch (ticket.RequestType)
                {
                    case Ticket.ERequestType.Payment:
                        result[0].Enqueue(ticket);
                        break;
                    case Ticket.ERequestType.Subscription:
                        result[1].Enqueue(ticket);
                        break;
                    case Ticket.ERequestType.Cancellation:
                        result[2].Enqueue(ticket);
                        break;
                    default:
                        return null;
                }
            }


            return result;
        }

        internal static bool AddNewTicket(Queue<Ticket> targetQueue, Ticket ticket)
        {
            if (ticket.Turn > 99) return false;

            Ticket currTicket = targetQueue.Peek();

            if (currTicket.RequestType == ticket.RequestType)
            {
                targetQueue.Enqueue(ticket);
                return true;
            }

            return false;
        }        
    }
}