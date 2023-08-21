using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallChainAttack : MonoBehaviour
{

    [SerializeField] private GameObject BallAttack;

    [SerializeField] private Transform playerTransform;


    [SerializeField] private Vector3Variable playerPos;

    [SerializeField] private SpriteRenderer playerSpriteRenderer;

    private GameObject ball;


    private LineRenderer lr;


    private Vector3[] points = new Vector3[2];

    private SpringJoint2D ballSpringJoint;

    private void Start()
    {
        ball = Instantiate(BallAttack, transform.position, Quaternion.identity);
        lr = ball.GetComponent<LineRenderer>();
        ballSpringJoint = ball.GetComponent<SpringJoint2D>();
        lr.startColor = playerSpriteRenderer.color;
        lr.endColor = BallAttack.GetComponent<SpriteRenderer>().color;

    }

    private void Update()
    {
        ballSpringJoint.connectedAnchor = playerTransform.position;

        points[0] = playerPos.Value;
        points[1] = ball.transform.position;
        lr.SetPositions(points);
    }

}
