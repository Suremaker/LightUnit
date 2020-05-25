using System;
using System.Collections.Generic;
using System.Threading;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter;

namespace LightUnit.TestAdapter
{
    [ExtensionUri(VsConstants.ExecutorUriString)]
    internal class VsTestExecutor : ITestExecutor
    {
        private readonly CancellationTokenSource _cts = new CancellationTokenSource();
        public void RunTests(IEnumerable<TestCase> tests, IRunContext runContext, IFrameworkHandle frameworkHandle)
        {
            throw new NotImplementedException();
        }

        public void RunTests(IEnumerable<string> sources, IRunContext runContext, IFrameworkHandle frameworkHandle)
        {
            throw new NotImplementedException();
        }

        public void Cancel()
        {
            _cts.Cancel();
        }
    }
}