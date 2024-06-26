using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class object_manager : MonoBehaviour
{
    public GameObject[] cubes;
    public int currentIndex = -1;

    // Start is called before the first frame update
    void Start()
    {
        DeactivateALL();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ActivateALL();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            DeactivateALL();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (currentIndex < cubes.Length)
            {
                DeactivateALL();
                AcivateByIndex(currentIndex);
                currentIndex++;
            }
            else
            {
                currentIndex = 0;
                DeactivateALL();
                AcivateByIndex(currentIndex);
                currentIndex++;
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            DeactivateALL();
            AcivateByIndex(currentIndex);
            currentIndex--;
        }
        if (currentIndex >= 0)
        {

            DeactivateALL();
            AcivateByIndex(currentIndex);

        }
        else
        {
            currentIndex = cubes.Length - 1;
            DeactivateALL();
            AcivateByIndex(currentIndex);

        }

    }
    void DeactivateALL()
    {
        for (int i = 0; i < cubes.Length; i++)
            cubes[i].SetActive(false);
    }
    void ActivateALL()
    {
        for (int i = 0; i < cubes.Length; i++)
            cubes[i].SetActive(true);
    }

    void AcivateByIndex(int index)
    {
        cubes[index].SetActive(true);
    }


}
