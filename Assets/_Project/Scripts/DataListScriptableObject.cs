using System.Collections.Generic;
using UnityEngine;

namespace _Project{
    [CreateAssetMenu(fileName = "DataList", menuName = "Wind Powered Games/Demo/DataList")]
    public class DataListScriptableObject : ScriptableObject{

        [SerializeField]
        private List<DataItemScriptableObject> dataList;


        public List<DataItemScriptableObject> DataList{
            get => dataList;
            set => dataList = value;
        }
    }
}