using UnityEngine;
using UnityEngine.UI; // ← 반드시 이거 있어야 해!

public class Title : MonoBehaviour
{
    public SpriteRenderer title;
    public Card card;
    public Text titleText; // ← Legacy Text 타입!

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