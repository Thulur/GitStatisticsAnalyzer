﻿using System;
using System.Collections.Generic;
using GitDataExplorer.Extensions;
using GitDataExplorer.Results.Commits;

namespace GitDataExplorer.Results
{
    class DanglingCommitResult : IResult
    {

        public void ParseResult(IList<string> lines)
        {
            lines.ForEach(l =>
            {
                if (l.StartsWith("dangling commit "))
                {
                    var commit = new BareCommitResult();
                    commit.ParseResult(new List<string>() { l.Remove(0, l.LastIndexOf(" ", StringComparison.Ordinal) + 1)});

                    Commits.Add(commit);
                }
            });
        }

        public ExecutionResult ExecutionResult { get; }

        public IList<ICommit> Commits { get; } = new List<ICommit>();
    }
}
