using UnityEngine;

public class SpikeShooter : MonoBehaviour
{
    [SerializeField] Transform direction = null;
    [SerializeField] float startVelocity = 10;


    public void Shoot()
    {
        GameObject pr = ProjectilePooler._instance.getPooledObject();

        var dirVector = direction.position - transform.position;
        dirVector = (Vector2)dirVector;
        dirVector = dirVector.normalized;


        pr.transform.position = direction.position;
        pr.transform.rotation = transform.rotation;
        pr.GetComponent<Rigidbody2D>().AddForce(dirVector * startVelocity, ForceMode2D.Impulse);
    }
}