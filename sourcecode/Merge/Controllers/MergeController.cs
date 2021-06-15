using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Merge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MergeController : ControllerBase
    {
       

        private  IConfiguration Configuration;
        public MergeController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //var accountNumService = "https://localhost:44315/accountNumber"; // without this link the code will not work 
            var accountNumService = $"{Configuration["accountNumberServiceURL"]}/accountNumber";

            var serviceOneResponseCall = await new HttpClient().GetStringAsync(accountNumService);
            //var namesService = "https://localhost:44311/names";

            var namesService = $"{Configuration["nameServiceURL"]}/Names";

            var serviceTwoResponseCall = await new HttpClient().GetStringAsync(namesService);
            //var prize = GetPrize();
           
             if (serviceTwoResponseCall == "samia" && serviceOneResponseCall == "176583")
            {
                var Prize = "£50";
                var mergedServiceResponse = $"{serviceTwoResponseCall}  is assigned to    {serviceOneResponseCall} Account Number and won a prize of {Prize} ";
                return Ok(mergedServiceResponse);
            }
            else if (serviceTwoResponseCall == "amina" && serviceOneResponseCall == "176583")
            {
                var Prize = "£50";
                var mergedServiceResponse = $"{serviceTwoResponseCall}  is assigned to    {serviceOneResponseCall} Account Number and won a prize of {Prize} ";
                return Ok(mergedServiceResponse);
            }
            else if (serviceTwoResponseCall == "zahid" && serviceOneResponseCall == "176583")
            {
                var Prize = "£50";
                var mergedServiceResponse = $"{serviceTwoResponseCall}  is assigned to  {serviceOneResponseCall} Account Number and won a prize of {Prize} ";
                return Ok(mergedServiceResponse);
            }
            else if (serviceTwoResponseCall == "rehaan" && serviceOneResponseCall == "176583")
            {
                var Prize = "£50";
                var mergedServiceResponse = $"{serviceTwoResponseCall}  is assigned to    {serviceOneResponseCall} Account Number and won a prize of {Prize} ";
                return Ok(mergedServiceResponse);
            }
           else if (serviceTwoResponseCall == "zain" && serviceOneResponseCall == "176583")
            {
                var Prize = "£50";
                var mergedServiceResponse = $"{serviceTwoResponseCall}  is assigned to    {serviceOneResponseCall} Account Number and won a prize of {Prize} ";
                return Ok(mergedServiceResponse);
            }
            else if (serviceTwoResponseCall == "samia" && serviceOneResponseCall == "298654")
            {
                var Prize = "£100";
                var mergedServiceResponse = $"{serviceTwoResponseCall}  is assigned to    {serviceOneResponseCall} Account Number and won a prize of {Prize} ";
                return Ok(mergedServiceResponse);
            }
            else if (serviceTwoResponseCall == "amina" && serviceOneResponseCall == "298654")
            {
                var Prize = "£100";
                var mergedServiceResponse = $"{serviceTwoResponseCall}  is assigned to    {serviceOneResponseCall} Account Number and won a prize of {Prize} ";
                return Ok(mergedServiceResponse);
            }
            else if (serviceTwoResponseCall == "zahid" && serviceOneResponseCall == "298654")
            {
                var Prize = "£100";
                var mergedServiceResponse = $"{serviceTwoResponseCall}  is assigned to    {serviceOneResponseCall} Account Number and won a prize of {Prize} ";
                return Ok(mergedServiceResponse);
            }
            else if (serviceTwoResponseCall == "rehaan" && serviceOneResponseCall == "298654")
            {
                var Prize = "£100";
                var mergedServiceResponse = $"{serviceTwoResponseCall}  is assigned to    {serviceOneResponseCall} Account Number and won a prize of {Prize} ";
                return Ok(mergedServiceResponse);
            }
            else if (serviceTwoResponseCall == "zain" && serviceOneResponseCall == "298654")
            {
                var Prize = "£100";
                var mergedServiceResponse = $"{serviceTwoResponseCall}  is assigned to    {serviceOneResponseCall} Account Number and won a prize of {Prize} ";
                return Ok(mergedServiceResponse);
            }
            else if (serviceTwoResponseCall == "samia" && serviceOneResponseCall == "387697")
            {
                var Prize = "£150";
                var mergedServiceResponse = $"{serviceTwoResponseCall}  is assigned to    {serviceOneResponseCall} Account Number and won a prize of {Prize} ";
                return Ok(mergedServiceResponse);
            }
            else if (serviceTwoResponseCall == "amina" && serviceOneResponseCall == "387697")
            {
                var Prize = "£150";
                var mergedServiceResponse = $"{serviceTwoResponseCall}  is assigned to    {serviceOneResponseCall} Account Number and won a prize of {Prize} ";
                return Ok(mergedServiceResponse);
            }
            else if (serviceTwoResponseCall == "zahid" && serviceOneResponseCall == "387697")
            {
                var Prize = "£150";
                var mergedServiceResponse = $"{serviceTwoResponseCall}  is assigned to    {serviceOneResponseCall} Account Number and won a prize of {Prize} ";
                return Ok(mergedServiceResponse);
            }
            else if (serviceTwoResponseCall == "zain" && serviceOneResponseCall == "387697")
            {
                var Prize = "£150";
                var mergedServiceResponse = $"{serviceTwoResponseCall}  is assigned to    {serviceOneResponseCall} Account Number and won a prize of {Prize} ";
                return Ok(mergedServiceResponse);
            }
            else if (serviceTwoResponseCall == "rehaan" && serviceOneResponseCall == "387697")
            {
                var Prize = "£150";
                var mergedServiceResponse = $"{serviceTwoResponseCall}  is assigned to    {serviceOneResponseCall} Account Number and won a prize of {Prize} ";
                return Ok(mergedServiceResponse);
            }
            else if (serviceTwoResponseCall == "rehaan" && serviceOneResponseCall == "490866")
            {
                var Prize = "£200";
                var mergedServiceResponse = $"{serviceTwoResponseCall}  is assigned to    {serviceOneResponseCall} Account Number and won a prize of {Prize} ";
                return Ok(mergedServiceResponse);
            }
            else if (serviceTwoResponseCall == "samia" && serviceOneResponseCall == "490866")
            {
                var Prize = "£200";
                var mergedServiceResponse = $"{serviceTwoResponseCall}  is assigned to    {serviceOneResponseCall} Account Number and won a prize of {Prize} ";
                return Ok(mergedServiceResponse);
            }
            else if (serviceTwoResponseCall == "amina" && serviceOneResponseCall == "490866")
            {
                var Prize = "£200";
                var mergedServiceResponse = $"{serviceTwoResponseCall}  is assigned to    {serviceOneResponseCall} Account Number and won a prize of {Prize} ";
                return Ok(mergedServiceResponse);
            }
            else if (serviceTwoResponseCall == "zahid" && serviceOneResponseCall == "490866")
            {
                var Prize = "£200";
                var mergedServiceResponse = $"{serviceTwoResponseCall}  is assigned to    {serviceOneResponseCall} Account Number and won a prize of {Prize} ";
                return Ok(mergedServiceResponse);
            }
            else if (serviceTwoResponseCall == "zain" && serviceOneResponseCall == "490866")
            {
                var Prize = "£200";
                var mergedServiceResponse = $"{serviceTwoResponseCall}  is assigned to    {serviceOneResponseCall} Account Number and won a prize of {Prize} ";
                return Ok(mergedServiceResponse);
            }
            else if (serviceTwoResponseCall == "zain" && serviceOneResponseCall == "587678")
            {
                var Prize = "£200";
                var mergedServiceResponse = $"{serviceTwoResponseCall}  is assigned to    {serviceOneResponseCall} Account Number and won a prize of {Prize} ";
                return Ok(mergedServiceResponse);
            }
            else if (serviceTwoResponseCall == "samia" && serviceOneResponseCall == "587678")
            {
                var Prize = "£500";
                var mergedServiceResponse = $"{serviceTwoResponseCall}  is assigned to    {serviceOneResponseCall} Account Number and won a prize of {Prize} ";
                return Ok(mergedServiceResponse);
            }
            else if (serviceTwoResponseCall == "amina" && serviceOneResponseCall == "587678")
            {
                var Prize = "£500";
                var mergedServiceResponse = $"{serviceTwoResponseCall}  is assigned to    {serviceOneResponseCall} Account Number  and won a prize of {Prize} ";
                return Ok(mergedServiceResponse);
            }
            else if (serviceTwoResponseCall == "zahid" && serviceOneResponseCall == "587678")
            {
                var Prize = "£500";
                var mergedServiceResponse = $"{serviceTwoResponseCall}  is assigned to    {serviceOneResponseCall} Account Number and won a prize of {Prize} ";
                return Ok(mergedServiceResponse);
            }
            else if (serviceTwoResponseCall == "rehaan" && serviceOneResponseCall == "587678")
            {
                var Prize = "£500";
                var mergedServiceResponse = $"{serviceTwoResponseCall}  is assigned to  {serviceOneResponseCall} Account Number and won a prize of {Prize} ";
                return Ok(mergedServiceResponse);
            }
            else
            {
                return Ok("Unfortunately, you won no prize today"); }
        }


    }
}
    
    
