using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Card firstCard;
    public Card secondCard;




    public Text timetxt;
    public GameObject endTxt;
    public GameObject goodendTxt;

    public int cardCount = 0;
     float time = 40.0f;




    private void Awake()
    {
        if (Instance == null)
        { 
            Instance = this;
        }
    }



    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        timetxt.text = time.ToString("N2");
        if (time <= 0.0f)
        {
            endTxt.SetActive(true);

            Card[] cards = FindObjectsOfType<Card>();
            foreach (Card card in cards)
            {
                Destroy(card.gameObject);
            }
            StartCoroutine(EndGameAfterDelay(1.0f));

            Time.timeScale = 0.0f;
        }
        else if(cardCount == 0)
        {
            goodendTxt.SetActive(true);
            Card[] cards = FindObjectsOfType<Card>();
            foreach (Card card in cards)
            {
                Destroy(card.gameObject);
            }
            StartCoroutine(EndGameAfterDelay(1.0f));
            Time.timeScale = 0.0f;

        }
    }
    IEnumerator EndGameAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        Time.timeScale = 0.0f;
    }
    public void Matched()
    {
        if (firstCard.idx == secondCard.idx)
        {
            firstCard.DestroyCard(); // 첫번째 카드와 두번째 카드가 일치하면 파괴
            secondCard.DestroyCard();
            cardCount -= 2;
            if (cardCount == 0)
            {
                
                Time.timeScale = 0.0f;
                
            }
        }
        else
        {
            firstCard.CloseCard(); // 다를 경우 일정 시간 후 뒤집힘
            secondCard.CloseCard();
        }
        firstCard = null;   
        secondCard = null;
    }
}
