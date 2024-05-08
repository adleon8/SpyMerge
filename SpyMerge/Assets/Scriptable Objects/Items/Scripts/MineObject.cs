using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Merged

[CreateAssetMenu(fileName = "New Mine Object", menuName = "Inventory System/Items/Mine")]

public class MineObject : ItemObject
{
    // public GameObject minePrefab
    public float distance = 2f;

    public void Awake()
    {
        type = ItemType.Mine;
        id = 3;
    }

    public override void Use(GameObject player)
    {
        if (worldPrefab != null)
        {
            // Calculate the position in front of the player to place the mine
            Vector3 placePosition = player.transform.position + player.transform.forward * distance + Vector3.down * 0.5f;

            // Instantiates mine prefab at the calculated position
            Instantiate(worldPrefab, placePosition, Quaternion.identity);
        }
        else
        {
            Debug.Log("Mine prefab unassigned");
        }
    }
}
