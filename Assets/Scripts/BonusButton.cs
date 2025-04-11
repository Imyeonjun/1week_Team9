using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BonusButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void Bonus()
    {
        SceneManager.LoadScene("BonusScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
