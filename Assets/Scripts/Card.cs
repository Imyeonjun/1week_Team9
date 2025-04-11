using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public static string[] names = { "Garam", "Garam", "Jongmin", "Jongmin", "Seongdeuk", "Seongdeuk", "Sanghun", "Sanghun", "Yeonjun", "Yeonjun" };

    public int idx = 0;

    public GameObject front;
    public GameObject back;
    public Animator anim;

    public SpriteRenderer frontImage;
    public AudioClip clip;
    AudioSource audioSource;

    // Start is called before the first frame update
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

        if (idx >= 0 && idx < names.Length)
        {
            //idx가 짝수인지 홀수인지 판단하여 spriteNum에 저장.
            //이 때문에 파일명의 마지막이 0 또는 1로 끝나야 함.

            int spriteNum = idx % 2;

            //정해진 idx에 names 배열의 문자열이 대응됨.
            //그걸 변수 name에 저장 (idx에 따라 이름이 바뀜)
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
        back.SetActive(true);
    }
}

// 테스트입니다.