using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class Stack<t>
    {
        #region Full Xử lí stack
        public Node CreateNode(double x)
        {
            Node p = new Node();
            if (p == null)
            {
                Console.WriteLine("Không đủ bộ nhớ");
                return null;
            }
            p.Data = x;
            p.Next = null;
            return p;

        }
        public void InitStack(ref S stack)
        {
            stack.Top = null;
        }
        public bool IsEmptyStack(S stack)
        {
            if (stack.Top == null)
                return true;//danh sach rỗng
            return false;//danh sách không rỗng 
        }
        public void Push(ref S stack, Node p)
        {
            if (IsEmptyStack(stack))
            {
                stack.Top = p;
            }
            else
            {
                p.Next = stack.Top;
                stack.Top = p;
            }
        }
        public void Top(S stack)
        {
            if (IsEmptyStack(stack))
            {
                Console.WriteLine("Stack Rỗng");
            }
            else
            {
                Console.WriteLine("Phần tử đầu Stack:" + (stack.Top.Data));
            }
        }
        public double Pop(ref S stack)
        {
            Node p = stack.Top; // tạo ra 1 cái node p gán là node đầu
            double t = stack.Top.Data;// lấy t gán = data của node đầu
            stack.Top = stack.Top.Next;//gán con tro đầu cho phần tử tiếp theo
            GC.Collect();// giải phóng vùng nhớ
            return t;

        }
        public void Printf(S stack)
        {
            Node p = stack.Top;
            while (p != null)
            {
                Console.Write(" " + (p.Data));
                p = p.Next;
            }
        }
        public void RemoveStack(S stack)
        {
            for (Node p = stack.Top; p != null; p = p.Next)
            {
                stack.Top = stack.Top.Next;
                GC.Collect();
            }
        }
        #endregion
        #region Chuyển Đổi cơ số 
        public void Conversion(ref S stack, int number, int Dec)
        {
            while (Dec != 0)
            {
                int x = Dec % number;
                Node p = new Node();//thêm x vào node p
                p = CreateNode(x);
                Push(ref stack, p);//them node p vao đầu stack
                Dec = Dec / number;
            }
        }
        public void PrintfStack(S stack)
        {
            Node p = stack.Top;
            while (p != null)
            {
                Pop(ref stack);
                switch (p.Data)
                {
                    case 10:
                        Console.Write("A");
                        break;
                    case 11:
                        Console.Write("B");
                        break;
                    case 12:
                        Console.Write("C");
                        break;
                    case 13:
                        Console.Write("D");
                        break;
                    case 14:
                        Console.Write("E");
                        break;
                    case 15:
                        Console.Write("F");
                        break;
                    default:
                        Console.Write(p.Data);
                        break;
                }
                p = p.Next;
            }
        }
        #endregion
        #region Tính Giai Thừa
        public double Factorial(double n)
        {
            S stack = new S();
            if (n < 0)
            {
                return -1;
            }
            InitStack(ref stack);
            while (n != 0)
            {
                Node p = CreateNode(n);
                Push(ref stack, p);
                n = n - 1;
            }
            double kq = 1;
            while (!IsEmptyStack(stack))// Lăp cho tới khi nào rỗng thì dừng 
            {
                double temp = Pop(ref stack);
                kq = kq * temp;

            }
            return kq;
        }
        #endregion
        #region Tính Tổng dãy số S(n) = 1+1/1!+1/2!+...+1/𝑛!
        public double SumFac(double n)
        {
            S stack = new S();

            InitStack(ref stack);
            while (n != 0)
            {
                Node p = CreateNode(n);
                Push(ref stack, p);
                n = n - 1;
            }
            double kq = 1;
            double sum = 0;
            while (!IsEmptyStack(stack))// Lăp cho tới khi nào rỗng thì dừng 
            {
                double temp = Pop(ref stack);
                kq = (kq * temp);
                sum = sum + 1/kq;
            }
            return sum+1;
        }
        #endregion
        #region Tính Tổng Dãy Số <S(n)=1 + (1+2) + (1+2+3) +...+ (1+2+3+...+n)>
        public double SumofNumber(double n)
        {
            S stack = new S();
            if (n < 0)
            {
                return -1;
            }
            InitStack(ref stack);
            while (n != 0)
            {
                Node p = CreateNode(n);
                Push(ref stack, p);
                n = n - 1;
            }
            double  sum = 0;
            double temp1 = 0;
            while (!IsEmptyStack(stack))
            {
                double temp = Pop(ref stack);
                sum = sum + temp;
                temp1 += sum;
            }
            return temp1;
        }
        #endregion 
        #region Tính tổng dãy số S(n)=1 +(1x2) + (1x2x3) +... +(1x2x3x...xn)
        public double Sum(double n)
        {
            S stack = new S();
            if (n < 0)
            {
                return -1;
            }
            InitStack(ref stack);
            while (n != 0)
            {
                Node p = CreateNode(n);
                Push(ref stack, p);
                n = n - 1;
            }
            double sum = 1;
            double temp1 = 0;
            while (!IsEmptyStack(stack))
            {
                double temp = Pop(ref stack);
                sum = sum * temp;
                temp1 += sum;
            }
            return temp1;
        }
        #endregion
        #region Tính Fibonacci
        public double Fibonacci(double n)
        {
            S stack = new S();
            InitStack(ref stack);
            Node p = CreateNode(n);
            Push(ref stack, p);
            double kq = 0;
            while (!IsEmptyStack(stack))
            {
                double t = Pop(ref stack);
                if (t == 1 || t == 2)
                {
                    kq = kq + 1;
                }
                else
                {
                    Push(ref stack, CreateNode(t - 1));
                    Push(ref stack, CreateNode(t - 2));
                }
            }
            return kq;
        }
        #endregion

    }
}
