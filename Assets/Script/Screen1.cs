using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen1 : MonoBehaviour
{
    public GameObject Start_screen;
    public GameObject Ready_button;
    public GameObject Play;
    public screen2 s2;
    int num;
    // Start is called before the first frame update
    void Start()
    {
        Start_screen.SetActive(true);
        Ready_button.SetActive(true);
        Play.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Ready_pressed()
    {
        Ready_button.SetActive(false);
        Play.SetActive(true);
    }

    public void scissor()
    {
        num = 1;
        Start_screen.SetActive(false);
        s2.AI(num);
    }
    public void paper()
    {
        num = 2;
        Start_screen.SetActive(false);
        s2.AI(num);
    }
    public void stone()
    {
        num = 3;
        Start_screen.SetActive(false);
        s2.AI(num);
    }
    public void quit()
    {
        Application.Quit();
    }

}
