using UnityEngine;
using UnityEngine.UI;

public class Title : MonoBehaviour
{
    public SpriteRenderer title;
    public Text titleText;

    // �Լ��� ������ �Ű� ������ ȣ���ϴ� �ʿ��� ������ ��.
    // �Լ� ���� ������ �� �Ű� ������ �̿��� �� �־�� �� ��.
    public void SettingT(string name, int tt, string label)
    {
        title.sprite = Resources.Load<Sprite>($"{name}{tt}");
        titleText.text = label;
    }
}