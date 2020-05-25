using System.Collections.Generic;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging;

namespace LightUnit.TestAdapter
{
    [DefaultExecutorUri(VsConstants.ExecutorUriString)]
    [FileExtension(".exe")]
    [FileExtension(".dll")]
    internal class VsTestDiscoverer : ITestDiscoverer
    {
        public void DiscoverTests(IEnumerable<string> sources, IDiscoveryContext discoveryContext, IMessageLogger logger, ITestCaseDiscoverySink discoverySink)
        {
            logger.SendMessage(TestMessageLevel.Informational,"Discovering LightUnit test cases...");
        }
    }
}
