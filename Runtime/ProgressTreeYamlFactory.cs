using Elysium.ProgressTree.Json;
using Elysium.ProgressTree.Yaml;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Elysium.ProgressTree
{
    public partial class ProgressTree
    {
        public static ProgressTree FromYaml(INodeElement[] _allNodeElements, INodeElement[] _allDependencies, TextAsset _yaml)
        {
            Debug.Log($"Building progressTree from YAML:\n{_yaml.text}");

            ITreeRequirement[] requirements = YamlRequirementCollection.FromYaml(_yaml.text);
            return new ProgressTree(_allNodeElements, _allDependencies, requirements);
        }
    }
}