using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameBehaviour : MonoBehaviour
{

    public static GameBehaviour Instance;



    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;

        } else if (Instance != this)
        {
            Destroy(gameObject);
        }


    }

    void Start()
    {







    }
    private void Update()
    {
        



    }

    public void sceneToMoveTo()
    {
        SceneManager.LoadScene("BattlePrototypeTestArea");
    }













}