using System;
using System.Collections.Generic;
using System.Text;

namespace Crud_Collection
{
    public abstract class Karyawan
    {
        public string NIK;
        public string Nama;
        public abstract double Gaji();
    }
}