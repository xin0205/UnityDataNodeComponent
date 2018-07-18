using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace UnityGameFramework
{
    public static class UGFDataNode
    {
        private static DataNodeComponent component;

        public static DataNodeComponent Component
        {
            get
            {
                return component;
            }

            set
            {
                component = value;
            }
        }
    }

}
