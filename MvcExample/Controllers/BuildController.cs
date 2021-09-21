using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MvcExampleML.Model;

namespace MvcExample.Controllers
{
    public class BuildController
    {
        // Add input data
        var input = new ModelInput();

        // Load model and predict output of sample data
        ModelOutput result = ConsumeModel.Predict(input);

    }
}
