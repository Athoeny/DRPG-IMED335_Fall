using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    public int health;
    public int maxHealth;
    
    public Sprite EmptyHeart;
    public Sprite Heart;
    public Image[] hearts;
    
    public PlayerHealth playerHealth;
    
    public EnemyHealth EnemyHealth;
    public Image Healthbar;

    void Update()
    {
        health = playerHealth.health;
        maxHealth = playerHealth.maxHealth;
        for (int i = 0; i < hearts.Length; i++)
        {
            if(i < health)
            {
                hearts[i].sprite = Heart;
            }
            else
            {
                hearts[i].sprite = EmptyHeart;
            }
            if(i < maxHealth)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
}
