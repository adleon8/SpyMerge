using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Merged.

[CreateAssetMenu(fileName = "New Key Object", menuName = "Inventory System/Items/Key")]

public class KeyObject : ItemObject
{
    public void Awake()
    {
        type = ItemType.Key;
        id = 2;
    }
}
