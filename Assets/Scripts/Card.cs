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

    //���ϸ� ���� (���ϸ��� {name}{0,1}�̶�� ���� �Ͽ�)
    public void Setting(int number)
    {
        idx = number;

        string[] names = { "Garam", "Garam", "Jongmin", "Jongmin", "Seongdeuk", "Seongdeuk", "Sanghun", "Sanghun", "Yeonjun", "Yeonjun" };

        if (idx >= 0 && idx < names.Length)
        {
            //���׿����� ���, idx�� 0 Ȥ�� 1�̸� �״��, �ƴ϶�� %2 ����.
            spriteNum = (idx <= 1) ? idx : idx % 2;

            //�̹��� �̸� ��������
            string name = names[idx];

            //��������Ʈ �ε�
            Sprite sprite = Resources.Load<Sprite>($"{name}{spriteNum}");

            //����Ƽ �� frontImage�� sprite�� ���� �̹��� �Ҵ�
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
