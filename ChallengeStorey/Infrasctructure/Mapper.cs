using ChallengeStorey.Data.Models;
using ChallengeStorey.DTO;

namespace ChallengeStorey.Infrasctructure
{
	public class Mapper
	{
		public static void MapCategoria(Categoria source, CategoriaResponse target)
		{
			target.categoria = source.Nombre;
			target.items = source.Items.Select(i => 
						   new CategoriaItemResponse { elemento = i.Elemento, valor = i.Valor }).ToList();
		}
	}
}
