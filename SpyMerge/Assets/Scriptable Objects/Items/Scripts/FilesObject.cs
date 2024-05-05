using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Merged.

[CreateAssetMenu(fileName = "New Files Object", menuName = "Inventory System/Items/Files")]

public class FilesObject : ItemObject
{
    public void Awake()
    {
        type = ItemType.Files;
    }
}
