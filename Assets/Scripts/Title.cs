using UnityEngine;
using UnityEngine.UI; // �� �ݵ�� �̰� �־�� ��!

public class Title : MonoBehaviour
{
    public SpriteRenderer title;
    public Text titleText; // �� Legacy Text Ÿ��!

    public void SettingT(int tt, string label, object spriteNum)
    {
        title.sprite = Resources.Load<Sprite>($"{name}{spriteNum}");
        titleText.text = label;
    }
}