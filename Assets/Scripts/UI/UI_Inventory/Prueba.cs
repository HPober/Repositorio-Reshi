using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Prueba : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject Uno;
    public GameObject Uno1;
    public GameObject Uno2;
    public GameObject Uno3;
    public GameObject Uno4;
    public GameObject Uno5;
    public GameObject Uno6;
    public GameObject Uno7;
    public GameObject Uno8;
    public GameObject Uno9;
    public GameObject Uno10;
    public GameObject Uno11;

    public Image Imagen;
    public Image Imagen1;
    public Image Imagen2;
    public Image Imagen3;
    public Image Imagen4;
    public Image Imagen5;
    public Image Imagen6;
    public Image Imagen7;
    public Image Imagen8;
    public Image Imagen9;
    public Image Imagen10;
    public Image Imagen11;

    int selectedTool = 0;
    int toolbarSize = 13;

    // Start is called before the first frame update
    void Start()
    {
        #region
        Uno.GetComponent<UIInventorySlots>();
        Uno.GetComponent<UIInventorySlots>();
        Uno1.GetComponent<UIInventorySlots>();
        Uno2.GetComponent<UIInventorySlots>();
        Uno3.GetComponent<UIInventorySlots>();
        Uno4.GetComponent<UIInventorySlots>();
        Uno5.GetComponent<UIInventorySlots>();
        Uno6.GetComponent<UIInventorySlots>();
        Uno7.GetComponent<UIInventorySlots>();
        Uno8.GetComponent<UIInventorySlots>();
        Uno9.GetComponent<UIInventorySlots>();
        Uno10.GetComponent<UIInventorySlots>();
        Uno11.GetComponent<UIInventorySlots>();
        #endregion
        Imagen.gameObject.GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
        #region
        float delta = Input.mouseScrollDelta.y;
        if (delta != 0)
        {
            if (delta > 0)
            {
                selectedTool += 1;
                selectedTool = (selectedTool >= toolbarSize ? 0 : selectedTool);
                Debug.Log(selectedTool);

            }
            else
            {
                selectedTool -= 1;
                selectedTool = (selectedTool < 0 ? toolbarSize - 1 : selectedTool);
                Debug.Log(selectedTool);
            }
        }
        #endregion

        if (selectedTool == 1 && Hola == true)
        {
            Uno.gameObject.GetComponent<UIInventorySlots>().enabled = true;
            Imagen.gameObject.GetComponent<Image>().enabled = true;
        }
        else
        {
            Uno.gameObject.GetComponent<UIInventorySlots>().enabled = false;
            Imagen.gameObject.GetComponent<Image>().enabled = false;
            Hola = false;
            
        }

        if (selectedTool == 2)
        {
            Uno1.gameObject.GetComponent<UIInventorySlots>().enabled = true;
            Imagen1.gameObject.GetComponent<Image>().enabled = true;
        }
        else
        {
            Uno1.gameObject.GetComponent<UIInventorySlots>().enabled = false;
            Imagen1.gameObject.GetComponent<Image>().enabled = false;

        }

        if (selectedTool == 3)
        {
            Uno2.gameObject.GetComponent<UIInventorySlots>().enabled = true;
            Imagen2.gameObject.GetComponent<Image>().enabled = true;
        }
        else
        {
            Uno2.gameObject.GetComponent<UIInventorySlots>().enabled = false;
            Imagen2.gameObject.GetComponent<Image>().enabled = false;

        }

        if (selectedTool == 4)
        {
            Uno3.gameObject.GetComponent<UIInventorySlots>().enabled = true;
            Imagen3.gameObject.GetComponent<Image>().enabled = true;
        }
        else
        {
            Uno3.gameObject.GetComponent<UIInventorySlots>().enabled = false;
            Imagen3.gameObject.GetComponent<Image>().enabled = false;

        }

        if (selectedTool == 5)
        {
            Uno4.gameObject.GetComponent<UIInventorySlots>().enabled = true;
            Imagen4.gameObject.GetComponent<Image>().enabled = true;
        }
        else
        {
            Uno4.gameObject.GetComponent<UIInventorySlots>().enabled = false;
            Imagen4.gameObject.GetComponent<Image>().enabled = false;

        }

        if (selectedTool == 6)
        {
            Uno5.gameObject.GetComponent<UIInventorySlots>().enabled = true;
            Imagen5.gameObject.GetComponent<Image>().enabled = true;
        }
        else
        {
            Uno5.gameObject.GetComponent<UIInventorySlots>().enabled = false;
            Imagen5.gameObject.GetComponent<Image>().enabled = false;

        }

        if (selectedTool == 7)
        {
            Uno6.gameObject.GetComponent<UIInventorySlots>().enabled = true;
            Imagen6.gameObject.GetComponent<Image>().enabled = true;
        }
        else
        {
            Uno6.gameObject.GetComponent<UIInventorySlots>().enabled = false;
            Imagen6.gameObject.GetComponent<Image>().enabled = false;

        }

        if (selectedTool == 8)
        {
            Uno7.gameObject.GetComponent<UIInventorySlots>().enabled = true;
            Imagen7.gameObject.GetComponent<Image>().enabled = true;
        }
        else
        {
            Uno7.gameObject.GetComponent<UIInventorySlots>().enabled = false;
            Imagen7.gameObject.GetComponent<Image>().enabled = false;

        }

        if (selectedTool == 9)
        {
            Uno8.gameObject.GetComponent<UIInventorySlots>().enabled = true;
            Imagen8.gameObject.GetComponent<Image>().enabled = true;
        }
        else
        {
            Uno8.gameObject.GetComponent<UIInventorySlots>().enabled = false;
            Imagen8.gameObject.GetComponent<Image>().enabled = false;

        }

        if (selectedTool == 10)
        {
            Uno9.gameObject.GetComponent<UIInventorySlots>().enabled = true;
            Imagen9.gameObject.GetComponent<Image>().enabled = true;
        }
        else
        {
            Uno9.gameObject.GetComponent<UIInventorySlots>().enabled = false;
            Imagen9.gameObject.GetComponent<Image>().enabled = false;

        }

        if (selectedTool == 11)
        {
            Uno10.gameObject.GetComponent<UIInventorySlots>().enabled = true;
            Imagen10.gameObject.GetComponent<Image>().enabled = true;
        }
        else
        {
            Uno10.gameObject.GetComponent<UIInventorySlots>().enabled = false;
            Imagen10.gameObject.GetComponent<Image>().enabled = false;

        }

        if (selectedTool == 12)
        {
            Uno11.gameObject.GetComponent<UIInventorySlots>().enabled = true;
            Imagen11.gameObject.GetComponent<Image>().enabled = true;
        }
        else
        {
            Uno11.gameObject.GetComponent<UIInventorySlots>().enabled = false;
            Imagen11.gameObject.GetComponent<Image>().enabled = false;

        }



    }

    bool Hola;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Hola = true;

        
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Hola = false;
    }

}
