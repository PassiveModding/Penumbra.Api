using Dalamud.Game.ClientState.Objects.Types;
using Dalamud.Plugin;
using Penumbra.Api.Enums;
using Penumbra.Api.Helpers;

namespace Penumbra.Api;

public static partial class Ipc
{
    /// <inheritdoc cref="IPenumbraApi.GetSerializedResourceTrees"/>
    public static class GetSerializedResourceTrees
    {
        public const string Label = $"Penumbra.{nameof(GetSerializedResourceTrees)}";

        public static FuncProvider<bool, ushort[], IReadOnlyList<(string, string)>> Provider(DalamudPluginInterface pi,
                       Func<bool, ushort[], IReadOnlyList<(string, string)>> func)
            => new(pi, Label, func);

        public static FuncSubscriber<bool, ushort[], IReadOnlyList<(string, string)>> Subscriber(DalamudPluginInterface pi)
            => new(pi, Label);
    }

    /// <inheritdoc cref="IPenumbraApi.GetGameObjectResourcePaths"/>
    public static class GetGameObjectResourcePaths
    {
        public const string Label = $"Penumbra.{nameof(GetGameObjectResourcePaths)}";

        public static FuncProvider<ushort[], IReadOnlyDictionary<string, string[]>?[]> Provider(DalamudPluginInterface pi,
            Func<ushort[], IReadOnlyDictionary<string, string[]>?[]> func)
            => new(pi, Label, func);

        public static ParamsFuncSubscriber<ushort, IReadOnlyDictionary<string, string[]>?[]> Subscriber(DalamudPluginInterface pi)
            => new(pi, Label);
    }

    /// <inheritdoc cref="IPenumbraApi.GetPlayerResourcePaths"/>
    public static class GetPlayerResourcePaths
    {
        public const string Label = $"Penumbra.{nameof(GetPlayerResourcePaths)}";

        public static FuncProvider<IReadOnlyDictionary<ushort, IReadOnlyDictionary<string, string[]>>> Provider(DalamudPluginInterface pi,
            Func<IReadOnlyDictionary<ushort, IReadOnlyDictionary<string, string[]>>> func)
            => new(pi, Label, func);

        public static FuncSubscriber<IReadOnlyDictionary<ushort, IReadOnlyDictionary<string, string[]>>> Subscriber(DalamudPluginInterface pi)
            => new(pi, Label);
    }

    /// <inheritdoc cref="IPenumbraApi.GetGameObjectResourcesOfType"/>
    public static class GetGameObjectResourcesOfType
    {
        public const string Label = $"Penumbra.{nameof(GetGameObjectResourcesOfType)}";

        public static FuncProvider<ResourceType, bool, ushort[], IReadOnlyDictionary<nint, ( string, string, ChangedItemIcon )>?[]> Provider(
            DalamudPluginInterface pi,
            Func<ResourceType, bool, ushort[], IReadOnlyDictionary<nint, ( string, string, ChangedItemIcon )>?[]> func)
            => new(pi, Label, func);

        public static ParamsFuncSubscriber<ResourceType, bool, ushort, IReadOnlyDictionary<nint, ( string, string, ChangedItemIcon )>?[]>
            Subscriber(DalamudPluginInterface pi)
            => new(pi, Label);
    }

    /// <inheritdoc cref="IPenumbraApi.GetPlayerResourcesOfType"/>
    public static class GetPlayerResourcesOfType
    {
        public const string Label = $"Penumbra.{nameof(GetPlayerResourcesOfType)}";

        public static FuncProvider<ResourceType, bool,
            IReadOnlyDictionary<ushort, IReadOnlyDictionary<nint, ( string, string, ChangedItemIcon )>>> Provider(
            DalamudPluginInterface pi,
            Func<ResourceType, bool, IReadOnlyDictionary<ushort, IReadOnlyDictionary<nint, ( string, string, ChangedItemIcon )>>> func)
            => new(pi, Label, func);

        public static FuncSubscriber<ResourceType, bool,
            IReadOnlyDictionary<ushort, IReadOnlyDictionary<nint, ( string, string, ChangedItemIcon )>>> Subscriber(
            DalamudPluginInterface pi)
            => new(pi, Label);
    }
}
