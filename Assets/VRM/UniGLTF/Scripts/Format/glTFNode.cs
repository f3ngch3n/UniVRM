﻿using System;
using System.Linq;
using UniJSON;

namespace UniGLTF
{
    [Serializable]
    public class glTFNode
    {
        // TODO: need an empty string?
        public string name;

        [JsonSchema(MinItems = 1)]
        [ItemJsonSchema(Minimum = 0)]
        public int[] children;

        [JsonSchema(MinItems = 16, MaxItems = 16)]
        public float[] matrix;

        [JsonSchema(MinItems = 3, MaxItems = 3)]
        public float[] translation;

        [JsonSchema(MinItems = 4, MaxItems = 4)]
        [ItemJsonSchema(Minimum = -1.0, Maximum = 1.0)]
        public float[] rotation;

        [JsonSchema(MinItems = 3, MaxItems = 3)]
        public float[] scale;

        [JsonSchema(Minimum = 0, ExplicitIgnorableValue = -1)]
        public int mesh = -1;

        [JsonSchema(Dependencies = new string[] { "mesh" }, Minimum = 0, ExplicitIgnorableValue = -1)]
        public int skin = -1;

        [JsonSchema(Dependencies = new string[] { "mesh" }, MinItems = 1)]
        public float[] weights;

        [JsonSchema(Minimum = 0, ExplicitIgnorableValue = -1)]
        public int camera = -1;

        // empty schemas
        public glTFNode_extensions extensions;

        public glTFNode_extra extras = new glTFNode_extra();
    }
}
