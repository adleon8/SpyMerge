using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSignController : MonoBehaviour
{
    public GameObject arrowSignPrefab; // ȭ��ǥ ǥ�� ������
    public Transform player; // �÷��̾��� Transform

    public float activationDistance = 5f; // ȭ��ǥ�� Ȱ��ȭ�Ǵ� �Ÿ�

    private GameObject arrowSignInstance; // ������ ȭ��ǥ ǥ�� ������Ʈ�� ����

    void Update()
    {
        // �÷��̾�� ȭ��ǥ ������ �Ÿ� ���
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // �÷��̾ ���� �Ÿ� ���� ������ ȭ��ǥ�� �����ϰ�, �׷��� ������ �ı�
        if (distanceToPlayer <= activationDistance)
        {
            if (arrowSignInstance == null)
            {
                // �÷��̾ ���� �Ÿ� ���� �ְ�, ȭ��ǥ�� �������� ���� ���
                // ȭ��ǥ�� �����մϴ�.
                arrowSignInstance = Instantiate(arrowSignPrefab, transform.position, Quaternion.identity);
            }
        }
        else
        {
            if (arrowSignInstance != null)
            {
                // �÷��̾ ���� �Ÿ� �ۿ� ���� ��
                // ȭ��ǥ�� �ı��մϴ�.
                Destroy(arrowSignInstance);
            }
        }
    }
}