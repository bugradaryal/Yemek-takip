﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class My_Food
    {
        public int id { get; set; }
        public int Fridges_id { get; set; }
        public int Foods_id { get; set; }
        public string Jobs_id { get; set; }

        public DateTime eklenme_tarihi { get; set; }

        public DateTime bozulma_tarihi { get; set; }

        //ref
        public Fridge Fridge { get; set; }
        public Food Food { get; set; }
}
}
