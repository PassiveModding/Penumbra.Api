using FFXIVClientStructs.FFXIV.Client.Game.Character;
using Penumbra.Api.Enums;

namespace Penumbra.Api.Models;

public record ResourceTreeDTO(string Name, int GameObjectIndex, nint GameObjectAddress,
    nint DrawObjectAddress, bool LocalPlayerRelated, bool PlayerRelated, 
    bool Networked, string CollectionName, 
    List<ResourceNodeDTO> Nodes, CustomizeData CustomizeData, string RaceCode);

public record ResourceNodeDTO(string? Name, string? FallbackName, string Icon, 
    ResourceType Type, nint ObjectAddress, nint ResourceHandle, 
    string[] PossibleGamePaths, string FullPath, ulong Length, 
    bool Internal, List<ResourceNodeDTO> Children, string GamePath);
