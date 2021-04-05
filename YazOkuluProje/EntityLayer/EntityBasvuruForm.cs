using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    public class EntityBasvuruForm
    {
        private int basvuruid;
        private int basdersid;
        private int basogrid;

        public int Basvuruid { get => basvuruid; set => basvuruid = value; }
        public int Basdersid { get => basdersid; set => basdersid = value; }
        public int Basogrid { get => basogrid; set => basogrid = value; }
    }
}
