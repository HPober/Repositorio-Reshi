using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class SceneTeleportKey : MonoBehaviour
{
    [SerializeField] private SceneName sceneNameGotoQ = SceneName.Scene1_Farm;
    [SerializeField] private Vector3 scenePositionGotoQ = new Vector3();

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (Input.GetMouseButton(0))
        {

            Player player = collision.GetComponent<Player>();

            if (player != null)
            {
                //Calculate Player Position

                float xPosition = Mathf.Approximately(scenePositionGotoQ.x, 0f) ? player.transform.position.x : scenePositionGotoQ.x;

                float yPosition = Mathf.Approximately(scenePositionGotoQ.y, 0f) ? player.transform.position.y : scenePositionGotoQ.y;

                float zPosition = 0f;

                SceneControllerManager.Instance.FadeAndLoadScene(sceneNameGotoQ.ToString(), new Vector3(xPosition, yPosition, zPosition));
            }

        }
    }
}
