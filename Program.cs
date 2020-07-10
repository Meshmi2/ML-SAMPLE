using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ML_SampleML.Model;

namespace ML_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add input data
            var input = new ModelInput();

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
        }
    }
}
