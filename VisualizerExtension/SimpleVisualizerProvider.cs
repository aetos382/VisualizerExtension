using System.Threading;
using System.Threading.Tasks;

using Microsoft.VisualStudio.Extensibility;
using Microsoft.VisualStudio.Extensibility.DebuggerVisualizers;
using Microsoft.VisualStudio.RpcContracts.RemoteUI;

namespace VisualizerExtension;

[VisualStudioContribution]
public sealed class SimpleVisualizerProvider :
    DebuggerVisualizerProvider
{
    public override Task<IRemoteUserControl> CreateVisualizerAsync(
        VisualizerTarget visualizerTarget,
        CancellationToken cancellationToken)
    {
        return Task.FromResult<IRemoteUserControl>(new VisualizerDialog());
    }

    public override DebuggerVisualizerProviderConfiguration DebuggerVisualizerProviderConfiguration { get; } =
        new("%SimpleVisualizer.Name%", typeof(string));
}