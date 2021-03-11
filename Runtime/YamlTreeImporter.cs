using UnityEngine;

namespace Elysium.ProgressTree.Yaml
{
    public class YamlTreeImporter : TreeImporter
    {
        protected override void Import() => ProgressTree = ProgressTree.Create().FromYaml(nodeElementDatabase.ElementsAsInterface, dependencyDatabase.ElementsAsInterface, importedTextAsset);

        protected override bool IsValidFormat()
        {
            // TODO: CHECK IF ITS A VALID YAML FILE
            return true;
        }
    }
}