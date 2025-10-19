using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class lerp : MonoBehaviour
{
    [SerializeField] Vector3 startPosition;
    [SerializeField] Vector3 endPosition;
    [SerializeField] float moveDuration = 1.0f; 
    

    void Start()
    {
        startPosition = transform.position;
        endPosition = new Vector3(10, 3, 0);
    }

    void Update()
    {
        float t = Mathf.PingPong(Time.time, moveDuration) / moveDuration; // gets movement value using PingPong math 

        transform.position = Vector3.Lerp(startPosition, endPosition, t); // lerp using pingpong value for t
    }













    /*   thisis theworking lerp  codde  unlooped
     *   
    //    [SerializeField] Vector3 startPosition;
    //    [SerializeField] Vector3 endPosition;
    //    [SerializeField] Vector3 currentTarget;
    //    [SerializeField] float moveDuration = 1.0f; // Time in seconds
    //    [SerializeField] float elapsedTime;
    //    bool movingToEnd = true;

    //    void Start()
    //    {
    //        startPosition = transform.position;
    //        endPosition = new Vector3(10, 3, 0);
    //        currentTarget = endPosition;
    //    }

    //    void Update()
    //    {

    //        elapsedTime += Time.deltaTime;
    //        float t = elapsedTime / moveDuration;
    //        transform.position = Vector3.Lerp(startPosition, endPosition, t);

    //    }
    *
    */

}



//tried using this code based on a tutorial once i got the lerp working but it kept changing thetranslation to +-y3 rather than 10 X trying a different method  above

//using UnityEngine;

//public class LerpLooping : MonoBehaviour
//{
//    [SerializeField] Vector3 startPosition;
//    [SerializeField] Vector3 endPosition;
//    [SerializeField] Vector3 currentTarget;
//    [SerializeField] float elapsedTime;
//    [SerializeField] float moveDuration = 1.0f; // Time to destination
//    [SerializeField] bool movingToEnd = true;



//    void Start()
//    {
//        startPosition = new Vector3(10, 0, 0);
//        endPosition = new Vector3(10, 3, 0);
//        currentTarget = endPosition;
//    }

//    void Update()
//    {
//        elapsedTime += Time.deltaTime;
//        float t = elapsedTime / moveDuration;

//        if (movingToEnd) // Apply Lerp towards current destination
//        {
//            transform.position = Vector3.Lerp(startPosition, endPosition, t);
//        }
//        else
//        {
//            transform.position = Vector3.Lerp(endPosition, startPosition, t);
//        }
//        if (t >= 1.0f) // if path complete reset timer and reverse direction
//        {

//            elapsedTime = 0;
//            movingToEnd = !movingToEnd;
//        }
//    }
//}
