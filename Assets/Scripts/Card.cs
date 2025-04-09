using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{

    public int idx = 0;
    public int spriteNum = 0;

    public GameObject front;
    public GameObject back;
    public Animator anim;

    public SpriteRenderer frontImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //파일명 유지 (파일명이 {name}{0,1}이라는 조건 하에)
    public void Setting(int number)
    {
        idx = number;

        string[] names = { "Garam", "Garam", "Jongmin", "Jongmin", "Seongdeuk", "Seongdeuk", "Sanghun", "Sanghun", "Yeonjun", "Yeonjun" };

        if (idx >= 0 && idx < names.Length)
        {
            //삼항연산자 사용, idx가 0 혹은 1이면 그대로, 아니라면 %2 연산.
            spriteNum = (idx <= 1) ? idx : idx % 2;

            //이미지 이름 가져오기
            string name = names[idx];

            //스프라이트 로드
            Sprite sprite = Resources.Load<Sprite>($"{name}{spriteNum}");

            //유니티 내 frontImage에 sprite에 담은 이미지 할당
            if (sprite != null)
            {
                frontImage.sprite = sprite;
            }
        }
    }

    public void OpenCard()
    {
        anim.SetBool("isOpen", true);

        front.SetActive(true);
        back.SetActive(false);

        if (GameManager.Instance.firstCard == null)
        {

            GameManager.Instance.firstCard = this;
        }
        else
        {
            GameManager.Instance.secondCard = this;
            GameManager.Instance.Matched();
        }

    }
    public void DestroyCard()
    {
        Invoke("DestroyCardInvoke", 1.0f);
    }
    public void DestroyCardInvoke()
    {
        Destroy(gameObject);
    }
    public void CloseCard()
    {
        Invoke("CloseCardInvoke", 1.0f);
    }




    public void CloseCardInvoke()
    {
        anim.SetBool("isOpen", false);
        front.SetActive(false);
        back.SetActive(true );
    }
}
