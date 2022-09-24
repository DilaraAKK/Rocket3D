using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public GameObject panel;
    public GameObject mainPanel;
    public GameObject settingsPanel;
    public GameObject[] charPrefab;
    public GameObject[] rocketPrefabs;


    void Start()
    {
      
    }

    
    void Update()
    {
        
    }
    public void StartGame()
    {
        panel.SetActive(false);
        charPrefab[0].SetActive(true);
        charPrefab[1].SetActive(true);
        charPrefab[2].SetActive(true);

        rocketPrefabs[0].SetActive(true);
        rocketPrefabs[1].SetActive(true);
        rocketPrefabs[2].SetActive(true);
    }
    public void Settings()
    {
        mainPanel.SetActive(false);
        settingsPanel.SetActive(true);
    }
    public void GoBack()
    {
        mainPanel.SetActive(true);
        settingsPanel.SetActive(false);
    }
}

