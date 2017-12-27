﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LolApp.Data;

namespace LolApp.Interfaces
{
    /// <summary>
    /// Represents an instance of the Riot Games API
    /// </summary>
    public interface IRiotApi
    {
        Summoner GetSummonerByName(string region, string name);
    }
}
