﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IChildCommand
    {
        void DoInquire();

        void DoSave();

        void DoDelete();

        void Add();
    }
}
