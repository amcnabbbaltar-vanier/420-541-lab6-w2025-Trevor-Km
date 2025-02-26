using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth;
    private int currentHealth;

    public Slider healthBar;
    // Start is called before the first frame update
    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.maxValue = maxHealth;
        healthBar.value = currentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage){
        currentHealth -= damage;
        healthBar.value = currentHealth;
        if(currentHealth <= 0){
            Die();
        }
    }

    public void Die(){
        if(GameManager.Instance != null){
            GameManager.Instance.IncrementScore();
            GameManager.Instance.LoadNewScene();
        }
    }

}
