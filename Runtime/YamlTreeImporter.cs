using UnityEngine;

namespace Elysium.ProgressTree.Yaml
{
    public class YamlTreeImporter : TreeImporter
    {
        protected override void Import()
        {
            ProgressTree = ProgressTree
                .Create(nodeElementDatabase.ElementsAsInterface, dependencyDatabase.ElementsAsInterface)
                .FromYaml(importedTextAsset);
        }

        protected override bool IsValidFormat()
        {
            // TODO: CHECK IF ITS A VALID YAML FILE
            return true;
        }
    }
}