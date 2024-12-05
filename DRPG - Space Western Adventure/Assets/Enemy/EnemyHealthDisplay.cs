using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthDisplay : MonoBehaviour
{
    public EnemyHealth enemyHealth;
    public Image[] bar;
    public Sprite EmptyBar;
    public Sprite FullBar;

    void Start()
    {
        if (enemyHealth == null)
        {
            enemyHealth = GetComponent<EnemyHealth>();
        }

        UpdateHealthBar();
    }

    void Update()
    {

        UpdateHealthBar();
    }

    public void UpdateHealthBar()
    {
        if (enemyHealth == null) return;

        int maxHealth = enemyHealth.maxHealth;
        int currentHealth = enemyHealth.currentHealth;

        for (int i = 0; i < bar.Length; i++)
        {
            if (i < currentHealth)
            {
                bar[i].sprite = FullBar;
                bar[i].enabled = true;
            }
            else if (i < maxHealth)
            {
                bar[i].sprite = EmptyBar;
                bar[i].enabled = true;
            }
            else
            {
                bar[i].enabled = false;
            }
        }
    }
}