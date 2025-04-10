using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    //이미지 추가될 경우 배열 수정하기
    public static Action card;

    public static int spriteNum;
    public int idx = 0;

    public GameObject front;
    public GameObject back;
    public Animator anim;

    public SpriteRenderer frontImage;
    public AudioClip clip;
    AudioSource audioSource;

    private void Awake()
    {
        card = () => { Setting(0); };
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
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
            spriteNum = idx % 2;

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
        audioSource.PlayOneShot(clip);

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
