using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class StartSceneBoard : MonoBehaviour
{
    public GameObject stboard;    // �θ� ������Ʈ (�� ������Ʈ ������)
    public GameObject startI;     // ī�� ������
    int sttimg;                 // ī�� �̹��� ��ȣ ����
    string[] textLabels = { "��", "��", "��", "û", "!" }; // ǥ���� �ؽ�Ʈ
    int cardIndex = 0;            // ���� �� ��° ī������ ����

    void Start()
    {
        // ���⼭ sttimg�� 0, 1 �ֱ�

        sttimg = Random.Range(0, 2);

        for (int i = 0; i < 5; i++)
        {
            Invoke(nameof(SpawnCard), 0.2f * i); // 0.2�� �������� ī�� ����
        }
    }

    void SpawnCard()
    {
        // Card ��ũ��Ʈ���� names �迭�� �������� (Card ��ũ��Ʈ���� names�� static���� ����� Ŭ����)
        // ���ϸ� �ڿ� 0, 1�� �Ǵ��� ������ ����
        //Title.SettingT�� �Ű� ������ ����


        // �θ� ������Ʈ ���� �� ��ġ ����
        GameObject tbd = Instantiate(stboard, this.transform);
        float y = 0 - (2 * cardIndex);
        tbd.transform.position = new Vector2(0f, y);

        // �ڽ� ī�� ���� + �̹��� ���� + �ؽ�Ʈ ����
        GameObject tit = Instantiate(startI, tbd.transform);
        tit.GetComponent<Title>().SettingT(name, sttimg, textLabels[cardIndex]);

        cardIndex++;
    }
}