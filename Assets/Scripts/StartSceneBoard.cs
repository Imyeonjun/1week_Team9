using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class StartSceneBoard : MonoBehaviour
{
    public GameObject card;
    public GameObject stboard;    // �θ� ������Ʈ (�� ������Ʈ ������)
    public GameObject startI;     // ī�� ������

    string[] textLabels = { "��", "��", "��", "û", "!" }; // ǥ���� �ؽ�Ʈ
    string[] spriteNum;             // Card ��ũ��Ʈ���� ������ �迭�� ��ȣ�� ���� ����
    string[] sttImg;                 // ī�� �̹��� �̸� ����

    public int[] sttImgNum = { 1, 2, 3, 4, 5 };
    int cardIndex = 0;            // ���� �� ��° ī������ ����


    void Start()
    {
        Card.card();

        //���� �������� ����
        sttImg = spriteNum.OrderBy(x => Random.Range(0f, 9.0f)).ToArray(); // ī�� ���� ����

        for (int i = 0; i < 5; i++)
        {
            Invoke(nameof(SpawnCard), 0.2f * i); // 0.2�� �������� ī�� ����
        }
    }

    void SpawnCard()
    {
        // �θ� ������Ʈ ���� �� ��ġ ����
        GameObject tbd = Instantiate(stboard, this.transform);
        float y = 0 - (2 * cardIndex);
        tbd.transform.position = new Vector2(0f, y);

        // �ڽ� ī�� ���� + �̹��� ���� + �ؽ�Ʈ ����
        GameObject tit = Instantiate(startI, tbd.transform);
        tit.GetComponent<Card>().Setting(0);

        cardIndex++;
    }
}