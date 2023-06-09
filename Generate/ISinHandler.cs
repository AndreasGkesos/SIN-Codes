﻿using DB.Models;

namespace SinHandler
{
    public interface ISinHandler
    {
        (string, string) Generate(string planNumber);
        List<Sin> GetAll();
        void RemovePerPlan(string planNumber);
    }
}
