﻿using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MLNetConsole.Exemplo05
{
    class ResultModel
    {
        [ColumnName("Score")]
        public float Salary { get; set; }
    }
}
