﻿using BaseProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseProject.Models
{
    public class IssueTaskViewModel : IssueTask
    {
        public bool CanEditIssue { get; set; }
    }
}
