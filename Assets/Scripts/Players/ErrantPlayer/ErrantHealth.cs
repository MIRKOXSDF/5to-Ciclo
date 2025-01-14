using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ErrantHealth : MonoBehaviour
{
    public int health;
    public int maxHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    private void Update()
    {
        if (health > maxHearts)
        {
            health = maxHearts;
        }

        CheckHearts();
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health -= 1;
        }
    }

    void CheckHearts()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
                hearts[i].sprite = fullHeart;
            else
                hearts[i].sprite = emptyHeart;


            if (i < maxHearts)
                hearts[i].enabled = true;
            else
                hearts[i].enabled = false;
        }
    }
}
