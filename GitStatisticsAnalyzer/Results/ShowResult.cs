﻿using System;
using System.Collections.Generic;

namespace GitStatisticsAnalyzer.Results
{
    class ShowResult : IResult
    {
        public ExecutionResult ExecutionResult
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void ParseResult(IList<string> lines)
        {
            throw new NotImplementedException();
        }
    }
}