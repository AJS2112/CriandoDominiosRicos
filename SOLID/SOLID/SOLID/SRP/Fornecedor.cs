﻿using SOLID.SRP.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.SRP
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void ChangeName(string name)
        {
            this.Name = name;
            NotificationService.Notify("rh@minhaempresa.com");
        }

    }
}
