using UnityEngine;

public class ClicknDrag : MonoBehaviour
{
    public Rigidbody2D selectedObject;
    Vector3 offset;
    Vector3 mousePosition;
    public float maxSpeed = 10;
    Vector2 mouseForce;
    Vector3 lastPosition;
    void Update()
    {
        try
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (selectedObject)
            {
                mouseForce = (mousePosition - lastPosition) / Time.deltaTime;
                mouseForce = Vector2.ClampMagnitude(mouseForce, maxSpeed);
                lastPosition = mousePosition;
            }
            if (Input.GetMouseButtonDown(0))
            {
                Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);

                if (targetObject.transform.name != "Ball")
                {
                    selectedObject = targetObject.transform.gameObject.GetComponent<Rigidbody2D>();
                    offset = selectedObject.transform.position - mousePosition;
                }

            }

            if (Input.GetMouseButtonUp(0) && selectedObject)
            {
                selectedObject.velocity = Vector2.zero;
                selectedObject.AddForce(mouseForce, ForceMode2D.Impulse);
                selectedObject = null;
            }


        }
        catch
        {
            ;
        }
        
    }
    void FixedUpdate()
    {
        if (selectedObject)
        {
            selectedObject.MovePosition(mousePosition + offset);
        }
    }
}