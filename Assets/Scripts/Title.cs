using UnityEngine;
using UnityEngine.UI; // �� �ݵ�� �̰� �־�� ��!

public class Title : MonoBehaviour
{
    public SpriteRenderer title;
    public Text titleText; // �� Legacy Text Ÿ��!

    public void SettingT(int tt, string label)
    {
        title.sprite = Resources.Load<Sprite>($"team{tt}");
        titleText.text = label;
    }
}