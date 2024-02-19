using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public float Score;
    public bool PlayerVivo = true;
    public GameObject DeadUI;
    public Text ScoreTXT;
    
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
        DeadUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerVivo) { 
        Time.timeScale += .00001f;
            ScoreTXT.text = "" + Score;
        }
        else
        {
            DeadUI.SetActive(true);
        }

    }

    public void Replay()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
