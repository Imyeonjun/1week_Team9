using UnityEngine;
using UnityEngine.UI;

public class Title : MonoBehaviour
{
    public SpriteRenderer title;
    public Text titleText;

    // 함수에 지정된 매개 변수는 호출하는 쪽에서 지정할 것.
    // 함수 안의 로직은 이 매개 변수를 이용할 수 있어야 할 것.
    public void SettingT(string name, int tt, string label)
    {
        title.sprite = Resources.Load<Sprite>($"{name}{tt}");
        titleText.text = label;
    }
}