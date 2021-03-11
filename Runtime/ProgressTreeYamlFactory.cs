using UnityEngine;

namespace Elysium.ProgressTree.Yaml
{
    public static class ProgressTreeFactoryYamlExtension
    {
        public static ProgressTree FromYaml(this ProgressTree _tree, INodeElement[] _allNodeElements, INodeElement[] _allDependencies, TextAsset _yaml)
        {
            Debug.Log($"Building progressTree from YAML:\n{_yaml.text}");
            ITreeRequirement[] requirements = YamlRequirementCollection.FromYaml(_yaml.text);
            _tree.Build(_allNodeElements, _allDependencies, requirements);
            return _tree;
        }
    }
}