using UnityEngine;

public class SpikeShooter : MonoBehaviour
{
    public void Shoot()
    {
        GameObject pr = ProjectilePooler._instance.getPooledObject();
        pr.transform.position = transform.position + Vector3.right;
        pr.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 50F, ForceMode2D.Impulse);
    }
}