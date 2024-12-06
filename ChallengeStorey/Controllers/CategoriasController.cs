using ChallengeStorey.Comun.Wrapper;
using ChallengeStorey.DTO;
using ChallengeStorey.Infrasctructure;
using ChallengeStorey.Service;
using Microsoft.AspNetCore.Mvc;

namespace ChallengeStorey.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoriasController : ControllerBase
	{
		private readonly IStoreyService _service;

        public CategoriasController(IStoreyService service)
        {
            _service = service;
        }

		/// <summary>
		/// Api para consultar una lista de Categorias.
		/// </summary>
		/// <param name="categorias"></param>
		/// <remarks>
		/// </remarks>
		/// <returns>Status 200 OK</returns>		
		[HttpGet]
		public async Task<IActionResult> Categorias()
		{
			try
			{
				var response = new BaseResponse();
				var categorias = await _service.GetCategorias();
				var model = categorias.Select(c =>
				{
					var categoriaResponse = new CategoriaResponse();
					Mapper.MapCategoria(c, categoriaResponse);
					return categoriaResponse;
				}).ToList();

				response.Body = model;
				response.Success = true;
				return Ok(response);
			}
			catch (Exception e)
			{
				throw new Exception(e.Message);
			}			
		}
    }
}
