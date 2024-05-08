using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Merged.

[CreateAssetMenu(fileName = "New Item Database", menuName = "Inventory System/Items/Database")] // Creates it in the editor.
public class ItemDatabaseObject : ScriptableObject, ISerializationCallbackReceiver
{
    public ItemObject[] Items; // Array of all the items that exist within the game.
    public Dictionary<int, ItemObject> GetItem = new Dictionary<int, ItemObject>();// Dictionary to import item and return ID of item.
    //public Dictionary<int, ItemObject> GetItem = new Dictionary<int, ItemObject>();// Dictionary to import ID and return item.

    public void OnAfterDeserialize()
    {
       // GetId.Clear();
        GetItem.Clear();
        foreach (ItemObject item in Items)
        {
            if (item != null && !GetItem.ContainsKey(item.id))
            {
                GetItem.Add(item.id, item);
            }
            else
            {
                Debug.Log("Duplicate or null item detected: " + (item != null ? item.type : "Null item"));
            }
        }
        /*
        for (int i = 0; i < Items.Length; i++)
        {
            if (!GetId.ContainsKey(Items[i]))
            {
                GetId.Add(Items[i], i);
                GetItem.Add(i, Items[i]);
            }
            else
            {
                Debug.LogError("Duplicate item detected in ItemDatabase: " + Items[i].name);
            }
        }
        
        for (int i = 0; i < Items.Length; i++)
        {
            if (Items[i] != null && !GetItem.ContainsKey(Items[i].id))
            {
                GetItem.Add(Items[i].id, Items[i]);
            }
            else
            {
                Debug.Log("Duplicate or null item detected in ItemDatabase: " + (Items[i] != null ? Items[i].name : "Null item"));
            }
            
        }
        */




    }
    public void OnBeforeSerialize()
    {

    }
}
