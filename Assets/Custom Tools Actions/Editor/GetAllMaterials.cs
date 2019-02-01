using System.Collections.Generic;
using UnityEngine;
using PiXYZ.Plugin.Unity.Tools;

public class GetAllMaterials : ActionOut<IList<Material>> {

    [UserParameter]
    public float aFloatParameter = 1f;

    public override int id { get { return 21616052;} }
    public override string menuPathRuleEngine { get { return "Custom/Get All Materials"; } }
    public override string menuPathToolbox { get { return "Custom/Get All Materials";} }
    public override string tooltip { get { return "A Custom Action";} }

    public override IList<Material> run() {
        /// Your code here
        return null;
    }
}