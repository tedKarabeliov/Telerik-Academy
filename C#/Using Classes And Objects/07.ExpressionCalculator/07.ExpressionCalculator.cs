using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class TheHardOne
{
    static void Main()
    {
        Console.WriteLine("Enter expression:");
        string input = Console.ReadLine();
        input = input.Replace(" ", string.Empty);

        double tryparse = 0;
        List<string> list = new List<string>();
        string str = null;
        for (int i = 0; i < input.Length; i++)
        {
            str = null;
            if (double.TryParse(input[i].ToString(), out tryparse))
            {
                while (i < input.Length && double.TryParse(input[i].ToString(), out tryparse))
                {
                    str += input[i];
                    i++;
                }
                i--;
                list.Add(str);
            }
            else if (input[i] == '+')
            {
                list.Add(input[i].ToString());
            }
            else if (input[i] == '-')
            {
                if (i == 0 || input[i - 1] == ',' || input[i - 1] == '(')
                {
                    list.Add(input[i].ToString() + input[i + 1].ToString());
                    i++;
                }
                else
                {
                    list.Add(input[i].ToString());
                }
            }
            else if (input[i] == '*' || input[i] == '/')
            {
                list.Add(input[i].ToString());
            }
            else if (input[i] == '(' || input[i] == ')')
            {
                list.Add(input[i].ToString());
            }
            else if (input[i] == ',')
            {
                list.Add(input[i].ToString());
            }
            else if (input[i] == 'p')
            {
                if (input[i + 1] == 'o' && input[i + 2] == 'w')
                {
                    list.Add(input[i].ToString() + input[i + 1].ToString() + input[i + 2].ToString());
                }
                else
                {
                    throw new ArgumentException();
                }
                i += 2;
            }
            else if (input[i] == 's')
            {
                if (input[i + 1] == 'q' && input[i + 2] == 'r' && input[i + 3] == 't')
                {
                    list.Add(input[i].ToString() + input[i + 1].ToString() + input[i + 2].ToString() + input[i + 3].ToString());
                }
                else
                {
                    throw new ArgumentException();
                }
                i += 3;
            }
            else if (input[i] == 'l')
            {
                if (input[i + 1] == 'n')
                {
                    list.Add(input[i].ToString() + input[i + 1].ToString());
                }
                else
                {
                    throw new ArgumentException();
                }
                i++;
            }
        }

        
        Stack<string> stack = new Stack<string>();
        Queue<string> queue = new Queue<string>();
        string[] arr = list.ToArray();

        for (int i = 0; i < arr.Length; i++)
        {
            if (double.TryParse(arr[i], out tryparse))
            {
                queue.Enqueue(arr[i]);
            }
            else if (arr[i] == "ln" || arr[i] == "sqrt" || arr[i] == "pow")
            {
                stack.Push(arr[i]);
            }
            else if (arr[i] == ",")
            {
                while (stack.Peek() != "(")
                {
                    if (stack.Count == 1)
                    {
                        throw new InvalidOperationException();
                    }
                    queue.Enqueue(stack.Pop());
                }

            }
            else if (arr[i] == "(")
            {
                stack.Push(arr[i]);
            }
            else if (arr[i] == "+" || arr[i] == "-"
                || arr[i] == "*" || arr[i] == "/")
            {
                if (arr[i] == "*" || arr[i] == "/")
                {
                    while (stack.Count != 0 && (stack.Peek() == "*" || stack.Peek() == "/" || stack.Peek() == "pow" || stack.Peek() == "sqrt" || stack.Peek() == "ln"))
                    {
                        queue.Enqueue(stack.Pop());
                    }
                    stack.Push(arr[i]);

                }
                else if (arr[i] == "+" || arr[i] == "-")
                {
                    while (stack.Count != 0 && (stack.Peek() == "+" || stack.Peek() == "-" || stack.Peek() == "*" || stack.Peek() == "/" || stack.Peek() == "pow" || stack.Peek() == "sqrt" || stack.Peek() == "ln"))
                    {
                        queue.Enqueue(stack.Pop());
                    }
                    stack.Push(arr[i]);
                }
            }
            else if (arr[i] == ")")
            {
                while (stack.Peek() != "(")
                {
                    if (stack.Count == 1)
                    {
                        throw new InvalidOperationException();
                    }
                    queue.Enqueue(stack.Pop());
                }
                stack.Pop();
            }
        }

        while (stack.Count != 0)
        {
            if (stack.Peek() == "(" || stack.Peek() == ")")
            {
                throw new InvalidOperationException();
            }
            queue.Enqueue(stack.Pop());
        }

        Stack<string> result = new Stack<string>();
        double num1 = 0;
        double num2 = 0;
        while (queue.Count != 0)
        {
            if (double.TryParse(queue.Peek(), out tryparse))
            {
                result.Push(queue.Dequeue());
            }
            else if (queue.Peek() == "pow")
            {
                num1 = double.Parse(result.Pop());
                num2 = double.Parse(result.Pop());
                result.Push((Math.Pow(num2, num1)).ToString());
                queue.Dequeue();
            }
            else if (queue.Peek() == "sqrt")
            {
                num1 = double.Parse(result.Pop());
                result.Push(Math.Sqrt(num1).ToString());
                queue.Dequeue();
            }
            else if (queue.Peek() == "ln")
            {
                num1 = double.Parse(result.Pop());
                result.Push(Math.Log10(num1).ToString());
                queue.Dequeue();
            }
            else if (queue.Peek() == "+" || queue.Peek() == "-" || queue.Peek() == "*" || queue.Peek() == "/")
            {
                if (queue.Peek() == "+")
                {
                    num1 = double.Parse(result.Pop());
                    num2 = double.Parse(result.Pop());
                    result.Push((num2 + num1).ToString());
                    queue.Dequeue();
                }
                else if (queue.Peek() == "-")
                {
                    num1 = double.Parse(result.Pop());
                    num2 = double.Parse(result.Pop());
                    result.Push((num2 - num1).ToString());
                    queue.Dequeue();
                }
                else if (queue.Peek() == "*")
                {
                    num1 = double.Parse(result.Pop());
                    num2 = double.Parse(result.Pop());
                    result.Push((num2 * num1).ToString());
                    queue.Dequeue();
                }
                else if (queue.Peek() == "/")
                {
                    num1 = double.Parse(result.Pop());
                    num2 = double.Parse(result.Pop());
                    result.Push((num2 / num1).ToString());
                    queue.Dequeue();
                }
            }
        }
        Console.WriteLine(result.Pop());
      }
}

