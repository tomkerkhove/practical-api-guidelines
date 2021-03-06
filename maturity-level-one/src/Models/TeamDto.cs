﻿using Codit.LevelOne.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codit.LevelOne.Models
{
    public class TeamDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Ranking{ get; set; }

        public ContinentCode Continent { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
