using System.ComponentModel.DataAnnotations;
namespace Registro.Models;
public class IDocupacion
{
    [Key]
    public int ocupacionID { get; set; }
    public String? Descripcion { get; set; }
    public int Salario {get; set;}

}