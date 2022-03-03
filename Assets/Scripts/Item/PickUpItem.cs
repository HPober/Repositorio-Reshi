using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public Transform player;
    [SerializeField] float speed = 7;
    [SerializeField] float pickUpDistance = 1f;

    // Start is called before the first frame update
    void Start()
    {
        player = Player.Instance.player.transform;
        //player = Player.Instance.GetComponent<Player>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(pick());
    }

    IEnumerator pick()
    {
        yield return new WaitForSeconds(1.5f);
        agarrar();
    }

    public void agarrar()
    {
        float distance = Vector3.Distance(transform.position, player.position);
        if (distance > pickUpDistance)
        {
            return;
        }
        transform.position = Vector3.MoveTowards(
            transform.position,
            player.position,
            speed * Time.deltaTime
            );
    }

}
