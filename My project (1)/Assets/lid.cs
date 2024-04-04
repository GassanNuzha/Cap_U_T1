using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lid : MonoBehaviour
{
    public float interactionDistance;
    public GameObject intText;
    public string lidOpenAnimName, lidCloseAnimName;


    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactionDistance))
        {
            if (hit.collider.gameObject.tag == "lid")
            {
                GameObject Spin_Coating_Station_Lid = hit.collider.transform.root.gameObject;
                Animator lidAnim = Spin_Coating_Station_Lid.GetComponent<Animator>();
                intText.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (lidAnim.GetCurrentAnimatorStateInfo(0).IsName(lidOpenAnimName))
                    {
                        lidAnim.ResetTrigger("open");
                        lidAnim.SetTrigger("close");
                    }
                }
                if (lidAnim.GetCurrentAnimatorStateInfo(0).IsName(lidCloseAnimName))
                {
                    lidAnim.ResetTrigger("close");
                    lidAnim.SetTrigger("open");
                }
            }
        }
        else
        {
            intText.SetActive(false);
                }
    
            }
        }

