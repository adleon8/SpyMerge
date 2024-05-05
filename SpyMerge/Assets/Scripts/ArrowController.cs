using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSignController : MonoBehaviour
{
    public GameObject arrowSignPrefab; // 화살표 표시 프리팹
    public Transform player; // 플레이어의 Transform

    public float activationDistance = 5f; // 화살표가 활성화되는 거리

    private GameObject arrowSignInstance; // 생성된 화살표 표시 오브젝트의 참조

    void Update()
    {
        // 플레이어와 화살표 사이의 거리 계산
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // 플레이어가 일정 거리 내에 있으면 화살표를 생성하고, 그렇지 않으면 파괴
        if (distanceToPlayer <= activationDistance)
        {
            if (arrowSignInstance == null)
            {
                // 플레이어가 일정 거리 내에 있고, 화살표가 생성되지 않은 경우
                // 화살표를 생성합니다.
                arrowSignInstance = Instantiate(arrowSignPrefab, transform.position, Quaternion.identity);
            }
        }
        else
        {
            if (arrowSignInstance != null)
            {
                // 플레이어가 일정 거리 밖에 있을 때
                // 화살표를 파괴합니다.
                Destroy(arrowSignInstance);
            }
        }
    }
}