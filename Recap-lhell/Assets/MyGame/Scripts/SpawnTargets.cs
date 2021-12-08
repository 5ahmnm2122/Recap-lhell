using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTargets : MonoBehaviour
{
    public GameObject[] target;

    public void Start()
    {
        StartCoroutine(SpawnOneTarget());
    }

    public IEnumerator SpawnOneTarget()
    {
        GameObject targetPosition = Instantiate(target[Random.Range(0, target.length)]);
        targetPosition.transform.position = new Vector3(Random.Range(-10f, 10f), Random.Range(-5f, 5f), 0);

        yield return new WaitForSeconds(2);

        if(ScoreManager.score <= 10)
        {
            StartCoroutine(SpawnOneTarget());
        }
        else
        {
            StopCorountine(SpawnOneTarget());
        }
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.gameObject.GetComponent<AudioSource>().Play(0);
        }
    }


}
