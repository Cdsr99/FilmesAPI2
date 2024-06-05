using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

/// <summary>
/// 
/// </summary>
public class CreateFilmeDto
{
    /// <summary>
    /// 
    /// </summary>
    [Required(ErrorMessage = "O título do filme é obrigatório")]
    public string? Titulo { get; set; }
    /// <summary>
    /// 
    /// </summary>
    [Required(ErrorMessage = "O gênero do filme é obrigatório")]
    [StringLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
    public string? Genero { get; set; }
    /// <summary>
    /// 
    /// </summary>
    [Required]
    [Range(70, 600, ErrorMessage = "A duração deve ter entre 70 e 600 minutos")]
    public int Duracao { get; set; }
}
