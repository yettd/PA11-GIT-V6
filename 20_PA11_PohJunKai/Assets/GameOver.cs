using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameOver : MonoBehaviour
{
    public Text t;
    private float s;
    // Start is called before the first frame update
    void Start()
    {
        s = PlayerPrefs.GetFloat("s");

        t.text = "Score : " +s;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void reset()
    {
        SceneManager.LoadScene(0);
    }
}
