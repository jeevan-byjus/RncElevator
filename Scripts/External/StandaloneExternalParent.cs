﻿using Byjus.VisionTest.Verticals;
using UnityEngine;

#if CC_STANDALONE
namespace Byjus.VisionTest.Externals {
    public class StandaloneExternalParent : MonoBehaviour {
        public HierarchyManager hierarchyManager;

        void AssignRefs() {
            hierarchyManager = FindObjectOfType<HierarchyManager>();
        }

        private void Start() {
            AssignRefs();
            Factory.Init();
            hierarchyManager.Setup();
        }
    }
}
#endif