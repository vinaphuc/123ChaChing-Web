﻿using System;

namespace NextTech.ChaChing123.Common.Models
{
   public class LeadsOfMonthDTO
    {
        public int Month { get; set; }

        //public string StartDate { get; set; }

        //public string EndDate { get; set; }

        public int LeadsCount { get; set; }


        private LeadsOfMonthDTO()
        {
            Month = -1;
            LeadsCount = 0;
            //StartDate = string.Empty;
            //EndDate = string.Empty;
        }
    }
}
