using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{

    public int idx = 0;

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

    //파일명을 변경하지 않고 이미지를 불러오는 것을 코드로 짰습니다.
    public void Setting(int number)
    {
        idx = number;

        //sprite 초기화
        Sprite sprite = null;

        if (idx == 0 || idx == 1)
        {
            sprite = Resources.Load<Sprite>($"Garam{idx}");
        }
        else if (idx == 2 || idx == 3)
        {
            //idx를 2로 나눈 나머지 값을 변수로 지정.
            //idx 값에 따라 0 또는 1로 할당하여 이미지를 sprtie에 입력.
            int spriteNum = idx % 2;
            sprite = Resources.Load<Sprite>($"Jongmin{spriteNum}");
        }
        else if (idx == 4 || idx == 5)
        {
            int spriteNum = idx % 2;
            sprite = Resources.Load<Sprite>($"Seongdeuk{spriteNum}");
        }
        else if (idx == 6 || idx == 7)
        {
            int spriteNum = idx % 2;
            sprite = Resources.Load<Sprite>($"Sanghun{spriteNum}");
        }
        else if (idx == 8 || idx == 9)
        {
            int spriteNum = idx % 2;
            sprite = Resources.Load<Sprite>($"Yeonjun{spriteNum}");
        }

        //유니티 내 frontImage에 sprite에 담은 이미지 할당.
        if (sprite != null)
        {
            frontImage.sprite = sprite;
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
