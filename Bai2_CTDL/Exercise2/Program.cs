using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Exercise2
{
    #region Menu của Stack
    internal class Program
    {
        static void Main(string[] args)
        {
        jump:
            Stack<Node> stack = new Stack<Node>();
            S S1=new S();
            stack.InitStack(ref S1);
            int a;
            int m;
            int k;
            while (true)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine();
                Console.WriteLine("\n\t==========================<CHÀO MỪNG ĐẾN VỚI ỨNG DỤNG CỦA TÔI>================================");
                Console.WriteLine("\n\n\t\t============================== <STACK> ===========================\t\n");
                Console.WriteLine("\n\t\t1.LÀM VIỆC VỚI STACK: ");
                Console.WriteLine("\n\t\t2.MỘT SỐ ỨNG DỤNG CỦA STACK: ");
                Console.WriteLine("\n\t\t3.THOÁT ỨNG DỤNG: ");
                Console.WriteLine();
                Console.WriteLine("\n\t\t================================ <END> =============================\n");
                Console.Write("\n\t\tXIN VUI LÒNG NHẬP LỰA CHỌN !: ");
                m = int.Parse(Console.ReadLine());
                if (m < 1 || m > 3)
                {
                    Console.WriteLine("BẠN ĐÃ NHẬP SAI VUI LÒNG NHẬP LẠI !: ");
                }
                else if (m == 3)
                {
                jump1:
                    Console.WriteLine("\n\t ==========================<BẠN CÓ CHẮC CHẮN THOÁT ỨNG DỤNG KHÔNG ?>==================================\n");
                    Console.WriteLine("\t1.THOÁT");
                    Console.WriteLine("\t2.QUAY LẠI \n");
                    Console.WriteLine("\t========================================= <END> ==========================================================\n");
                    Console.Write("\tXIN VUI LÒNG NHẬP LỰA CHỌN !: ");
                    int o = int.Parse(Console.ReadLine());
                    if (o == 1)
                    {
                        Console.WriteLine("\n\t ==================< CÁM ƠN BẠN ĐÃ SỬ DỤNG ỨNG DỤNG CỦA TÔI XIN CHÀO VÀ HẸN GẶP LẠI !>=====================");
                        Console.ReadLine();
                        break;
                    }
                    else if (o == 2)
                    {
                        goto jump;
                    }
                    else
                    {
                        Console.WriteLine("Ban đã nhập sai xin vui lòng nhập lại");
                        goto jump1;
                    }
                }

                switch (m)
                {
                    case 1:
                        while (true)
                        {
                            Console.WriteLine("\n\n\t\t================================== <MENU STACK> =================================");
                            Console.WriteLine("\n\t\t1.THÊM PHẦN TỬ VÀO STACK-PUSH:");
                            Console.WriteLine("\n\t\t2.XEM THÔNG TIN PHẦN TỬ ĐẦU STACK-TOP:");
                            Console.WriteLine("\n\t\t3.HỦY PHẦN TỬ ĐẦU STACK-POP:");
                            Console.WriteLine("\n\t\t4.XUẤT -STACK:");
                            Console.WriteLine("\n\t\t5.XÓA STACK-CLEAR:");
                            Console.WriteLine("\n\t\t6.THOÁT ỨNG DỤNG :");
                            Console.WriteLine("\n\t\t====================================== <END> =====================================\n");
                            Console.Write("\n\t\tXIN VUI LÒNG NHẬP LỰA CHỌN !: ");
                            a = int.Parse(Console.ReadLine());
                            if (a < 0)
                            {
                                Console.WriteLine("Bạn đã nhập sai vui lòng nhập lại:");
                            }
                            else if (a == 1)
                            {
                               double  x;
                                Console.Write("Nhập giá trị số nguyên: ");
                                x = int.Parse(Console.ReadLine());
                                Node p = new Node();
                                p = stack.CreateNode(x);
                                stack.Push(ref S1, p);

                            }
                            else if (a == 2)
                            {
                                stack.Top(S1);
                            }
                            else if (a == 3)
                            {
                                if (stack.IsEmptyStack(S1))
                                {
                                    Console.WriteLine("Stack Rỗng");
                                }
                                else
                                {
                                    Console.Write("Stack sau khi hủy phần tử đầu là:");
                                    stack.Pop(ref S1);
                                    stack.Printf(S1);
                                }
                            }
                            else if (a == 4)
                            {
                                Console.Write("STACK: ");
                                stack.Printf(S1);
                            }
                            else if (a == 5)
                            {
                                Console.WriteLine("STACK RỖNG ! ");
                                stack.RemoveStack(S1);
                            }
                            else if (a == 6)
                            {
                                break;
                            }
                        }
                        break;
                    case 2:
                        while (true)
                        {
                            Console.WriteLine("\n\n\t\t=========================== <MENU> =============================\n");
                            Console.WriteLine("\n\t\t1.ỨNG DỤNG CHUYỂN ĐỔI CƠ SỐ 10 SANG 2,8,16 || Decimal:- Binary -  Octal - Hexadecimal:");
                            Console.WriteLine("\n\t\t2.ỨNG DỤNG TÍNH GIAI THỪA:");
                            Console.WriteLine("\n\t\t3.ỨNG DỤNG TÍNH TỔNG DÃY SỐ   <S(n)=1 + (1+2) + (1+2+3) +...+ (1+2+3+...+n)>: ");
                            Console.WriteLine("\n\t\t4.ỨNG DỤNG TÍNH TỔNG DÃY SỐ   <S(n)=1 +(1x2) + (1x2x3) +... + (1x2x3x...xn)>: ");
                            Console.WriteLine("\n\t\t5.ỨNG DỤNG TÍNH TỔNG DÃY SỐ   <S(n) = 1 +1/1! +1/2! +...+ 1/n!)>: ");
                            Console.WriteLine("\n\t\t6.ỨNG DỤNG TÍNH FIBONACCI:");
                            Console.WriteLine("\n\t\t7.THOÁT ");
                            Console.WriteLine("\n\t\t============================ <END> ===========================\n");
                            Console.Write("\n\t\tNHẬP LỰA CHỌN CỦA BẠN !: ");
                            k = int.Parse(Console.ReadLine());
                            if (k < 1 || k > 7)
                            {
                                Console.Write("Bạn đã nhập sai vui lòng nhập lại: ");
                            }
                            else if (k == 1)
                            {
                                Console.Write("Nhập số cần chuyển(decimal) : ");
                                int Dec = int.Parse(Console.ReadLine());
                                Console.Write("Nhập hệ cần chuyển: ");
                                int o = int.Parse(Console.ReadLine());
                                stack.Conversion(ref S1, o, Dec);
                                Console.Write("Kết quả sau khi chuyển là: ");
                                stack.PrintfStack(S1);
                            }
                            else if (k == 2)
                            {
                                int n;
                                Console.Write("Nhập N! cần tính: ");
                                n = int.Parse(Console.ReadLine());
                                if (n < 1)
                                {
                                    Console.WriteLine("Bạn đã nhập sai vui lòng nhập lại:");
                                }
                                else
                                {
                                    Console.Write("Kết quả sau khi tính được là:" + stack.Factorial(n));

                                }
                            }
                            else if (k == 3)
                            {
                                double n;
                                Console.Write("Nhập N: ");
                                n = Convert.ToDouble(Console.ReadLine());
                                if (n < 1)
                                {
                                    Console.WriteLine("Bạn đã nhập sai vui lòng nhập lại:");
                                }
                                else
                                {
                                    Console.Write("Kết quả tính được là: " + stack.SumofNumber(n));
                                }
                            }
                            else if (k == 4)
                            {
                                double n;
                                Console.Write("Nhập N: ");
                                n = Convert.ToDouble(Console.ReadLine());
                                if (n < 1)
                                {
                                    Console.WriteLine("Bạn đã nhập sai vui lòng nhập lại:");
                                }
                                else
                                {
                                    Console.Write("Kết quả tính được là: " + stack.Sum(n));
                                }
                            }
                            else if(k==5)
                            {
                                double n;
                                Console.Write("Nhập N: ");
                                n = Convert.ToDouble(Console.ReadLine());
                                if (n < 1)
                                {
                                    Console.WriteLine("Bạn đã nhập sai vui lòng nhập lại:");
                                }
                                else
                                {
                                    Console.Write("Kết quả tính được là: " + stack.SumFac(n));
                                }
                            }
                            else if (k == 6)
                            {
                                double n;
                                Console.Write("Nhập N: ");
                                n = Convert.ToDouble(Console.ReadLine());
                                if (n < 1)
                                {
                                    Console.WriteLine("Bạn đã nhập sai vui lòng nhập lại:");
                                }
                                else
                                {
                                    Console.Write("Kết quả tính được là: " + stack.Fibonacci(n));
                                }
                            }
                            else if(k == 7) 
                            {
                                break;
                            }
                        }
                        break;
                }
            }
        }
    }
    #endregion
}
