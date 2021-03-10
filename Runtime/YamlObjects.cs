using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using YamlDotNet.Serialization;

namespace Elysium.ProgressTree.Yaml
{
    [System.Serializable]
    public struct YamlRequirementCollection
    {
        public YamlRequirement[] requirements { get; set; }

        public static ITreeRequirement[] FromYaml(string _yaml)
        {
            var deserializer = new DeserializerBuilder().Build();
            return deserializer.Deserialize<YamlRequirementCollection>(_yaml).requirements.Cast<ITreeRequirement>().ToArray();
        }
    }

    [System.Serializable]
    public struct YamlRequirement : ITreeRequirement
    {
        public string name { get; set; }
        public int cost { get; set; }
        public Dictionary<string, int> dependencies { get; set; }
        // public YamlDependency[] dependencies { get; set; }

        public string Name => name;
        public int Cost => cost;
        public Dictionary<string, int> Dependencies => dependencies;// dependencies.ToDictionary(x => x.name, x => x.level);
    }

    [System.Serializable]
    public struct YamlDependency
    {
        public string name { get; set; }
        public int level { get; set; }
    }
}

