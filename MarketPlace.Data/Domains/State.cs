﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Data.Domains
{
    public class State:BaseObject
    {
        public State()
        {
            States = new HashSet<State>();
        }
        public long CountryId { get; set; }
        public string Name { get; set; }
        public string StateCode { get; set; }
        public virtual ICollection<State> States { get; set;}
    }
}
