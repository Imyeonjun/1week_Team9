using UnityEngine;
using UnityEngine.UI; // ← 반드시 이거 있어야 해!

public class Title : MonoBehaviour
{
    public SpriteRenderer title;
    public Text titleText; // ← Legacy Text 타입!

    public void SettingT(int tt, string label, object spriteNum)
    {
        title.sprite = Resources.Load<Sprite>($"{name}{spriteNum}");
        titleText.text = label;
    }
}