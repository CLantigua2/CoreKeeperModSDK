using System;
using Unity.Entities;
using UnityEngine;
using PugMod;

namespace PortableFoundationsMod
{
    public class ModEntry : IMod
    {
        private const string MOD_VERSION = "1.0.0";
        private const string ITEM_LOOKUP_NAME = "PackedStructureItem";

        public static ObjectID PackedItemObjectID { get; private set; } = ObjectID.None;

        public void EarlyInit()
        {
            Debug.Log($"[PortableFoundations] EarlyInit version {MOD_VERSION}");
        }

        public void Init()
        {
            Debug.Log("[PortableFoundations] Init called.");
        }

        public void PostInit()
        {
            RegisterModItem();
        }

        private void RegisterModItem()
        {
            try
            {
                // The SDK bakes custom object names directly into the ObjectID enum structure at runtime
                if (Enum.TryParse(ITEM_LOOKUP_NAME, out ObjectID foundID))
                {
                    PackedItemObjectID = foundID;
                    Debug.Log($"[PortableFoundations] Successfully linked custom item! ID assigned: {PackedItemObjectID}");
                }
                else
                {
                    Debug.LogError($"[PortableFoundations] Critical Failure: Could not resolve enum entry for '{ITEM_LOOKUP_NAME}'.");
                }
            }
            catch (Exception ex)
            {
                Debug.LogException(ex);
            }
        }

        // Required interface implementation
        public void Update()
        {
            // Left blank intentionally for now
        }

        // Required interface implementation
        public void ModObjectLoaded(UnityEngine.Object obj)
        {
            // Left blank intentionally for now
        }

        public void Shutdown()
        {
            Debug.Log("[PortableFoundations] Shutting down.");
        }
    }
}