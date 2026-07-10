using UnityEngine;
using PugMod;

public class ModEntry : IMod
{
    // This method is called automatically when the mod is loaded
    public void EarlyInit()
    {
        Debug.Log("[PortableFoundationsMod] Phase 1 Active: Mod has successfully loaded into the game execution pipeline! ");
    }

    public void Init()
    {
        // Optional second phase of initialization
    }

    // Runs every frame on the main thread
    public void Update()
    {
        // Keep empty for now
    }

    public void Shutdown()
    {
        // Called when leaving the game or disabling the mod
        Debug.Log("[PortableFoundationsMod] Shutting down cleanly.");
    }

    // Capitalized 'Object' to explicitly match the interface signature
    public void ModObjectLoaded(Object block)
    {
        // Used in later phases when tracking objects
    }
}