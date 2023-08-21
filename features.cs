using CosmosKernel1.FileMethods;
using CosmosKernel1.GeneralMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CosmosKernel1
{
    public class features
    {
        public FileManager fileManager = new FileManager();
        public GeneralManager generalManager = new GeneralManager();
        public string[] FeaturesList()
        {
            string[] features = fileManager.FileFeatures.Concat(generalManager.GeneralFeatures).ToArray();
            return features;
            
        }
    }
}
