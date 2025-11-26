using UnityEngine;

public class FloatingLabelSpawner : MonoBehaviour
{
    public GameObject labelPrefab;
    public string labelText = "Label";

    void Start()
    {
        CreateLabel();
    }

    void CreateLabel()
    {
        GameObject label = Instantiate(labelPrefab, transform.position + Vector3.up * 0.2f, Quaternion.identity);
        label.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = labelText;
        label.AddComponent<FacePlayer>();
    }
}
