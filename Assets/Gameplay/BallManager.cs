using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public Transform spawnArea;
    public int maxBallAmount;
    public Vector3 ballAreaMin;
    public Vector3 ballAreaMax;

    public List<GameObject> ballTemplateList;
    private List<GameObject> ballList;

    private List<float> xposition;
    private List<float> yposition;
    private List<float> zposition;
    private int xlength;
    private int ylength;
    private int zlength;
    private int xrandomed;
    private int yrandomed;
    private int zrandomed;

    public int spawnInterval;
    private float timer;

    void Start()
    {
        ballList = new List<GameObject>();
        timer = 0;
        xposition = new List<float> {ballAreaMin.x, ballAreaMax.x};
        xlength = xposition.Count;
        yposition = new List<float> {ballAreaMin.y, ballAreaMax.y};
        ylength = yposition.Count;
        zposition = new List<float> {ballAreaMin.z, ballAreaMax.z};
        zlength = zposition.Count;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > spawnInterval)
        {
            xrandomed = Random.Range(0, xlength);
            yrandomed = Random.Range(0, ylength);
            zrandomed = Random.Range(0, zlength);
            GenerateBallRandom();
            timer -= spawnInterval;
        }
    }

    public void GenerateBallRandom()
    {
        GenerateBallRandom(new Vector3(xposition[xrandomed], yposition[yrandomed], zposition[zrandomed]));
    }

    public void GenerateBallRandom(Vector3 position)
    {
        if (ballList.Count >= maxBallAmount)
        {
            return;
        }

        //if (position.x < ballAreaMin.x ||
        //    position.x > ballAreaMax.x ||
        //    position.y < ballAreaMin.y ||
        //    position.y > ballAreaMax.y ||
        //    position.z < ballAreaMin.z ||
        //    position.z > ballAreaMax.z)
        //{
        //    return;
        //}

        int randomIndex = Random.Range(0, ballTemplateList.Count);

        GameObject theBall = Instantiate(ballTemplateList[randomIndex], new Vector3(position.x, position.y, position.z), Quaternion.identity, spawnArea);
        if (theBall.transform.position.x > 0)
        {
            theBall.GetComponent<BallController>().speed.x = Random.Range(3, 10) * -1;
        }
        if (theBall.transform.position.x < 0)
        {
            theBall.GetComponent<BallController>().speed.x = Random.Range(3, 10) * 1;
        }
        if (theBall.transform.position.z > 0)
        {
            theBall.GetComponent<BallController>().speed.z = Random.Range(3, 10) * -1;
        }
        if (theBall.transform.position.z < 0)
        {
            theBall.GetComponent<BallController>().speed.z = Random.Range(3, 10) * 1;
        }
        theBall.SetActive(true);

        ballList.Add(theBall);
    }

    public void RemoveBall(GameObject theBall)
    {
        ballList.Remove(theBall);
        Destroy(theBall);
    }

    public void RemoveAllBall()
    {
        while (ballList.Count > 0)
        {
            RemoveBall(ballList[0]);
        }
    }

}
