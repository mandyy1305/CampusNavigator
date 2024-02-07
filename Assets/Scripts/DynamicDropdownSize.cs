using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class DynamicDropdownSize : MonoBehaviour
{
    public RectTransform dropdownRect;

    private void Update()
    {
        var obj = transform.Find("Dropdown List");
        if (obj != null)
        {
            dropdownRect = obj.GetComponent<RectTransform>();
            dropdownRect.sizeDelta = new(dropdownRect.sizeDelta.x, 800f);
        }
    }
}
