/*
 * Swagger Petstore
 *
 * This is a sample Petstore server.  You can find out more about Swagger at [http://swagger.io](http://swagger.io) or on [irc.freenode.net, #swagger](http://swagger.io/irc/). 
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;
using IO.Swagger.Security;
using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class PetApiController : ControllerBase
    { 
        /// <summary>
        /// Add a new pet to the store
        /// </summary>
        /// <param name="body">Pet object that needs to be added to the store</param>
        /// <response code="405">Invalid input</response>
        [HttpPost]
        [Route("/pet")]
        [ValidateModelState]
        [SwaggerOperation("AddPet")]
        public virtual IActionResult AddPet([FromBody]Pet body)
        { 
            //TODO: Uncomment the next line to return response 405 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(405);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a pet
        /// </summary>
        /// <param name="petId">Pet id to delete</param>
        /// <param name="apiKey"></param>
        /// <response code="400">Invalid ID supplied</response>
        /// <response code="404">Pet not found</response>
        [HttpDelete]
        [Route("/pet/{petId}")]
        [ValidateModelState]
        [SwaggerOperation("DeletePet")]
        public virtual IActionResult DeletePet([FromRoute][Required]long? petId, [FromHeader]string apiKey)
        { 
            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="body"></param>
        /// <response code="200">successful operation</response>
        [HttpPost]
        [Route("/pet/category")]
        [ValidateModelState]
        [SwaggerOperation("DoCategoryStuff")]
        [SwaggerResponse(statusCode: 200, type: typeof(ModelApiResponse), description: "successful operation")]
        public virtual IActionResult DoCategoryStuff([FromBody]SubCategory body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ModelApiResponse));
            string exampleJson = null;
            exampleJson = "{\r\n  \"code\" : 0,\r\n  \"type\" : \"type\",\r\n  \"message\" : \"message\"\r\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ModelApiResponse>(exampleJson)
                        : default(ModelApiResponse);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Finds Pets by status
        /// </summary>
        /// <remarks>Multiple status values can be provided with comma separated strings</remarks>
        /// <param name="status">Status values that need to be considered for filter</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid status value</response>
        [HttpGet]
        [Route("/pet/findByStatus")]
        [ValidateModelState]
        [SwaggerOperation("FindPetsByStatus")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Pet>), description: "successful operation")]
        public virtual IActionResult FindPetsByStatus([FromQuery][Required()]List<string> status)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Pet>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"photoUrls\" : [ \"photoUrls\", \"photoUrls\" ],\r\n  \"name\" : \"doggie\",\r\n  \"id\" : 0,\r\n  \"category\" : {\r\n    \"name\" : \"name\",\r\n    \"id\" : 6\r\n  },\r\n  \"tags\" : [ {\r\n    \"name\" : \"name\",\r\n    \"id\" : 1\r\n  }, {\r\n    \"name\" : \"name\",\r\n    \"id\" : 1\r\n  } ],\r\n  \"status\" : \"available\"\r\n}, {\r\n  \"photoUrls\" : [ \"photoUrls\", \"photoUrls\" ],\r\n  \"name\" : \"doggie\",\r\n  \"id\" : 0,\r\n  \"category\" : {\r\n    \"name\" : \"name\",\r\n    \"id\" : 6\r\n  },\r\n  \"tags\" : [ {\r\n    \"name\" : \"name\",\r\n    \"id\" : 1\r\n  }, {\r\n    \"name\" : \"name\",\r\n    \"id\" : 1\r\n  } ],\r\n  \"status\" : \"available\"\r\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<Pet>>(exampleJson)
                        : default(List<Pet>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Finds Pets by tags
        /// </summary>
        /// <remarks>Muliple tags can be provided with comma separated strings. Use\\ \\ tag1, tag2, tag3 for testing.</remarks>
        /// <param name="tags">Tags to filter by</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid tag value</response>
        [HttpGet]
        [Route("/pet/findByTags")]
        [ValidateModelState]
        [SwaggerOperation("FindPetsByTags")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Pet>), description: "successful operation")]
        public virtual IActionResult FindPetsByTags([FromQuery][Required()]List<string> tags)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Pet>));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);
            string exampleJson = null;
            exampleJson = "[ {\r\n  \"photoUrls\" : [ \"photoUrls\", \"photoUrls\" ],\r\n  \"name\" : \"doggie\",\r\n  \"id\" : 0,\r\n  \"category\" : {\r\n    \"name\" : \"name\",\r\n    \"id\" : 6\r\n  },\r\n  \"tags\" : [ {\r\n    \"name\" : \"name\",\r\n    \"id\" : 1\r\n  }, {\r\n    \"name\" : \"name\",\r\n    \"id\" : 1\r\n  } ],\r\n  \"status\" : \"available\"\r\n}, {\r\n  \"photoUrls\" : [ \"photoUrls\", \"photoUrls\" ],\r\n  \"name\" : \"doggie\",\r\n  \"id\" : 0,\r\n  \"category\" : {\r\n    \"name\" : \"name\",\r\n    \"id\" : 6\r\n  },\r\n  \"tags\" : [ {\r\n    \"name\" : \"name\",\r\n    \"id\" : 1\r\n  }, {\r\n    \"name\" : \"name\",\r\n    \"id\" : 1\r\n  } ],\r\n  \"status\" : \"available\"\r\n} ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<List<Pet>>(exampleJson)
                        : default(List<Pet>);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">a single random pet</response>
        [HttpGet]
        [Route("/allPets")]
        [ValidateModelState]
        [SwaggerOperation("GetAllPets")]
        [SwaggerResponse(statusCode: 200, type: typeof(AllPetsResponse), description: "a single random pet")]
        public virtual IActionResult GetAllPets()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(AllPetsResponse));
            string exampleJson = null;
            exampleJson = "[ \"\", \"\" ]";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<AllPetsResponse>(exampleJson)
                        : default(AllPetsResponse);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Find pet by ID
        /// </summary>
        /// <remarks>Returns a single pet</remarks>
        /// <param name="petId">ID of pet to return</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid ID supplied</response>
        /// <response code="404">Pet not found</response>
        [HttpGet]
        [Route("/pet/{petId}")]
        [Authorize(AuthenticationSchemes = ApiKeyAuthenticationHandler.SchemeName)]
        [ValidateModelState]
        [SwaggerOperation("GetPetById")]
        [SwaggerResponse(statusCode: 200, type: typeof(Pet), description: "successful operation")]
        public virtual IActionResult GetPetById([FromRoute][Required]long? petId)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Pet));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);
            string exampleJson = null;
            exampleJson = "{\r\n  \"photoUrls\" : [ \"photoUrls\", \"photoUrls\" ],\r\n  \"name\" : \"doggie\",\r\n  \"id\" : 0,\r\n  \"category\" : {\r\n    \"name\" : \"name\",\r\n    \"id\" : 6\r\n  },\r\n  \"tags\" : [ {\r\n    \"name\" : \"name\",\r\n    \"id\" : 1\r\n  }, {\r\n    \"name\" : \"name\",\r\n    \"id\" : 1\r\n  } ],\r\n  \"status\" : \"available\"\r\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<Pet>(exampleJson)
                        : default(Pet);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <response code="200">a single random pet</response>
        [HttpGet]
        [Route("/randomPet")]
        [ValidateModelState]
        [SwaggerOperation("GetRandomPet")]
        [SwaggerResponse(statusCode: 200, type: typeof(SinglePetResponse), description: "a single random pet")]
        public virtual IActionResult GetRandomPet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(SinglePetResponse));
            string exampleJson = null;
            exampleJson = "{\r\n  \"pet\" : \"\"\r\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<SinglePetResponse>(exampleJson)
                        : default(SinglePetResponse);            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Update an existing pet
        /// </summary>
        /// <param name="body">Pet object that needs to be added to the store</param>
        /// <response code="400">Invalid ID supplied</response>
        /// <response code="404">Pet not found</response>
        /// <response code="405">Validation exception</response>
        [HttpPut]
        [Route("/pet")]
        [ValidateModelState]
        [SwaggerOperation("UpdatePet")]
        public virtual IActionResult UpdatePet([FromBody]Pet body)
        { 
            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400);

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404);

            //TODO: Uncomment the next line to return response 405 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(405);

            throw new NotImplementedException();
        }


        /// <summary>
        /// uploads an image
        /// </summary>
        /// <param name="petId">ID of pet to update</param>
        /// <param name="body"></param>
        /// <response code="200">successful operation</response>
        [HttpPost]
        [Route("/pet/{petId}/uploadImage")]
        [ValidateModelState]
        [SwaggerOperation("UploadFile")]
        [SwaggerResponse(statusCode: 200, type: typeof(ModelApiResponse), description: "successful operation")]
        public virtual IActionResult UploadFile([FromRoute][Required]long? petId, [FromBody]Object body)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(ModelApiResponse));
            string exampleJson = null;
            exampleJson = "{\r\n  \"code\" : 0,\r\n  \"type\" : \"type\",\r\n  \"message\" : \"message\"\r\n}";
            
                        var example = exampleJson != null
                        ? JsonConvert.DeserializeObject<ModelApiResponse>(exampleJson)
                        : default(ModelApiResponse);            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
