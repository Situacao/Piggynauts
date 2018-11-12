using UnityEngine;

public class TestSceneLauncher : MonoBehaviour
{
    [SerializeField]
    private GameObject PiggyPrefab;

    void Start()
    {
        SetupScene();
    }

    void SetupScene()
    {
        // Instantiate GameObjects
        GameObject instPrefab = Instantiate(PiggyPrefab);
        instPrefab.transform.position = Vector3.zero;
        instPrefab.name = "Piggynaut_P1";

        // Setup Controllers
        ControllerMatch ctrl = instPrefab.AddComponent<ControllerMatch>();
        ctrl.Setup(0);
    }


}
