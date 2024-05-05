using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Merged.

[CreateAssetMenu(fileName = "New Projectile Object", menuName = "Inventory System/Items/Projectile")]

public class ProjectileObject : ItemObject
{
    public void Awake()
    {
        type = ItemType.Projectile;
    }
}
