﻿using Entities;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IMy_FoodService
    {
        List<My_Food> GetAllMy_Foods();
        My_Food GetMy_FoodById(int id);
        My_Food CreateMy_Food(My_Food My_Food);
        My_Food UpdateMy_Food(My_Food My_Food);
        void DeleteMy_Food(int id);
    }
}