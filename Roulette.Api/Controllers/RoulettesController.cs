﻿using Microsoft.AspNetCore.Mvc;
using RouletteMS.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteMS.Api.Controllers
{
    [Route("api/[controller]")]
    public class RoulettesController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> Post()
        {
            return Ok();
        }
        [HttpPatch("{id}/open")]
        public async Task<IActionResult> Open()
        {
            return Ok();
        }
        [HttpPost("{id}/bet")]
        public async Task<IActionResult> Bet(BetModel model)
        {
            return Ok();
        }
        [HttpPatch("{id}/close")]
        public async Task<IActionResult> Close()
        {
            return Ok();
        }
    }
}
