using UnityEngine;
using UnityEngine.UI; // �� �ݵ�� �̰� �־�� ��!

public class Title : MonoBehaviour
{
    public SpriteRenderer title;
    public Card card;
    public Text titleText; // �� Legacy Text Ÿ��!

    private void Start()
    {
        int num = Card.spriteNum;
    }

    public void SettingT(int spriteNum, string label)
    {
        title.sprite = Resources.Load<Sprite>($"{name}{spriteNum}");
        titleText.text = label;
    }
}