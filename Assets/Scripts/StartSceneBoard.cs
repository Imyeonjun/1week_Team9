using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class StartSceneBoard : MonoBehaviour
{
    public GameObject stboard;    // 부모 오브젝트 (빈 오브젝트 프리팹)
    public GameObject startI;     // 카드 프리팹
    int sttimg;                 // 카드 이미지 번호 저장
    string[] textLabels = { "구", "조", "요", "청", "!" }; // 표시할 텍스트
    int cardIndex = 0;            // 현재 몇 번째 카드인지 추적

    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Invoke(nameof(SpawnCard), 0.2f * i); // 0.2초 간격으로 카드 생성
        }
    }

    void SpawnCard()
    {
        // Card 스크립트에서 names 배열을 가져오고 랜덤으로 섞어서, 첫 문자열을 매개 변수로 쓰기
        string selectedName = null; //섞은 배열의 첫 문자열을 넣을 변수 (혹시 모르니 비워주기)
        
        // 배열을 섞는 것 대신에, i에 0부터 끝까지 랜덤한 수를 받고,
        int i = UnityEngine.Random.Range(0, Card.names.Length);

        //i번째 있는 문자열 선택하기
        string selected = Card.names[i];


        // 파일명 뒤에 0, 1을 판단할 변수를 만들어서 Title.SettingT의 매개 변수로 쓰기
        // (image 변수에 0, 1의 랜덤한 값을 넣어서 클리어)
        int image = UnityEngine.Random.Range(0, 2);

        // 부모 오브젝트 생성 및 위치 조정
        GameObject tbd = Instantiate(stboard, this.transform);
        float y = 0 - (2 * cardIndex);
        tbd.transform.position = new Vector2(0f, y);

        // 자식 카드 생성 + 이미지 설정 + 텍스트 설정
        GameObject tit = Instantiate(startI, tbd.transform);
        tit.GetComponent<Title>().SettingT(selected, image, textLabels[cardIndex]);

        cardIndex++;
    }
}