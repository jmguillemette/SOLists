using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _Project{
    public class DataListDisplayBehaviour : MonoBehaviour{

        [SerializeField]
        private DataListScriptableObject dataList;

        [SerializeField] private Button buttonPrefab;
        
        private void OnEnable(){
            foreach (DataItemScriptableObject data in dataList.DataList){
                Button button = GameObject.Instantiate(buttonPrefab);
                TMP_Text text = button.GetComponentInChildren<TMP_Text>();
                text.text = ""+data.value;
                button.gameObject.transform.parent = transform;

            }
        }
    }
}