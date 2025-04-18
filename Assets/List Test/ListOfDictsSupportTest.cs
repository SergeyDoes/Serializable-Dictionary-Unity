using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project.Tools.DictionaryHelp.Test
{
    public class ListOfDictsSupportTest : MonoBehaviour
    {
        [SerializeField]
        private SerializableDictionary<string, int> dictA, dictB;

        [SerializeField]
        private List<SerializableDictionary<string, int>> list;
    }
}