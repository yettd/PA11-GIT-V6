using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public static gameManager ins;
    public float s;
    public Text t;
    // Start is called before the first frame update
    private void Awake()
    {
        if(ins==null)
        {
            ins = this;
            PlayerPrefs.SetFloat("s",0);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateScore()
    {
        s++;
        PlayerPrefs.SetFloat("s",s);
        t.text = "Score : " +s;
    }

}
