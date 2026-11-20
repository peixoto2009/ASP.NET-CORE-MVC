using System.ComponentModel.DataAnnotations;
namespace EmployeesManagement.Models
{
public class Employee
{
public int Id { get; set; }
[Required(ErrorMessage = "O nome é obrigatório.")]
[StringLength(100, MinimumLength = 3)]
public string Nome { get; set; } = string.Empty;
[Required(ErrorMessage = "O cargo é obrigatório.")]
[StringLength(100)]
public string Cargo { get; set; } = string.Empty;
[Range(1, 100000, ErrorMessage = "O salário deve ser um valor positivo.")]
public decimal Salario { get; set; }
[DataType(DataType.Date)]
[Display(Name = "Data de Admissão")]
public DateTime DataAdmissao { get; set; }
[EmailAddress(ErrorMessage = "Introduz um endereço de email válido.")]
public string? Email { get; set; }
}
}