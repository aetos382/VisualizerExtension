using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Extensibility;

namespace VisualizerExtension;

/// <summary>
/// Extension entrypoint for the VisualStudio.Extensibility extension.
/// </summary>
[VisualStudioContribution]
public class VisualizerExtension : Extension
{
    /// <inheritdoc/>
    public override ExtensionConfiguration ExtensionConfiguration => new()
    {
        Metadata = new(
            id: "VisualizerExtension.81fc93bd-162b-406d-9868-be651cb8ac33",
            version: this.ExtensionAssemblyVersion,
            publisherName: "Publisher name",
            displayName: "VisualizerExtension",
            description: "Extension description"),
    };

    /// <inheritdoc />
    protected override void InitializeServices(IServiceCollection serviceCollection)
    {
        base.InitializeServices(serviceCollection);

        // You can configure dependency injection here by adding services to the serviceCollection.
    }
}