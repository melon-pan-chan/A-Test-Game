using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformController : MonoBehaviour
{
    //Vector holding the origin point of the platform
    Vector3 home;


    //TODO: Implement a way to select whether the plaform moves horizontally or vertically

    /* Enum signalling what stage of movement the platform is in:
        0. Home to left
        1. Left to home
        2. Home to right
        3. Right to home
    */
    public enum MovementState
    {
        HOME_TO_LEFT,
        LEFT_TO_HOME,
        HOME_TO_RIGHT,
        RIGHT_TO_HOME
    }

    //Instance of the afformentioned MovementState enum
    [SerializeField, Tooltip("Enum signalling what stage of movement the platform is in")]
    MovementState currentMovement;

    // Start is called before the first frame update
    void Start()
    {
        home = transform.position;
        currentMovement = MovementState.HOME_TO_LEFT;
    }

    // Update is called once per frame
    void Update()
    {
        //Initializing initial position and target position
        Vector3 startPosition = transform.position;
        Vector3 endPosition = Vector3.forward; //just a placeholder 

        //Checking whether the 

        //Checking the current movement state so that the appropriate endPosition can be assigned
        //TODO: Find a way to set the endPosition once and only change it once the movement state changes.
        switch (currentMovement)
        {
            case (MovementState.HOME_TO_LEFT):
                endPosition = new Vector3(startPosition.x - 1, startPosition.y, startPosition.z);
                break;
            case (MovementState.LEFT_TO_HOME):
                endPosition = new Vector3(startPosition.x + 1, startPosition.y, startPosition.z);
                break;
            case (MovementState.HOME_TO_RIGHT):
                endPosition = new Vector3(startPosition.x + 1, startPosition.y, startPosition.z);
                break;
            case (MovementState.RIGHT_TO_HOME):
                endPosition = new Vector3(startPosition.x - 1, startPosition.y, startPosition.z);
                break;
        }
        transform.position = Vector3.Lerp(startPosition, endPosition, Time.deltaTime);
    }
}
