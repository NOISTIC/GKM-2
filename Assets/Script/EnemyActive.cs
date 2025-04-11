using UnityEngine;

public class EnemyActive : MonoBehaviour
{
    public float health = 100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("Enemy died!");
        Destroy(gameObject); // Remove the enemy from the scene
    }
}
