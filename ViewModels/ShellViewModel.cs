﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Household_Management_System.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        public ShellViewModel()
        {
            OpenWindow();   
        }
        private void OpenWindow()
        {
            ActivateItemAsync(new DashboardViewModel());
        }
    }
}
