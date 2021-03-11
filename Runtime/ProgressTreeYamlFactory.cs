using UnityEngine;

namespace Elysium.ProgressTree.Yaml
{
    public static class ProgressTreeFactoryYamlExtension
    {
        public static ProgressTree FromYaml(this ProgressTree _tree, TextAsset _yaml)
        {
            Debug.Log($"Building progressTree from YAML:\n{_yaml.text}");
            ITreeRequirement[] requirements = YamlRequirementCollection.FromYaml(_yaml.text);
            _tree.Build(requirements);
            return _tree;
        }
    }
}