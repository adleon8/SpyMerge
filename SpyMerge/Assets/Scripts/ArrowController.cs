using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSignController : MonoBehaviour
{
    public GameObject arrowSignPrefab;
    private GameObject arrowSignInstance;

    public float activationDistance = 5f;
    private Transform player;

    public enum Direction
    {
        North,
        NorthEast,
        East,
        SouthEast,
        South,
        SouthWest,
        West,
        NorthWest
    }

    [Header("Manual Direction Setting")]
    public Direction arrowDirection;

    private void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer <= activationDistance)
        {
            if (arrowSignInstance == null)
            {
                arrowSignInstance = Instantiate(arrowSignPrefab, transform.position, Quaternion.identity);
                SetArrowDirection(); // Set direction when instantiated
            }
        }
        else
        {
            if (arrowSignInstance != null)
            {
                Destroy(arrowSignInstance);
            }
        }
    }

    private void SetArrowDirection()
    {
        if (arrowSignInstance != null)
        {
            float targetAngle = ((int)arrowDirection) * 45;
            arrowSignInstance.transform.rotation = Quaternion.Euler(0, targetAngle, 0);
        }
    }
}