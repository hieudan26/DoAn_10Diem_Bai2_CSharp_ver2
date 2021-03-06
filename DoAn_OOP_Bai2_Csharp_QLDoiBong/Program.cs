﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_Bai2_Csharp_QLDoiBong
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 1;
            DoiBong a = new DoiBong();
            a.Nhap();
            San san = new San();
            int co = 1, co2 = 1, co3 = 0, co4 = 0;
            while (flag == 1)
            {
                Console.WriteLine("\t\t\t************************MENU************************\t\t\t");
                Console.WriteLine("\t\t\t***            1. Quan Ly Cau Thu                ***\t\t\t");
                Console.WriteLine("\t\t\t***            2. Xuat ds Cau Thu hien co        ***\t\t\t");
                Console.WriteLine("\t\t\t***            3. Quan Ly Nhan Vien              ***\t\t\t");
                Console.WriteLine("\t\t\t***            4. Xuat ds Nhan Vien hien co      ***\t\t\t");
                Console.WriteLine("\t\t\t***            5. Quan Ly San                    ***\t\t\t");
                Console.WriteLine("\t\t\t***            6. Hoat Dong                      ***\t\t\t");
                Console.WriteLine("\t\t\t***            7. Thoat                          ***\t\t\t");
                Console.WriteLine("\t\t\t****************************************************\t\t\t");
                Console.Write("Moi nhap lua chon cua ba => Your choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            a.MenuQLCT();
                            co3 = 1;
                            break;
                        }
                    case 2:
                        {
                            int i = 0;
                            if (a.listCauThu.LDsCauThu.Count != 0)
                            {
                                foreach (var item in a.listCauThu.LDsCauThu)
                                {
                                    Console.WriteLine("STT: " + i++ + " Ho ten: " + item.sHoTen + " Chuc vu: " + item.sNghe);
                                }
                            }
                            else
                            {
                                Console.WriteLine("chua nhap thong tin cau thu nao !!");
                            }
                            break;
                        }
                    case 3:
                        {
                            a.MenuQLNV();
                            co4 = 1;
                            break;
                        }
                    case 4:
                        {
                            int i = 0;
                            if (a.listNhanVien.LcaNhans.Count !=0)
                            {
                                foreach (var item in a.listNhanVien.LcaNhans)
                                {
                                    Console.WriteLine("STT: " + i++ + " Ho ten: " + item.sHoTen + " Chuc vu: " + item.sNghe);
                                }
                            }
                            else
                            {
                                Console.WriteLine("chua nhap thong tin nhan vien nao !!");
                            }
                            break;
                        }
                    case 5:
                        {
                            if (co == 1)
                            {
                                Console.Write("Doi Bong co san co khong? 1_Co || 2_Khong : ");
                                int temp = int.Parse(Console.ReadLine());
                                if (temp == 1)
                                {
                                    san.Nhap();
                                    Console.WriteLine("//////////////////////////////////////////////////////////////////////");
                                    san.Xuat();
                                }
                                else
                                {
                                    co2 = 0;
                                    san = null;
                                    Console.WriteLine("Doi bong khong co San!! ");
                                }
                                co = 0;
                            }
                            else
                            {
                                if (co2 == 1)
                                    san.Xuat();
                                else 
                                    Console.WriteLine("Doi bong khong co San!! ");
                            }
                            co3 = 1;
                            break;
                        }
                    case 6:
                        {
                            if (co3 == 0)
                            {
                                Console.WriteLine("Warning: chuc nang nay co su dung du lieu cua San de nghi nhap thong tin cua San truoc!!");
                            }
                            else
                                a.MenuHoatDong(san);
                            break; 
                        }
                    case 7:
                        {
                            flag = 0;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Nhap sai, moi nhap lai!!  ");
                            break;
                        }
                }
            }
        }
    }
}
