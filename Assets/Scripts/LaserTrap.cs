using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTrap : MonoBehaviour
{
    [SerializeField]
    private float minInterval = 3f;
    [SerializeField]
    private float maxInterval = 10f;

    float runningTime = 1.5f;
    private float timerRange;
    float speed = 5f;

    public GameObject laserBeamPrefab;
    public GameObject laserTrapPrefab;

    Vector3[] laserTrapPositions = new Vector3[4];

    // Start is called before the first frame update
    void Start()
    {
        laserTrapPositions[0] = new Vector3(-1.5f, 1.5f, 0f);
        laserTrapPositions[1] = new Vector3(1.5f, -1.5f, 0f);
        laserTrapPositions[2] = new Vector3(-1.5f, -1.5f, 0f);
        laserTrapPositions[3] = new Vector3(1.5f, 1.5f, 0f);

        for (int i = 0; i < laserTrapPositions.Length; i++)
        {
            GameObject instantiateLaserTrap = Instantiate(laserTrapPrefab, laserTrapPositions[i], Quaternion.identity);
        }

        timerRange = Random.Range(minInterval, maxInterval);
        LaserShoot();
    }

    public void LaserShoot()
    {
        Instantiate(laserBeamPrefab, transform.position, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
        
    }
}