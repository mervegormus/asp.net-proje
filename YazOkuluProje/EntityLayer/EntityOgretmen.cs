using System;
using System.Collections.Generic;
using System.Text;

namespace EntityLayer
{
    class EntityOgretmen
    {
        private int ogrtid;
        private int ogrtbrans;
        private string ogrtad;

        public int Ogrtid { get => ogrtid; set => ogrtid = value; }
        public int Ogrtbrans { get => ogrtbrans; set => ogrtbrans = value; }
        public string Ogrtad { get => ogrtad; set => ogrtad = value; }
    }
}
