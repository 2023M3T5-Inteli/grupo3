using System.Collections;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Python.Runtime;

namespace predicitiveApi.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class PredictController : ControllerBase
    {
        [HttpPost]
        public IActionResult Predict([FromBody] Dictionary<string, int> Features)
        {
            using(Py.GIL())
            {
              dynamic archive = Py.import("modelo.pkl");
              dynamic model = archive.load(File.OpenRead("caminho/arquivo"));
            //   dynamic input = new PyDict();

            // // pegando inputs
            //   input["input1"] = userInput.Input1;
            //   input["input2"] = userInput.Input2;
              dynamic input = Features; 

              // cálculo da predição
              dynamic output = model.predict(input);

              return Ok(output);
            }

        }
    }

