﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KemerburgazPetShop.Business.Abstract
{
    public interface ICartService
    {
        void InitializeCart(string UserID);
    }
}
