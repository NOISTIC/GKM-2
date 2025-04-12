using UnityEngine;

public class EnemyActive : MonoBehaviour
{
    [Header("Health")]
    public float health = 100f;
    [Header("Patrolling")]
    public Transform[] patrolPoints;
    public int targetPoint;
    public int Speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        targetPoint = 0;
    }
    private void Update()
    {
        moving();
    }

    public void moving()
    {
        if (transform.position == patrolPoints[targetPoint].position)
        {
            increaseTarget();
        }
        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[targetPoint].position, Speed * Time.deltaTime);
    }

    public void increaseTarget()
    {
        targetPoint++;
        if (targetPoint >= patrolPoints.Length)
        {
            targetPoint = 0;
        }
    }
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
