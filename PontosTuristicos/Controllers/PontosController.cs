using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using PontosTuristicos.Models;
using Microsoft.AspNetCore.Mvc;
using PontosTuristicos.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PontosTuristicos.Viewmodels;

namespace PontosTuristicos.Controllers
{
    [ApiController]
    [Route("v1")]
    public class PontosController: ControllerBase
    {
        [HttpGet]
        [Route("pontos")]
        public async Task<IActionResult> GetAsync(
            [FromServices]AppDbContext context)
        {
            var pontos = await context
                .Ponto
                .AsNoTracking()
                .ToListAsync();
            return Ok(pontos);
        }

        [HttpGet]
        [Route("pontos/{nome}")]
        public async Task<IActionResult> GetByNameAsync(
           [FromServices] AppDbContext context,
           [FromRoute] string nome)
        {

            var ponto = await context
                .Ponto
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Nome == nome);
            return ponto == null ? NotFound() : Ok(ponto);
        }

        [HttpPost("pontos")]
        public async Task<IActionResult> PostAsync(
            [FromServices] AppDbContext context,
            [FromBody] CreatePontoViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var ponto = new Pontos
            {
                Nome = model.Nome,
                Localizacao = model.Localizacao,
                Descricao = model.Descricao,
                Cidade = model.Cidade,
                Estado = model.Estado,
            };
            try
            {
                await context.Ponto.AddAsync(ponto);
                await context.SaveChangesAsync();
                return Created($"v1/pontos/{ponto.Nome}", ponto);

            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpPut("pontos/{nome}")]
        public async Task<IActionResult> PutAsync(
            [FromServices] AppDbContext context,
            [FromBody] CreatePontoViewModel model,
            [FromRoute] string nome)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var ponto = await context.Ponto.FirstOrDefaultAsync(x => x.Nome == nome);

            if (ponto == null)
                return NotFound();

            try 
            {
                ponto.Nome = model.Nome;
                ponto.Localizacao = model.Localizacao;
                ponto.Descricao = model.Descricao;
                ponto.Cidade = model.Cidade;
                ponto.Estado = model.Estado;

                context.Ponto.Update(ponto);
                await context.SaveChangesAsync();
                return Ok(ponto);
            }

            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete("pontos/{nome}")]
        public async Task<IActionResult> DeleteAsync(
            [FromServices] AppDbContext context,
            [FromRoute] string nome)
        {
            var ponto = await context.Ponto.FirstOrDefaultAsync(x => x.Nome == nome);

            try
            {
                context.Ponto.Remove(ponto);
                await context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
    }
}
