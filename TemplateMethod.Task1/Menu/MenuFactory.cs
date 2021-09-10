﻿using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethod.Task1.Cookers;

namespace TemplateMethod.Task1.Menu
{
    public abstract class MenuFactory
    {
        public abstract CookerBase CreateMenu();

    }
}
