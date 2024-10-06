using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPPROJE
{
    
        public class Merkez
        {
            public int x;
            public int y;
            public int z;
        }


    public class Dikdortgen : Merkez
    {
        private int en;
        public int En
        {
            get { return en; }
            set { en = value; }
        }

        private int boy;
        public int Boy
        {
            get { return boy; }
            set { boy = value; }
        }


    } 


    public class Cember : Merkez
        {
        private int r;
        public int R
        {
            get { return r; }
            set { r = value; }
        }

      

    }


    public class Kure : Merkez
        {
        private int r;
        public int R
        {
            get { return r; }
            set { r = value; }
        }

    }

    public class Silindir : Merkez
        {
        private int r;
        public int R
        {
            get { return r; }
            set { r = value; }
        }

        private int h;
        public int H
        {
            get { return h; }
            set { h = value; }
        }

    }



    public class DikdortgenP : Merkez
        {
        private int en;
        public int En
        {
            get { return en; }
            set { en = value; }
        }

        private int boy;
        public int Boy
        {
            get { return boy; }
            set { boy = value; }
        }

        private int h;
        public int H
        {
            get { return h; }
            set { h = value; }
        }


    }



    public class Nokta : Merkez
        {

        private int xkoordinat;
        public int xk
        {
            get { return xkoordinat; }
            set { xkoordinat = value; }
        }

        private int ykoordinat;
        public int yk
        {
            get { return ykoordinat; }
            set { ykoordinat = value; }
        }


    }



    }

