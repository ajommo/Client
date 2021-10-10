using UnityEngine;

public class InstanceManager : MonoBehaviour
{
    void Start()
    {
        var bundle = AssetBundle.LoadFromFile(@"C:\Game\Bundles\terrains");
        var prefab = bundle.LoadAsset<GameObject>("Terrain0001");
        Instantiate(prefab);
    }
}
