﻿using Microsoft.EntityFrameworkCore;
using MotWDeckAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotWDeckAPI.Data
{
    public class ContextMotWDeck : DbContext, IContextMotWDeck
    {
        public ContextMotWDeck(DbContextOptions options) : base(options) { }
        public DbSet<Playbook> Playbooks { get; set; }
        public DbSet<Improvement> Improvements { get; set; }
        public DbSet<GearItem> Gear { get; set; }
        public DbSet<Move> Moves { get; set; }
    }
}
