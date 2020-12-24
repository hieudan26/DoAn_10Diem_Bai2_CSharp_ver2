﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_OOP_Bai2_Csharp_QLDoiBong
{
     class QuanLyNhanVien
    {
        private List<CaNhan> lcaNhans;
        private List<BacSi> lbacsi;
        private List<HLVChienThuat> lHLVCT;
        private List<HLVTheLuc> lHLVTL;
        private List<NVBaoVe> lNVBV;
        private List<NVVeSinh> lNVVS;
        public List<CaNhan> LcaNhans { get => this.lcaNhans; set => this.lcaNhans = value; }
        public List<NVBaoVe> LNVBV { get => lNVBV; set => lNVBV = value; }
        public List<NVVeSinh> LNVVS { get => lNVVS; set => lNVVS = value; }
        public List<HLVTheLuc> LHLVTL { get => lHLVTL; set => lHLVTL = value; }
        public List<HLVChienThuat> LHLVCT { get => lHLVCT; set => lHLVCT = value; }
        public List<BacSi> Lbacsi { get => lbacsi; set => lbacsi = value; }

        public QuanLyNhanVien()
        {
            this.lbacsi = new List<BacSi>();
            this.lcaNhans = new List<CaNhan>();
            this.lHLVCT = new List<HLVChienThuat>();
            this.lHLVTL = new List<HLVTheLuc>();
            this.lNVBV = new List<NVBaoVe>();
            this.lNVVS = new List<NVVeSinh>();
        }

        public QuanLyNhanVien(List<CaNhan> lcaNhans, List<BacSi> lbacsi, List<HLVChienThuat> lHLVCT, List<HLVTheLuc> lHLVTL, List<NVBaoVe> lNVBV, List<NVVeSinh> lNVVS)
        {
            this.lcaNhans = lcaNhans;
            this.lbacsi = lbacsi;
            this.lHLVCT = lHLVCT;
            this.lHLVTL = lHLVTL;
            this.lNVBV = lNVBV;
            this.lNVVS = lNVVS;
        }

        public double TinhLuongToanBoNV()
        {
            double temp = 0;
            foreach (var item in Lbacsi)
                temp = item + temp;
            foreach (var item in LHLVCT)
                temp = item + temp;
            foreach (var item in LHLVTL)
                temp = item + temp;
            foreach (var item in this.lNVBV)
            {
                temp = item + temp;
            }
            foreach (var item in this.lNVVS)
            {
                temp = item + temp;
            }
            return temp;
        }

        public void Nhap()
        {
            Console.Write("Moi nhap so luong Bac Si: ");
            int bs = int.Parse(Console.ReadLine());
            for (int i = 0; i < bs; i++)
            {
                BacSi a = new BacSi();
                a.Nhap();
                this.Lbacsi.Add(a);
                this.lcaNhans.Add(a);
            }

            Console.Write("Moi nhap so luong HLV Chien Thuat: ");
            int hlvct = int.Parse(Console.ReadLine());
            for (int i = 0; i < hlvct; i++)
            {
                HLVChienThuat a = new HLVChienThuat();
                a.Nhap();
                this.LHLVCT.Add(a);
                this.lcaNhans.Add(a);
            }

            Console.Write("Moi nhap so luong HLV The Luc: ");
            int hlvtl = int.Parse(Console.ReadLine());
            for (int i = 0; i < hlvtl; i++)
            {
                HLVTheLuc a = new HLVTheLuc();
                a.Nhap();
                this.LcaNhans.Add(a);
                this.LHLVTL.Add(a);
            }

            Console.Write("Moi nhap so luong Nhan Vien Bao Ve: ");
            int nvbv = int.Parse(Console.ReadLine());
            for (int i = 0; i < nvbv; i++)
            {
                NVBaoVe a = new NVBaoVe();
                a.Nhap();
                this.lNVBV.Add(a);
                this.lcaNhans.Add(a);
            }

            Console.Write("Moi nhap so luong Nhan Vien Ve Sinh: ");
            int nvvs = int.Parse(Console.ReadLine());
            for (int i = 0; i < nvvs; i++)
            {
                NVVeSinh a = new NVVeSinh();
                a.Nhap();
                this.lNVVS.Add(a);
                this.lcaNhans.Add(a);
            }
        }

        public void SapxepTheoLuong()
        {
            this.lcaNhans.Sort((x, y) => x.dLuongCoBan.CompareTo(y.dLuongCoBan));
        }

        public void XuatDsBacSi()
        {
            if (Lbacsi.Count == 0)
                Console.WriteLine("Khong co Bac Si nao!");
            else
                foreach (var item in Lbacsi)
                    Console.WriteLine("Ten: " + item.sHoTen + " Chuc vu: " + item.sNghe);
        }

        public void XuatDsHLVTL()
        {
            if (LHLVTL.Count == 0)
                Console.WriteLine("Khong co HLV the luc nao!");
            else
                foreach (var item in LHLVTL)
                    Console.WriteLine("Ten: " + item.sHoTen + " Chuc vu: " + item.sNghe);
        }

        public void XuatDsHLVCT()
        {
            if (LHLVCT.Count == 0)
                Console.WriteLine("Khong co HLV chien thuat nao!");
            else
                foreach (var item in LHLVCT)
                    Console.WriteLine("Ten: " + item.sHoTen + " Chuc vu: " + item.sNghe);
        }

        public void XuatDsNVBV()
        {
            if (LHLVTL.Count == 0)
                Console.WriteLine("Khong co nhan vien bao ve nao!");
            else
                foreach (var item in this.lNVBV)
                {
                    Console.WriteLine("Ten: " + item.sHoTen + "Chuc vu: "  + item.sNghe);
                }
        }

        public void XuatDsNVVS()
        {
            if (LHLVTL.Count == 0)
                Console.WriteLine("Khong co nhan vien ve sinh nao!");
            else
                foreach (var item in this.lNVVS)
                {
                    Console.WriteLine("Ten: " + item.sHoTen + " Chuc vu: " + item.sNghe);
                }
        }

        public void XuatDsNhanVien()
        {
            if (LHLVTL.Count == 0)
                Console.WriteLine("Khong co nhan vien nao!");
            else
                foreach (var item in lcaNhans)
                    Console.WriteLine("Ten: " + item.sHoTen + " Chuc vu: " + item.sNghe);
        }

        public CaNhan TimkiemNVtheoTen()
        { 
            Console.Write("Nhap ten Nhan Vien muon tim kiem : ");
            string key = Console.ReadLine();
            CaNhan temp = this.lcaNhans.Find(x => x.sHoTen == key);
            return temp;
        }

        public List<CaNhan> LocTheoLuongLon()
        {
            Console.Write("Nhap Luong (x) de co danh sach cau thu luong > x: ");
            int x = int.Parse(Console.ReadLine());

            List<CaNhan> temp = new List<CaNhan>();
            foreach (var item in lcaNhans)
                if (item.dLuongCoBan > x)
                    temp.Add(item);
            return temp;
        }

        public List<CaNhan> LocTheoLuongBe()
        {
            Console.Write("Nhap Luong (x) de co danh sach cau thu luong < x: ");
            int x = int.Parse(Console.ReadLine());
            
            List<CaNhan> temp = new List<CaNhan>();
            foreach (var item in lcaNhans)
                if(item.dLuongCoBan < x)
                    temp.Add(item);
            return temp;
        }

        public void XemcaNhan()
        {
            this.XuatDsNhanVien();
            Console.Write("Ban Muon Xem Nhan Vien thu may: !");
            int x = int.Parse(Console.ReadLine());
            if(this.lcaNhans[x].sNghe == "bacsi")
            {
                BacSi temp = Lbacsi.Find(a => a.sHoTen == this.lcaNhans[x].sHoTen);
                temp.Xuat();
            }
            else if (this.lcaNhans[x].sNghe == "HLVTL")
            {
                HLVTheLuc temp = LHLVTL.Find(a => a.sHoTen == this.lcaNhans[x].sHoTen);
                temp.Xuat();
            }
            else if(this.lcaNhans[x].sNghe == "HLVCT")
            {
                HLVChienThuat temp = LHLVCT.Find(a => a.sHoTen == this.lcaNhans[x].sHoTen);
                temp.Xuat();
            }
            else if(this.lcaNhans[x].sNghe == "NVBaoVe")
            {
                NVBaoVe temp = lNVBV.Find(a => a.sHoTen == this.LcaNhans[x].sHoTen);
                temp.Xuat();
            }
            else if (this.lcaNhans[x].sNghe == "NVVeSinh")
            {
                NVVeSinh temp = this.lNVVS.Find(a => a.sHoTen == this.LcaNhans[x].sHoTen);
                temp.Xuat();
            }
        }
    }
}
