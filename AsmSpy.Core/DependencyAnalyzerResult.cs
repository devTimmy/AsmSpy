﻿using System;
using System.Collections.Generic;
using System.IO;

namespace AsmSpy.Core
{
    public class DependencyAnalyzerResult : IDependencyAnalyzerResult
    {
        public DependencyAnalyzerResult(ICollection<FileInfo> analyzedFiles)
        {
            AnalyzedFiles = analyzedFiles;
            Assemblies = new Dictionary<string, AssemblyReferenceInfo>(StringComparer.OrdinalIgnoreCase);
        }

        public DependencyAnalyzerResult(ICollection<FileInfo> analyzedFiles, IDictionary<string, AssemblyReferenceInfo> assemblies) : this(analyzedFiles)
        {
            AnalyzedFiles = analyzedFiles;
            Assemblies = assemblies;
        }

        public ICollection<FileInfo> AnalyzedFiles { get; }
        public IDictionary<string, AssemblyReferenceInfo> Assemblies { get; }
    }
}
