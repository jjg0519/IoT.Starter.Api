/*
 * home-api
 *
 * The API for the Home Starter project
 *
 * OpenAPI spec version: 1.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.SwaggerGen.Annotations;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class EnvironmentApiController : Controller
    { 

        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="days"></param>
        /// <response code="200">the forecast</response>
        [HttpGet]
        [Route("/josemottalopes/home-api/1.0.1/temperature/forecast/{days}")]
        [SwaggerOperation("GetForecast")]
        [SwaggerResponse(200, type: typeof(ForecastResponse))]
        public virtual IActionResult GetForecast([FromRoute]int? days)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ForecastResponse>(exampleJson)
            : default(ForecastResponse);
            return new ObjectResult(example);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <remarks>gets the state of the heater</remarks>
        /// <param name="zoneId"></param>
        /// <response code="200">heater state</response>
        [HttpGet]
        [Route("/josemottalopes/home-api/1.0.1/temperature/{zoneId}/heater")]
        [SwaggerOperation("GetHeaterState")]
        [SwaggerResponse(200, type: typeof(HeaterState))]
        public virtual IActionResult GetHeaterState([FromRoute]string zoneId)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<HeaterState>(exampleJson)
            : default(HeaterState);
            return new ObjectResult(example);
        }


        /// <summary>
        /// 
        /// </summary>
        
        /// <param name="zoneId"></param>
        /// <response code="200">Zone temperature</response>
        [HttpGet]
        [Route("/josemottalopes/home-api/1.0.1/temperature/{zoneId}")]
        [SwaggerOperation("GetZoneTemperature")]
        [SwaggerResponse(200, type: typeof(TemperatueZoneStatus))]
        public virtual IActionResult GetZoneTemperature([FromRoute]string zoneId)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<TemperatueZoneStatus>(exampleJson)
            : default(TemperatueZoneStatus);
            return new ObjectResult(example);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <remarks>turns the heater on or off</remarks>
        /// <param name="zoneId"></param>
        /// <param name="state"></param>
        /// <response code="200">Status of the operation</response>
        [HttpPost]
        [Route("/josemottalopes/home-api/1.0.1/temperature/{zoneId}/heater/{state}")]
        [SwaggerOperation("SetHeaterState")]
        [SwaggerResponse(200, type: typeof(ApiResponse))]
        public virtual IActionResult SetHeaterState([FromRoute]string zoneId, [FromRoute]string state)
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<ApiResponse>(exampleJson)
            : default(ApiResponse);
            return new ObjectResult(example);
        }


        /// <summary>
        /// 
        /// </summary>
        
        /// <response code="200">ok</response>
        [HttpGet]
        [Route("/josemottalopes/home-api/1.0.1/temperature")]
        [SwaggerOperation("TemperatureSummary")]
        [SwaggerResponse(200, type: typeof(TemperatureSummary))]
        public virtual IActionResult TemperatureSummary()
        { 
            string exampleJson = null;
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<TemperatureSummary>(exampleJson)
            : default(TemperatureSummary);
            return new ObjectResult(example);
        }
    }
}