using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class StartSceneBoard : MonoBehaviour
{
    public GameObject stboard;    // 부모 오브젝트 (빈 오브젝트 프리팹)
    public GameObject startI;     // 카드 프리팹
    int[] sttimg;                 // 카드 이미지 번호 저장
    string[] textLabels = { "구", "조", "요", "청", "!" }; // 표시할 텍스트
    int cardIndex = 0;            // 현재 몇 번째 카드인지 추적

    void Start()
    {
        int[] raw = { 0, 2, 4, 6, 7 };
        sttimg = raw.OrderBy(x => Random.Range(0f, 9.0f)).ToArray(); // 카드 순서 랜덤

        for (int i = 0; i < 5; i++)
        {
            Invoke(nameof(SpawnCard), 0.2f * i); // 0.2초 간격으로 카드 생성
        }
    }

    void SpawnCard()
    {
        // 부모 오브젝트 생성 및 위치 조정
        GameObject tbd = Instantiate(stboard, this.transform);
        float y = 0 - (2 * cardIndex);
        tbd.transform.position = new Vector2(0f, y);

        // 자식 카드 생성 + 이미지 설정 + 텍스트 설정
        GameObject tit = Instantiate(startI, tbd.transform);
        tit.GetComponent<Title>().SettingT(sttimg[cardIndex], textLabels[cardIndex]);

        cardIndex++;
    }
}