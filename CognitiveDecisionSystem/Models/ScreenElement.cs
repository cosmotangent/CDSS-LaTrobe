﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CognitiveDecisionSystem.Models
{
    public abstract class ScreenElement
    {
        [Key]
        public int WidgetID { get; set; }
        public String WidgetName { get; set; }
        public String HTMLId { get; set; }
        public int TopX { get; set; }
        public int TopY { get; set; }
        public int WWidth { get; set; }
        public int WHeight { get; set; }
    }
}