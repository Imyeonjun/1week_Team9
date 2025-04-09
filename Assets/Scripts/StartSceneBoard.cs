using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class StartSceneBoard : MonoBehaviour
{
    public GameObject stboard;    // �θ� ������Ʈ (�� ������Ʈ ������)
    public GameObject startI;     // ī�� ������
    int[] sttimg;                 // ī�� �̹��� ��ȣ ����
    string[] textLabels = { "��", "��", "��", "û", "!" }; // ǥ���� �ؽ�Ʈ
    int cardIndex = 0;            // ���� �� ��° ī������ ����

    void Start()
    {
        int[] raw = { 0, 2, 4, 6, 7 };
        sttimg = raw.OrderBy(x => Random.Range(0f, 9.0f)).ToArray(); // ī�� ���� ����

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
        tit.GetComponent<Title>().SettingT(sttimg[cardIndex], textLabels[cardIndex]);

        cardIndex++;
    }
}