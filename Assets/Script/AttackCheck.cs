using UnityEngine;

public class AttackCheck : MonoBehaviour
{
    public float attackDamage = 100f; 
    public GameObject attackCheck;
    public float attackRange = 1.5f; 
    public LayerMask enemyLayer; 

    void Update()
    {
        Attack();
    }

    private void Attack()
    {
        // Check for enemies in range
        Collider[] hitEnemies = Physics.OverlapSphere(transform.position, attackRange, enemyLayer);

        foreach (Collider enemy in hitEnemies)
        {
            EnemyActive enemyScript = enemy.GetComponent<EnemyActive>();
            if (enemyScript != null)
            {
                enemyScript.TakeDamage(attackDamage);
                Debug.Log("Attacked enemy! Remaining health: " + enemyScript.health);
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        // Visualize the attack range in the editor
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }
}
