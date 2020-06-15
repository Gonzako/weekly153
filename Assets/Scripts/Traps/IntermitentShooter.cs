using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntermitentShooter : MonoBehaviour
{
    public List<shootPattern> shootPattern = new List<shootPattern>();

    public float startWait = 0.2f;
    public float patternEndCoolDown = 2f;

    [SerializeField] float startVelocity = 10;

    private Coroutine coroutine;
    private IEnumerator shootCycle()
    {
        yield return new WaitForSeconds(startWait);

        while (true)
        {

            foreach (shootPattern n in shootPattern)
            {
                for (int i = 0; i < transform.childCount; i++)
                {
                    GameObject pr = ProjectilePooler._instance.getPooledObject();
                    Transform direction = transform.GetChild(i);

                    var dirVector = direction.position - transform.position;
                    dirVector = (Vector2)dirVector;
                    dirVector = dirVector.normalized;


                    pr.transform.position = direction.position;
                    pr.transform.rotation = transform.rotation;
                    pr.GetComponent<Rigidbody2D>().AddForce(dirVector * startVelocity, ForceMode2D.Impulse);
                }
                yield return new WaitForSeconds(n.timeToWait);
            }

            yield return new WaitForSeconds(patternEndCoolDown);
        }
    }

    private void OnEnable()
    {
        coroutine = StartCoroutine(shootCycle());
    }


    private void OnDisable()
    {
        StopCoroutine(coroutine);
    }

}

[System.Serializable]
public struct shootPattern
{
    public float timeToWait;
}