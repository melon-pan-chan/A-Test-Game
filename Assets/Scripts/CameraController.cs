using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField, Tooltip("The player character to follow.")]
    GameObject playerCharacter;

    [SerializeField, Tooltip("The amount the camera's movement speed should be offset.")]
    float speedOffset;

    [SerializeField, Tooltip("The amount the camera's position should be offset.")]
    Vector2 positionOffset;

    [SerializeField, Tooltip("The amount the camera should pan downwards while crouching.")]
    float crouchDistance;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Camera's current position
        Vector3 startPosition = transform.position;
        //Player's current position
        Vector3 endPosition = playerCharacter.transform.position;
        endPosition.x += positionOffset.x;
        endPosition.y += positionOffset.y;
        endPosition.z = -10;

        Vector3 crouchPosition = endPosition;
        crouchPosition.y -= crouchDistance;


        //Lerp implementation
        //Also a crouch mechanic.
        if (Input.GetKey("s") || Input.GetKey("down"))
        {
            transform.position = Vector3.Lerp(startPosition, crouchPosition, speedOffset * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.Lerp(startPosition, endPosition, speedOffset * Time.deltaTime);
        }

        //No Lerp/Smooth damping implementation
        //transform.position = new Vector3(playerCharacter.transform.position.x, playerCharacter.transform.position.y, -10);
    }
}
