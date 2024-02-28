//using System.Collections;
//using UnityEngine;

//public class RayShooter : MonoBehaviour
//{
//    private Camera _camera;

//    private void Start()
//    {   // Access other component attahced to the same object.
//        _camera = GetComponent<Camera>();
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (Input.GetMouseButtonDown(0) && EventSystem.current.IsPointerOverGameObject()) // mouse button & not using GUI
//        {
//            Vector3 point = new Vector3(_camera.pixelWidth / 2, _camera.pixelHeight / 2, 0);
//            Ray ray = _camera.ScreenPointToRay(point); // create ray at mouse position
//            RaycastHit hit;
//            if (Physics.Raycast(ray, out hit)) // reference info
//            {
//                Debug.Log("Hit " + hit.point); // coordinates
//            }
//        } 
//    }
//}
