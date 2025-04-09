using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Board : MonoBehaviour
{
    public GameObject card;

    // Start is called before the first frame update
    void Start()
    {
        int[] arr = {0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6 ,6, 7, 7, 8, 8 ,9 ,9 };
        arr = arr.OrderBy(x => Random.Range(0f, 9.0f)).ToArray();


        for(int i = 0; i < 20; i++)
            // i가 0으로 시작, i<16에 부합 시 괄호의 코드 실행, i++로 인해 i가 정수 1 획득 후 코드 For 재실행
        {
            GameObject go = Instantiate(card, this.transform);
            //이름 지정 = 카드 소환, 위치는 보드에 종속

            float x = (i % 4) * 1.4f - 2.1f;
            float y = (i / 4) * 1.4f - 3.0f;

            go.transform.position = new Vector2(x, y);
            go.GetComponent<Card>().Setting(arr[i]);

        }
        GameManager.Instance.cardCount = arr.Length;

    }

   
}
