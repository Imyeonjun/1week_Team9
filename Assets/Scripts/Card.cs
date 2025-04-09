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

    //���ϸ��� �������� �ʰ� �̹����� �ҷ����� ���� �ڵ�� ®���ϴ�.
    public void Setting(int number)
    {
        idx = number;

        //sprite �ʱ�ȭ
        Sprite sprite = null;

        if (idx == 0 || idx == 1)
        {
            sprite = Resources.Load<Sprite>($"Garam{idx}");
        }
        else if (idx == 2 || idx == 3)
        {
            //idx�� 2�� ���� ������ ���� ������ ����.
            //idx ���� ���� 0 �Ǵ� 1�� �Ҵ��Ͽ� �̹����� sprtie�� �Է�.
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

        //����Ƽ �� frontImage�� sprite�� ���� �̹��� �Ҵ�.
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
