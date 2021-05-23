using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[SelectionBase]
public class LandScript : MonoBehaviour
{
    [Header("Sector Affinity % based")]
    [SerializeField] [Range(0, 100)] float agricultureAffinity;
    [SerializeField] [Range(0, 100)] float industryAffinity;
    [SerializeField] [Range(0, 100)] float tourismAffinity;
    [SerializeField] [Range(0, 100)] float livestockAffinity;

    int gridSize = 10;

    /*

    [SerializeField] SectorAffinity[] sectorAffinity;


    [System.Serializable]
    private class SectorAffinity
    {
        public Sectors sector;
        [Range(0,100)]
        public float affinity;
    }
    */

    // Start is called before the first frame update


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SnapToGrid();
    }

    private void SnapToGrid()
    {
        //  int gridSize = wayPoint.GetGridSize();
       

        transform.position = new Vector3(Mathf.RoundToInt(transform.position.x / gridSize) * gridSize,
            0f,
            Mathf.RoundToInt(transform.position.z / gridSize) * gridSize);

    }

  

}
