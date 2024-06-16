using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlaceObjectOnPlane : MonoBehaviour
{
    public GameObject objectToPlace;
    private GameObject spawnedObject;
    private ARRaycastManager arRaycastManager;
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();

    void Start()
    {
        arRaycastManager = GetComponent<ARRaycastManager>();
    }

    void Update()
    {
        if (spawnedObject == null && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (arRaycastManager.Raycast(Input.GetTouch(0).position, hits, TrackableType.PlaneWithinPolygon))
            {
                Pose hitPose = hits[0].pose;
                spawnedObject = Instantiate(objectToPlace, hitPose.position, hitPose.rotation);
            }
        }
    }
}
